using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinForms_TEST
{
    public partial class ReceptionForm : Form
    {
        string connectionString = @"Data Source=YOUSEFEL-BASUON;Initial Catalog=Taybah Center;Integrated Security=True;TrustServerCertificate=True;";

        decimal currentInvoicePrice = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string LoggedInUserName { get; set; } = "المستخدم";
        public string UserRole { get; set; } = "Admin";

        public ReceptionForm()
        {
            InitializeComponent();
            pnlHeader.MouseDown += new MouseEventHandler(Header_MouseDown);
            lblTitle.MouseDown += new MouseEventHandler(Header_MouseDown);
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            dtpBookingDate.Value = DateTime.Now;

            // Ensure schema is correct globally before any data is loaded
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    new SqlCommand(@"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='MedicalReports' AND xtype='U')
                            CREATE TABLE MedicalReports (ReportID INT IDENTITY PRIMARY KEY, PatientName NVARCHAR(200), DoctorName NVARCHAR(200), ScanType NVARCHAR(100), ReportDate DATE, Diagnosis NVARCHAR(MAX), Notes NVARCHAR(MAX));
                        ELSE IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ReportID' AND Object_ID = Object_ID(N'MedicalReports'))
                        BEGIN
                            ALTER TABLE MedicalReports ADD ReportID INT IDENTITY PRIMARY KEY;
                        END
                    ", conn).ExecuteNonQuery();
                }
            }
            catch { /* Ignore schema update errors */ }

            LoadPatients();
            LoadExams();

            lblUserName.Text = LoggedInUserName;

            if (UserRole == "Assistant")
            {
                lblUserRole.Text = "مساعد";
                // Assistant يشوف: داشبورد + تسجيل المرضى + الحجوزات + قائمة المرضى
                // بس مش الفاتورة (دي للمدير فقط)
                btnInvoice.Visible = false;
                lblPrice.Visible = false;
                // يفتح الداشبورد أول ما يدخل
                SwitchPage(pnlPageDashboard, btnNavDashboard);
            }
            else if (UserRole == "Doctor")
            {
                lblUserRole.Text = "طبيب";
                // Doctor: يشوف الداشبورد والمرضى والتقارير - بس مش تسجيل أو فاتورة
                btnNavRegister.Visible = false;
                btnInvoice.Visible = false;
                lblPrice.Visible = false;

                Button btnNavMedicalReports = new Button();
                btnNavMedicalReports.Name = "btnNavMedicalReports";
                btnNavMedicalReports.Text = "  📝 تسجيل تقرير لمريض";
                btnNavMedicalReports.Dock = DockStyle.Top;
                btnNavMedicalReports.Height = 60;
                btnNavMedicalReports.FlatStyle = FlatStyle.Flat;
                btnNavMedicalReports.FlatAppearance.BorderSize = 0;
                btnNavMedicalReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
                btnNavMedicalReports.BackColor = Color.FromArgb(33, 43, 54);
                btnNavMedicalReports.ForeColor = Color.White;
                btnNavMedicalReports.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                btnNavMedicalReports.Cursor = Cursors.Hand;
                btnNavMedicalReports.TextAlign = ContentAlignment.MiddleRight;
                
                // Change the Patients button text as requested
                btnNavPatients.Text = "  👥 إدارة المرضى";

                pnlSidebar.Controls.Add(btnNavMedicalReports);
                int patientIdx = pnlSidebar.Controls.GetChildIndex(btnNavPatients);
                pnlSidebar.Controls.SetChildIndex(btnNavMedicalReports, patientIdx);

                // ===== Medical Reports Page Panel (clean redesign) =====
                Panel pnlPageMedicalReports = new Panel();
                pnlPageMedicalReports.Name = "pnlPageMedicalReports";
                pnlPageMedicalReports.Visible = false;
                pnlPageMedicalReports.Dock = DockStyle.Fill;
                pnlPageMedicalReports.BackColor = Color.FromArgb(245, 247, 250);
                pnlPageMedicalReports.AutoScroll = true;
                pnlMain.Controls.Add(pnlPageMedicalReports);

                // ---- Card 1: Patient Info ----
                Panel cardInfo = new Panel();
                cardInfo.BackColor = Color.White;
                cardInfo.Location = new Point(20, 20);
                cardInfo.Size = new Size(760, 160);
                cardInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                Label lblSectionTitle1 = new Label { Text = "📋 بيانات المريض والزيارة", Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = Color.FromArgb(41, 128, 185), AutoSize = true, Location = new Point(cardInfo.Width - 220, 15) };
                lblSectionTitle1.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                // Row 1: Patient ComboBox (right) | Doctor Name (left - auto-filled)
                Label lPat = new Label { Text = "اسم المريض", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(390, 45) };
                // ComboBox to pick a registered patient from DB
                ComboBox cmbRepPatient = new ComboBox
                {
                    Font = new Font("Segoe UI", 10),
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Location = new Point(390, 65),
                    Width = 320,
                    FlatStyle = FlatStyle.Flat
                };
                cmbRepPatient.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                // Load patients from DB into the ComboBox
                try
                {
                    using (SqlConnection conPat = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter daPat = new SqlDataAdapter("SELECT PatientID, FullName FROM Patients ORDER BY FullName", conPat);
                        DataTable dtPat = new DataTable();
                        daPat.Fill(dtPat);
                        cmbRepPatient.DisplayMember = "FullName";
                        cmbRepPatient.ValueMember   = "PatientID";
                        cmbRepPatient.DataSource    = dtPat;
                        cmbRepPatient.SelectedIndex = -1;
                    }
                }
                catch { /* will show error on save if still empty */ }

                Label lDoc = new Label { Text = "الطبيب المعالج", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(30, 45) };
                TextBox txtDoc = new TextBox { Font = new Font("Segoe UI", 10), Location = new Point(30, 65), Width = 320, Height = 32, BorderStyle = BorderStyle.FixedSingle };
                // Auto-fill with logged-in doctor name
                txtDoc.Text = LoggedInUserName;

                // Row 2: Scan Type (right) | Date (left)
                Label lScan = new Label { Text = "نوع الأشعة", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(390, 105) };
                ComboBox cmbScan = new ComboBox { Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(390, 122), Width = 320, FlatStyle = FlatStyle.Flat };
                cmbScan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                cmbScan.Items.AddRange(new object[] { "أشعة سينية (X-Ray)", "رنين مغناطيسي (MRI)", "أشعة مقطعية (CT Scan)", "موجات فوق صوتية (Ultrasound)" });

                Label lDate = new Label { Text = "تاريخ التقرير", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(30, 105) };
                DateTimePicker dtpRep = new DateTimePicker { Font = new Font("Segoe UI", 10), Format = DateTimePickerFormat.Short, Location = new Point(30, 122), Width = 250 };

                cardInfo.Controls.AddRange(new Control[] { lblSectionTitle1, lPat, cmbRepPatient, lDoc, txtDoc, lScan, cmbScan, lDate, dtpRep });

                // ---- Card 2: Report Details ----
                Panel cardDetails = new Panel();
                cardDetails.BackColor = Color.White;
                cardDetails.Location = new Point(20, 200);
                cardDetails.Size = new Size(760, 310);
                cardDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                Label lblSectionTitle2 = new Label { Text = "📝 تفاصيل التقرير الطبي", Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = Color.FromArgb(41, 128, 185), AutoSize = true, Location = new Point(cardDetails.Width - 225, 15) };
                lblSectionTitle2.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                Label lDiag = new Label { Text = "التشخيص", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(cardDetails.Width - 85, 50) };
                lDiag.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                RichTextBox rtbDiag = new RichTextBox { Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle, Location = new Point(20, 68), Height = 100, ScrollBars = RichTextBoxScrollBars.Vertical };
                rtbDiag.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                Label lNotes = new Label { Text = "ملاحظات", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(cardDetails.Width - 80, 180) };
                lNotes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                RichTextBox rtbNotes2 = new RichTextBox { Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle, Location = new Point(20, 198), Height = 85, ScrollBars = RichTextBoxScrollBars.Vertical };
                rtbNotes2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                cardDetails.Controls.AddRange(new Control[] { lblSectionTitle2, lDiag, rtbDiag, lNotes, rtbNotes2 });

                // ---- Buttons ----
                Button btnSaveRep = new Button { Text = "💾 حفظ التقرير", Font = new Font("Segoe UI", 10, FontStyle.Bold), BackColor = Color.FromArgb(26, 188, 156), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(20, 530), Size = new Size(160, 44), Cursor = Cursors.Hand };
                btnSaveRep.FlatAppearance.BorderSize = 0;
                Button btnClearRep = new Button { Text = "مسح ↺", Font = new Font("Segoe UI", 10, FontStyle.Bold), BackColor = Color.FromArgb(236, 240, 241), ForeColor = Color.FromArgb(60, 60, 60), FlatStyle = FlatStyle.Flat, Location = new Point(190, 530), Size = new Size(120, 44), Cursor = Cursors.Hand };
                btnClearRep.FlatAppearance.BorderSize = 0;

                // Resize: keep cards & RTBs stretched to full width
                pnlPageMedicalReports.Resize += (s, ev) => {
                    int w = pnlPageMedicalReports.ClientSize.Width - 40;
                    if (w < 200) return;
                    cardInfo.Width = w;
                    cardDetails.Width = w;
                    rtbDiag.Width = w - 40;
                    rtbNotes2.Width = w - 40;
                    lblSectionTitle1.Left = cardInfo.Width - 230;
                    lblSectionTitle2.Left = cardDetails.Width - 240;
                    lDiag.Left = cardDetails.Width - 90;
                    lNotes.Left = cardDetails.Width - 85;
                    cmbRepPatient.Left = w - 330;
                    lPat.Left = w - 330;
                    cmbScan.Left = w - 330;
                    lScan.Left = w - 330;
                };

                btnSaveRep.Click += (s, ev) => {
                    if (cmbRepPatient.SelectedItem == null || string.IsNullOrWhiteSpace(rtbDiag.Text))
                    { MessageBox.Show("لازم تختار اسم المريض وتكتب التشخيص!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                    string selectedPatientName = ((DataRowView)cmbRepPatient.SelectedItem)["FullName"].ToString()!;
                    try {
                        using (SqlConnection con = new SqlConnection(connectionString)) {
                            con.Open();
                            // Ensure MedicalReports table exists and has ReportID column
                            new SqlCommand(@"
                                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='MedicalReports' AND xtype='U')
                                    CREATE TABLE MedicalReports (ReportID INT IDENTITY PRIMARY KEY, PatientName NVARCHAR(200), DoctorName NVARCHAR(200), ScanType NVARCHAR(100), ReportDate DATE, Diagnosis NVARCHAR(MAX), Notes NVARCHAR(MAX));
                                ELSE IF NOT EXISTS(SELECT * FROM sys.columns WHERE Name = N'ReportID' AND Object_ID = Object_ID(N'MedicalReports'))
                                BEGIN
                                    ALTER TABLE MedicalReports ADD ReportID INT IDENTITY PRIMARY KEY;
                                END
                            ", con).ExecuteNonQuery();
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO MedicalReports (PatientName,DoctorName,ScanType,ReportDate,Diagnosis,Notes) VALUES (@p,@d,@s,@dt,@diag,@n)", con)) {
                                cmd.Parameters.AddWithValue("@p", selectedPatientName);
                                cmd.Parameters.AddWithValue("@d", txtDoc.Text.Trim());
                                cmd.Parameters.AddWithValue("@s", cmbScan.Text);
                                cmd.Parameters.AddWithValue("@dt", dtpRep.Value);
                                cmd.Parameters.AddWithValue("@diag", rtbDiag.Text.Trim());
                                cmd.Parameters.AddWithValue("@n", rtbNotes2.Text.Trim());
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("تم حفظ التقرير بنجاح! 🎉", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbRepPatient.SelectedIndex = -1;
                        txtDoc.Text = LoggedInUserName;
                        cmbScan.SelectedIndex = -1;
                        rtbDiag.Clear();
                        rtbNotes2.Clear();
                        dtpRep.Value = DateTime.Now;
                    } catch (Exception ex) { MessageBox.Show("خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                };

                btnClearRep.Click += (s, ev) => {
                    cmbRepPatient.SelectedIndex = -1;
                    txtDoc.Text = LoggedInUserName;
                    cmbScan.SelectedIndex = -1;
                    rtbDiag.Clear();
                    rtbNotes2.Clear();
                    dtpRep.Value = DateTime.Now;
                };

                pnlPageMedicalReports.Controls.AddRange(new Control[] { cardInfo, cardDetails, btnSaveRep, btnClearRep });

                btnNavMedicalReports.Click += (s, ev) =>
                {
                    SwitchPage(pnlPageMedicalReports, btnNavMedicalReports);
                };

                // Doctor can also manage assistants assigned to them
                AddEmployeeManagementButton("Doctor");

                // Doctor يفتح على الداشبورد أول ما يدخل
                SwitchPage(pnlPageDashboard, btnNavDashboard);
            }
            else
            {
                lblUserRole.Text = "مدير النظام";
                // Admin (manager) can fully manage employees
                AddEmployeeManagementButton("Admin");
                SwitchPage(pnlPageDashboard, btnNavDashboard);
            }

            // Add Delete button to Grid if not exists
            if (!dgvData.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "DeleteColumn";
                deleteButtonColumn.HeaderText = "حذف";
                deleteButtonColumn.Text = "🗑️";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                deleteButtonColumn.FlatStyle = FlatStyle.Flat;
                dgvData.Columns.Add(deleteButtonColumn);
            }

            // Pre-fill settings name box
            txtSettingName.Text = LoggedInUserName;

            // Add "current name" info label to Settings page
            Label lblCurrentName = new Label();
            lblCurrentName.Text = $"الاسم الحالي: {LoggedInUserName}";
            lblCurrentName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblCurrentName.ForeColor = Color.FromArgb(120, 130, 140);
            lblCurrentName.AutoSize = true;
            lblCurrentName.Location = new Point(350, 215);
            lblCurrentName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlPageSettings.Controls.Add(lblCurrentName);

            // Avatar setup
            Button btnChangeAvatar = new Button();
            btnChangeAvatar.Text = "تغيير الصورة 📷";
            btnChangeAvatar.Size = new Size(180, 40);
            btnChangeAvatar.Location = new Point(txtSettingName.Location.X, txtSettingName.Location.Y + 80);
            btnChangeAvatar.BackColor = Color.FromArgb(41, 128, 185);
            btnChangeAvatar.ForeColor = Color.White;
            btnChangeAvatar.FlatStyle = FlatStyle.Flat;
            btnChangeAvatar.FlatAppearance.BorderSize = 0;
            btnChangeAvatar.Cursor = Cursors.Hand;
            btnChangeAvatar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnChangeAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeAvatar.Click += BtnChangeAvatar_Click;
            pnlPageSettings.Controls.Add(btnChangeAvatar);

            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            string avatarPath = System.IO.Path.Combine(Application.StartupPath, "avatar.png");
            if (System.IO.File.Exists(avatarPath))
            {
                using (var ms = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(avatarPath)))
                {
                    pbAvatar.Image = Image.FromStream(ms);
                }
            }

            LoadGridData();
        }

        /// <summary>
        /// Adds an "Employee Management" button to the sidebar dynamically.
        /// Also creates its internal Panel page so it appears seamlessly inside the dashboard.
        /// </summary>
        private void AddEmployeeManagementButton(string role)
        {
            Button btnNavEmployees = new Button();
            btnNavEmployees.Name = "btnNavEmployees";
            btnNavEmployees.Text = "  👥 إدارة الموظفين";
            btnNavEmployees.Dock = DockStyle.Top;
            btnNavEmployees.Height = 60;
            btnNavEmployees.FlatStyle = FlatStyle.Flat;
            btnNavEmployees.FlatAppearance.BorderSize = 0;
            btnNavEmployees.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            btnNavEmployees.BackColor = Color.FromArgb(33, 43, 54);
            btnNavEmployees.ForeColor = Color.White;
            btnNavEmployees.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnNavEmployees.Cursor = Cursors.Hand;
            btnNavEmployees.TextAlign = ContentAlignment.MiddleRight;

            pnlSidebar.Controls.Add(btnNavEmployees);
            int settingsIdx = pnlSidebar.Controls.GetChildIndex(btnNavSettings);
            pnlSidebar.Controls.SetChildIndex(btnNavEmployees, settingsIdx);

            // Create the Page Panel
            Panel pnlPageEmployees = new Panel();
            pnlPageEmployees.Name = "pnlPageEmployees";
            pnlPageEmployees.Visible = false;
            pnlPageEmployees.Dock = DockStyle.Fill;
            pnlPageEmployees.BackColor = Color.FromArgb(245, 247, 250);
            pnlPageEmployees.AutoScroll = true;
            pnlMain.Controls.Add(pnlPageEmployees);

            // ---- Input Card ----
            Panel cardInput = new Panel { BackColor = Color.White, Location = new Point(20, 20), Size = new Size(760, 200), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            Label lblTitle = new Label { Text = "👥 بيانات الموظفين", Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = Color.FromArgb(41, 128, 185), AutoSize = true, Location = new Point(cardInput.Width - 160, 15), Anchor = AnchorStyles.Top | AnchorStyles.Right };

            Label lName = new Label { Text = "الاسم بالكامل", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(cardInput.Width - 110, 50), Anchor = AnchorStyles.Top | AnchorStyles.Right };
            TextBox txtFullName = new TextBox { Font = new Font("Segoe UI", 10), Location = new Point(cardInput.Width - 320, 70), Width = 300, BorderStyle = BorderStyle.FixedSingle, Anchor = AnchorStyles.Top | AnchorStyles.Right };

            Label lUser = new Label { Text = "اسم المستخدم", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(cardInput.Width - 440, 50), Anchor = AnchorStyles.Top | AnchorStyles.Right };
            TextBox txtUsername = new TextBox { Font = new Font("Segoe UI", 10), Location = new Point(cardInput.Width - 650, 70), Width = 300, BorderStyle = BorderStyle.FixedSingle, Anchor = AnchorStyles.Top | AnchorStyles.Right };

            Label lPass = new Label { Text = "كلمة المرور", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(cardInput.Width - 110, 110), Anchor = AnchorStyles.Top | AnchorStyles.Right };
            TextBox txtPassword = new TextBox { Font = new Font("Segoe UI", 10), Location = new Point(cardInput.Width - 320, 130), Width = 300, BorderStyle = BorderStyle.FixedSingle, Anchor = AnchorStyles.Top | AnchorStyles.Right, UseSystemPasswordChar = true };

            Label lRole = new Label { Text = "الدور (النوع)", AutoSize = true, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.Gray, Location = new Point(cardInput.Width - 440, 110), Anchor = AnchorStyles.Top | AnchorStyles.Right };
            ComboBox cmbRole = new ComboBox { Font = new Font("Segoe UI", 10), DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(cardInput.Width - 650, 130), Width = 300, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            cmbRole.Items.AddRange(new object[] { "Assistant", "Doctor", "Admin" });

            cardInput.Controls.AddRange(new Control[] { lblTitle, lName, txtFullName, lUser, txtUsername, lPass, txtPassword, lRole, cmbRole });

            // ---- Buttons ----
            Button btnAddEmp = new Button { Text = "إضافة ➕", Font = new Font("Segoe UI", 10, FontStyle.Bold), BackColor = Color.FromArgb(26, 188, 156), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(cardInput.Width - 140, 235), Size = new Size(120, 40), Cursor = Cursors.Hand, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            btnAddEmp.FlatAppearance.BorderSize = 0;
            Button btnUpdateEmp = new Button { Text = "تعديل ✏️", Font = new Font("Segoe UI", 10, FontStyle.Bold), BackColor = Color.FromArgb(41, 128, 185), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(cardInput.Width - 270, 235), Size = new Size(120, 40), Cursor = Cursors.Hand, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            btnUpdateEmp.FlatAppearance.BorderSize = 0;
            Button btnDelEmp = new Button { Text = "حذف 🗑️", Font = new Font("Segoe UI", 10, FontStyle.Bold), BackColor = Color.FromArgb(231, 76, 60), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(cardInput.Width - 400, 235), Size = new Size(120, 40), Cursor = Cursors.Hand, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            btnDelEmp.FlatAppearance.BorderSize = 0;
            Button btnClearEmp = new Button { Text = "تفريغ ↺", Font = new Font("Segoe UI", 10, FontStyle.Bold), BackColor = Color.FromArgb(149, 165, 166), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(cardInput.Width - 530, 235), Size = new Size(120, 40), Cursor = Cursors.Hand, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            btnClearEmp.FlatAppearance.BorderSize = 0;

            Button btnShowAllEmp = new Button { Text = "عرض جميع الموظفين", Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(52, 152, 219),
ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(cardInput.Width - 690, 235), Size = new Size(150, 40), Cursor = Cursors.Hand, Anchor = AnchorStyles.Top | AnchorStyles.Right };
            btnShowAllEmp.FlatAppearance.BorderSize = 0;
            // ---- DataGridView ----
            DataGridView dgvEmp = new DataGridView { Location = new Point(20, 290), Size = new Size(760, 300), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom, ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, SelectionMode = DataGridViewSelectionMode.FullRowSelect, MultiSelect = false, RowHeadersVisible = false, BackgroundColor = Color.White, BorderStyle = BorderStyle.None, Font = new Font("Segoe UI", 10), EnableHeadersVisualStyles = false };
            dgvEmp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 43, 54);
            dgvEmp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmp.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEmp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

            pnlPageEmployees.Controls.AddRange(new Control[] { cardInput, btnAddEmp, btnUpdateEmp, btnDelEmp, btnClearEmp, btnShowAllEmp, dgvEmp });

            // Resize Logic
            pnlPageEmployees.Resize += (s, ev) => {
                int w = pnlPageEmployees.ClientSize.Width - 40;
                if (w < 200) return;
                cardInput.Width = w;
                dgvEmp.Width = w;
                lblTitle.Left = w - 160;
                lName.Left = w - 110; txtFullName.Left = w - 320;
                lUser.Left = w - 440; txtUsername.Left = w - 650;
                lPass.Left = w - 110; txtPassword.Left = w - 320;
                lRole.Left = w - 440; cmbRole.Left = w - 650;
                btnAddEmp.Left = w - 120; btnUpdateEmp.Left = w - 250; btnDelEmp.Left = w - 380; btnClearEmp.Left = w - 510; btnShowAllEmp.Left = w - 670;
            };

            int selectedEmpId = -1;

            Action loadEmps = () => {
                try {
                    using (SqlConnection conn = new SqlConnection(connectionString)) {
                        string q = "SELECT EmployeeID as [الرقم], FullName as [الاسم], Username as [اسم المستخدم], UserType as [الدور], Phone as [التليفون] FROM Employees";
                        SqlDataAdapter da = new SqlDataAdapter(q, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvEmp.DataSource = dt;
                    }
                } catch (Exception ex) { MessageBox.Show("خطأ في تحميل الموظفين: " + ex.Message); }
            };

            Action clearFields = () => { selectedEmpId = -1; txtFullName.Clear(); txtUsername.Clear(); txtPassword.Clear(); cmbRole.SelectedIndex = -1; };

            dgvEmp.SelectionChanged += (s, ev) => {
                try {
                    if (dgvEmp.CurrentRow != null && !dgvEmp.CurrentRow.IsNewRow && dgvEmp.CurrentRow.Cells["الرقم"].Value != DBNull.Value) {
                        selectedEmpId = Convert.ToInt32(dgvEmp.CurrentRow.Cells["الرقم"].Value);
                        txtFullName.Text = dgvEmp.CurrentRow.Cells["الاسم"].Value?.ToString();
                        txtUsername.Text = dgvEmp.CurrentRow.Cells["اسم المستخدم"].Value?.ToString();
                        cmbRole.Text = dgvEmp.CurrentRow.Cells["الدور"].Value?.ToString();
                        txtPassword.Text = "";
                    }
                } catch { }
            };

            btnAddEmp.Click += (s, ev) => {
                if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cmbRole.SelectedItem == null) { MessageBox.Show("الرجاء ملء كل البيانات!"); return; }
                try {
                    using (SqlConnection conn = new SqlConnection(connectionString)) {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Employees (FullName, Username, Password, UserType) VALUES (@f, @u, @p, @r)", conn)) {
                            cmd.Parameters.AddWithValue("@f", txtFullName.Text.Trim()); cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim()); cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim()); cmd.Parameters.AddWithValue("@r", cmbRole.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("تم الإضافة بنجاح!"); clearFields(); loadEmps();
                } catch (Exception ex) { MessageBox.Show("خطأ: " + ex.Message); }
            };

            btnUpdateEmp.Click += (s, ev) => {
                if (selectedEmpId == -1) { MessageBox.Show("اختر موظف أولاً"); return; }
                try {
                    using (SqlConnection conn = new SqlConnection(connectionString)) {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE Employees SET FullName=@f, Username=@u, Password=CASE WHEN @p='' THEN Password ELSE @p END, UserType=@r WHERE EmployeeID=@id", conn)) {
                            cmd.Parameters.AddWithValue("@f", txtFullName.Text.Trim()); cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim()); cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim()); cmd.Parameters.AddWithValue("@r", cmbRole.Text); cmd.Parameters.AddWithValue("@id", selectedEmpId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("تم التعديل بنجاح!"); clearFields(); loadEmps();
                } catch (Exception ex) { MessageBox.Show("خطأ: " + ex.Message); }
            };

            btnDelEmp.Click += (s, ev) => {
                if (selectedEmpId == -1) return;
                if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    try {
                        using (SqlConnection conn = new SqlConnection(connectionString)) {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@id", conn)) { cmd.Parameters.AddWithValue("@id", selectedEmpId); cmd.ExecuteNonQuery(); }
                        }
                        MessageBox.Show("تم الحذف بنجاح!"); clearFields(); loadEmps();
                    } catch (Exception ex) { MessageBox.Show("خطأ: " + ex.Message); }
                }
            };

            btnClearEmp.Click += (s, ev) => clearFields();
            btnShowAllEmp .Click += (s, ev) => loadEmps();


            btnNavEmployees.Click += (s, ev) =>
            {
                SwitchPage(pnlPageEmployees, btnNavEmployees);
                try {
                    // Create table just in case it doesn't exist
                    using (SqlConnection conn = new SqlConnection(connectionString)) {
                        conn.Open();
                        new SqlCommand(@"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employees' AND xtype='U')
                                         CREATE TABLE Employees (EmployeeID INT IDENTITY PRIMARY KEY, FullName NVARCHAR(200), Username NVARCHAR(100), Password NVARCHAR(255), UserType NVARCHAR(50), Phone NVARCHAR(20))", conn).ExecuteNonQuery();
                    }
                } catch { }
                loadEmps();
            };
        }

        private void BtnChangeAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "اختر صورة البروفايل";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string targetPath = System.IO.Path.Combine(Application.StartupPath, "avatar.png");
                        if (System.IO.File.Exists(targetPath))
                        {
                            System.IO.File.Delete(targetPath);
                        }
                        System.IO.File.Copy(ofd.FileName, targetPath, true);
                        
                        if (pbAvatar.Image != null) pbAvatar.Image.Dispose();
                        
                        using (var ms = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(targetPath)))
                        {
                            pbAvatar.Image = Image.FromStream(ms);
                        }
                        MessageBox.Show("تم تغيير الصورة بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء حفظ الصورة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SwitchPage(Panel page, Button navButton)
        {
            pnlPageDashboard.Visible = false;
            pnlPageRegister.Visible = false;
            pnlPagePatients.Visible = false;
            pnlPageSettings.Visible = false;

            // Hide dynamic panels inside pnlMain
            foreach (Control c in pnlMain.Controls)
            {
                if (c is Panel p && p != page && p.Name != "pnlPageDashboard" && p.Name != "pnlPageRegister" && p.Name != "pnlPagePatients" && p.Name != "pnlPageSettings")
                {
                    p.Visible = false;
                }
            }

            page.Visible = true;
            page.Dock = DockStyle.Fill;

            Color defaultColor = Color.FromArgb(33, 43, 54);
            btnNavDashboard.BackColor = defaultColor;
            btnNavRegister.BackColor = defaultColor;
            btnNavPatients.BackColor = defaultColor;
            btnNavSettings.BackColor = defaultColor;

            // Reset dynamic buttons inside pnlSidebar
            foreach (Control c in pnlSidebar.Controls)
            {
                if (c is Button b && (b.Name == "btnNavMedicalReports" || b.Name == "btnNavEmployees")) b.BackColor = defaultColor;
            }

            navButton.BackColor = Color.FromArgb(26, 188, 156);
            lblTitle.Text = navButton.Text.Replace("  ", "").Trim();

            if (page == pnlPageDashboard) LoadDashboardData();
            if (page == pnlPagePatients) LoadGridData();
        }

        private void btnNavDashboard_Click(object sender, EventArgs e) => SwitchPage(pnlPageDashboard, btnNavDashboard);
        private void btnNavRegister_Click(object sender, EventArgs e) => SwitchPage(pnlPageRegister, btnNavRegister);
        private void btnNavPatients_Click(object sender, EventArgs e) => SwitchPage(pnlPagePatients, btnNavPatients);
        private void btnNavSettings_Click(object sender, EventArgs e) => SwitchPage(pnlPageSettings, btnNavSettings);

        private void btnNavAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("النظام الطبي - لوحة تحكم قسم الاستقبال\nالإصدار 1.0\nتصميم بسيط وسهل الاستخدام.", "حول النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد بالتأكيد تسجيل الخروج؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new Login().Show();
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string queryBookings = "SELECT COUNT(*) FROM Bookings WHERE CAST(BookingDate AS DATE) = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(queryBookings, conn))
                    {
                        lblTodayBookings.Text = cmd.ExecuteScalar().ToString();
                    }

                    string queryPatients = "SELECT COUNT(*) FROM Patients";
                    using (SqlCommand cmd = new SqlCommand(queryPatients, conn))
                    {
                        lblTotalPatients.Text = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dashboard Load Error: " + ex.Message);
            }
        }

        private void LoadPatients()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT PatientID, FullName FROM Patients", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPatients.DisplayMember = "FullName";
                    cmbPatients.ValueMember = "PatientID";
                    cmbPatients.DataSource = dt;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("خطأ في تحميل المرضى: " + ex.Message); }
        }

        private void LoadExams()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ExamID, ExamName, Price FROM Examinations", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbExams.DisplayMember = "ExamName";
                    cmbExams.ValueMember = "ExamID";
                    cmbExams.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل الأشعات: " + ex.Message); }
        }

        private void LoadGridData(string searchKeyword = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
SELECT 
    p.PatientID as [رقم الملف], 
    p.FullName as [اسم المريض], 
    p.Phone as [رقم الهاتف],

    (
        SELECT TOP 1 e.ExamName 
        FROM Bookings b 
        JOIN Examinations e ON b.ExamID = e.ExamID 
        WHERE b.PatientID = p.PatientID 
        ORDER BY b.BookingDate DESC
    ) as [آخر أشعة],

    (
        SELECT TOP 1 mr.ScanType
        FROM MedicalReports mr
        WHERE mr.PatientName = p.FullName
        ORDER BY mr.ReportDate DESC
    ) as [تقرير الأشعة]

FROM Patients p";

                    if (!string.IsNullOrWhiteSpace(searchKeyword))
                    {
                        query += " WHERE p.FullName LIKE @search OR p.Phone LIKE @search OR CAST(p.PatientID AS NVARCHAR) = @exactSearch";
                    }

                    query += " ORDER BY p.PatientID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchKeyword))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + searchKeyword + "%");
                            cmd.Parameters.AddWithValue("@exactSearch", searchKeyword);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvData.DataSource = dt;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل جدول المرضى: " + ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGridData(txtSearch.Text);
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                int patientId = Convert.ToInt32(dgvData.SelectedRows[0].Cells["رقم الملف"].Value);
                string patientName = dgvData.SelectedRows[0].Cells["اسم المريض"].Value.ToString();

                txtName.Text = patientName;
                txtPhone.Text = dgvData.SelectedRows[0].Cells["رقم الهاتف"].Value.ToString();

                if (UserRole == "Doctor")
                    LoadPatientMedicalReports(patientName);
                else
                    LoadPatientHistory(patientId);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvData.Columns["DeleteColumn"].Index)
                {
                    if (MessageBox.Show("هل أنت متأكد من حذف هذا المريض؟ سيتم حذف جميع حجوزاته السابقة.", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int patientId = Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["رقم الملف"].Value);
                        try
                        {
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                conn.Open();
                                // Delete bookings first due to foreign key
                                using (SqlCommand cmdBookings = new SqlCommand("DELETE FROM Bookings WHERE PatientID = @pid", conn))
                                {
                                    cmdBookings.Parameters.AddWithValue("@pid", patientId);
                                    cmdBookings.ExecuteNonQuery();
                                }

                                using (SqlCommand cmdPatient = new SqlCommand("DELETE FROM Patients WHERE PatientID = @pid", conn))
                                {
                                    cmdPatient.Parameters.AddWithValue("@pid", patientId);
                                    cmdPatient.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("تم الحذف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGridData();
                            LoadPatients();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("خطأ في الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (dgvData.Columns[e.ColumnIndex].Name == "تقرير الأشعة")
                {
                    string patientName = dgvData.Rows[e.RowIndex].Cells["اسم المريض"].Value?.ToString();
                    string scanType = dgvData.Rows[e.RowIndex].Cells["تقرير الأشعة"].Value?.ToString();

                    if (!string.IsNullOrEmpty(patientName) && !string.IsNullOrEmpty(scanType))
                    {
                        ShowReportMessageBox(patientName);
                    }
                }
            }
        }

        private void ShowReportMessageBox(string patientName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT TOP 1 ReportDate, ScanType, DoctorName, Diagnosis, Notes
                                     FROM MedicalReports
                                     WHERE PatientName = @name
                                     ORDER BY ReportDate DESC, ReportID DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", patientName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string reportDate = Convert.ToDateTime(reader["ReportDate"]).ToString("yyyy/MM/dd");
                                string scanType = reader["ScanType"].ToString();
                                string doctorName = reader["DoctorName"].ToString();
                                string diagnosis = reader["Diagnosis"].ToString();
                                string notes = reader["Notes"].ToString();

                                string message = $"📋 تفاصيل التقرير الطبي\n\n" +
                                                 $"👤 اسم المريض: {patientName}\n" +
                                                 $"👨‍⚕️ الطبيب المعالج: {doctorName}\n" +
                                                 $"📅 تاريخ التقرير: {reportDate}\n" +
                                                 $"🔬 نوع الأشعة: {scanType}\n\n" +
                                                 $"📝 التشخيص:\n{diagnosis}\n\n" +
                                                 $"📌 ملاحظات:\n{notes}";

                                MessageBox.Show(message, "تقرير طبي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب التقرير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPatientHistory(int patientId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                        b.BookingDate as [تاريخ الفحص], 
                                        e.ExamName as [نوع الأشعة], 
                                        e.Price as [التكلفة] 
                                     FROM Bookings b 
                                     INNER JOIN Examinations e ON b.ExamID = e.ExamID 
                                     WHERE b.PatientID = @pid 
                                     ORDER BY b.BookingDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", patientId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistory.DataSource = dt;
                        lblHistoryTitle.Text = $"التاريخ الطبي ({dt.Rows.Count} فحوصات)";
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            txtName.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المريض", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Patients (FullName, Phone) VALUES (@Name, @Phone)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("تم تسجيل المريض بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(null, null);

                LoadPatients();
                LoadGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء اختيار مريض لتعديل بياناته.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المريض", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int patientId = Convert.ToInt32(dgvData.SelectedRows[0].Cells["رقم الملف"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Patients SET FullName = @Name, Phone = @Phone WHERE PatientID = @pid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@pid", patientId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("تم تحديث بيانات المريض بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPatients();
                LoadGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbPatients.SelectedValue == null || cmbExams.SelectedValue == null)
            {
                MessageBox.Show("الرجاء اختيار المريض ونوع الفحص", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Bookings (PatientID, ExamID, BookingDate) VALUES (@PID, @EID, @BDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PID", cmbPatients.SelectedValue);
                        cmd.Parameters.AddWithValue("@EID", cmbExams.SelectedValue);
                        cmd.Parameters.AddWithValue("@BDate", dtpBookingDate.Value);
                        cmd.ExecuteNonQuery();
                    }

                    DataRowView row = (DataRowView)cmbExams.SelectedItem;
                    currentInvoicePrice = Convert.ToDecimal(row["Price"]);
                    lblPrice.Text = "الإجمالي: " + currentInvoicePrice.ToString() + " ج.م";

                    MessageBox.Show("تم تأكيد الحجز بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dgvData.SelectedRows.Count > 0 && Convert.ToInt32(dgvData.SelectedRows[0].Cells["رقم الملف"].Value) == Convert.ToInt32(cmbPatients.SelectedValue))
                    {
                        LoadPatientHistory(Convert.ToInt32(cmbPatients.SelectedValue));
                    }

                    LoadDashboardData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (currentInvoicePrice == 0)
            {
                MessageBox.Show("يجب تأكيد الحجز أولاً لإصدار الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patientName = cmbPatients.Text;
            string examName = cmbExams.Text;

            MessageBox.Show($"=== الفاتورة ===\n\nاسم المريض: {patientName}\nنوع الفحص: {examName}\n\nالإجمالي المطلوب: {currentInvoicePrice} ج.م\n\nتم الإصدار بنجاح!", "طباعة الفاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            currentInvoicePrice = 0;
            lblPrice.Text = "الإجمالي: 0 ج.م";
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSettingName.Text)) return;

            string newName = txtSettingName.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE AppUsers SET FirstName = @name WHERE UserName = @user";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", newName);
                        cmd.Parameters.AddWithValue("@user", LoggedInUserName);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoggedInUserName = newName;
                lblUserName.Text = newName;
                MessageBox.Show("تم تحديث الاسم بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Fallback: update UI only
                lblUserName.Text = newName;
                MessageBox.Show("تم تحديث الاسم محلياً فقط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadPatientMedicalReports(string patientName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                        CONVERT(NVARCHAR, ReportDate, 103) as [تاريخ التقرير],
                                        ScanType                           as [نوع الأشعة],
                                        DoctorName                         as [الطبيب],
                                        Diagnosis                          as [التشخيص],
                                        Notes                              as [الملاحظات]
                                     FROM MedicalReports
                                     WHERE PatientName LIKE @name
                                     ORDER BY ReportID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + patientName + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHistory.DataSource = dt;
                        lblHistoryTitle.Text = $"📄 التقارير الطبية للمريض: {patientName} ({dt.Rows.Count} تقرير)";
                    }
                }
            }
            catch (Exception ex)
            {
                lblHistoryTitle.Text = "لا توجد تقارير";
            }
        }
    }
}
