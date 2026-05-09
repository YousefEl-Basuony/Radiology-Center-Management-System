namespace WinForms_TEST
{
    partial class ReceptionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            btnNavLogout = new Button();
            btnNavSettings = new Button();
            btnNavPatients = new Button();
            btnNavRegister = new Button();
            btnNavDashboard = new Button();
            pnlProfile = new Panel();
            lblUserRole = new Label();
            lblUserName = new Label();
            pbAvatar = new PictureBox();
            pnlHeader = new Panel();
            btnInvoice = new Button();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            lblTitle = new Label();
            lblPrice = new Label();
            pnlMain = new Panel();
            pnlPageRegister = new Panel();
            pnlHistoryCard = new Panel();
            dgvHistory = new DataGridView();
            lblHistoryTitle = new Label();
            pnlBookingCard = new Panel();
            dtpBookingDate = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            btnBook = new Button();
            cmbExams = new ComboBox();
            label4 = new Label();
            cmbPatients = new ComboBox();
            label3 = new Label();
            pnlRegisterCard = new Panel();
            btnClear = new Button();
            btnEditPatient = new Button();
            label7 = new Label();
            btnRegister = new Button();
            txtPhone = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            pnlPagePatients = new Panel();
            pnlGridCard = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            dgvData = new DataGridView();
            pnlPageSettings = new Panel();
            btnSaveSettings = new Button();
            txtSettingName = new TextBox();
            label9 = new Label();
            lblSettingsTitle = new Label();
            pnlPageDashboard = new Panel();
            lblTodayBookings = new Label();
            lblTodayBookingsTitle = new Label();
            lblTotalPatients = new Label();
            lblTotalPatientsTitle = new Label();
            lblDashTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlPageRegister.SuspendLayout();
            pnlHistoryCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlBookingCard.SuspendLayout();
            pnlRegisterCard.SuspendLayout();
            pnlPagePatients.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            pnlPageSettings.SuspendLayout();
            pnlPageDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(33, 43, 54);
            pnlSidebar.Controls.Add(btnNavLogout);
            pnlSidebar.Controls.Add(btnNavSettings);
            pnlSidebar.Controls.Add(btnNavPatients);
            pnlSidebar.Controls.Add(btnNavRegister);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(pnlProfile);
            pnlSidebar.Dock = DockStyle.Right;
            pnlSidebar.Location = new Point(850, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 750);
            pnlSidebar.TabIndex = 0;
            // 
            // btnNavLogout
            // 
            btnNavLogout.Cursor = Cursors.Hand;
            btnNavLogout.Dock = DockStyle.Bottom;
            btnNavLogout.FlatAppearance.BorderSize = 0;
            btnNavLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            btnNavLogout.FlatStyle = FlatStyle.Flat;
            btnNavLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNavLogout.ForeColor = Color.White;
            btnNavLogout.Location = new Point(0, 690);
            btnNavLogout.Name = "btnNavLogout";
            btnNavLogout.Size = new Size(250, 60);
            btnNavLogout.TabIndex = 8;
            btnNavLogout.Text = "  🚪 تسجيل خروج";
            btnNavLogout.TextAlign = ContentAlignment.MiddleRight;
            btnNavLogout.UseVisualStyleBackColor = true;
            btnNavLogout.Click += btnNavLogout_Click;
            // 
            // btnNavSettings
            // 
            btnNavSettings.Cursor = Cursors.Hand;
            btnNavSettings.Dock = DockStyle.Top;
            btnNavSettings.FlatAppearance.BorderSize = 0;
            btnNavSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            btnNavSettings.FlatStyle = FlatStyle.Flat;
            btnNavSettings.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNavSettings.ForeColor = Color.White;
            btnNavSettings.Location = new Point(0, 310);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Size = new Size(250, 60);
            btnNavSettings.TabIndex = 6;
            btnNavSettings.Text = "  ⚙️ الإعدادات";
            btnNavSettings.TextAlign = ContentAlignment.MiddleRight;
            btnNavSettings.UseVisualStyleBackColor = true;
            btnNavSettings.Click += btnNavSettings_Click;
            // 
            // btnNavPatients
            // 
            btnNavPatients.Cursor = Cursors.Hand;
            btnNavPatients.Dock = DockStyle.Top;
            btnNavPatients.FlatAppearance.BorderSize = 0;
            btnNavPatients.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            btnNavPatients.FlatStyle = FlatStyle.Flat;
            btnNavPatients.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNavPatients.ForeColor = Color.White;
            btnNavPatients.Location = new Point(0, 250);
            btnNavPatients.Name = "btnNavPatients";
            btnNavPatients.Size = new Size(250, 60);
            btnNavPatients.TabIndex = 5;
            btnNavPatients.Text = "  📋 قائمة المرضى";
            btnNavPatients.TextAlign = ContentAlignment.MiddleRight;
            btnNavPatients.UseVisualStyleBackColor = true;
            btnNavPatients.Click += btnNavPatients_Click;
            // 
            // btnNavRegister
            // 
            btnNavRegister.Cursor = Cursors.Hand;
            btnNavRegister.Dock = DockStyle.Top;
            btnNavRegister.FlatAppearance.BorderSize = 0;
            btnNavRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            btnNavRegister.FlatStyle = FlatStyle.Flat;
            btnNavRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNavRegister.ForeColor = Color.White;
            btnNavRegister.Location = new Point(0, 190);
            btnNavRegister.Name = "btnNavRegister";
            btnNavRegister.Size = new Size(250, 60);
            btnNavRegister.TabIndex = 4;
            btnNavRegister.Text = "  📝 تسجيل وحجز";
            btnNavRegister.TextAlign = ContentAlignment.MiddleRight;
            btnNavRegister.UseVisualStyleBackColor = true;
            btnNavRegister.Click += btnNavRegister_Click;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Cursor = Cursors.Hand;
            btnNavDashboard.Dock = DockStyle.Top;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNavDashboard.ForeColor = Color.White;
            btnNavDashboard.Location = new Point(0, 130);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(250, 60);
            btnNavDashboard.TabIndex = 3;
            btnNavDashboard.Text = "  📊 لوحة التحكم";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnNavDashboard.UseVisualStyleBackColor = true;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // pnlProfile
            // 
            pnlProfile.Controls.Add(lblUserRole);
            pnlProfile.Controls.Add(lblUserName);
            pnlProfile.Controls.Add(pbAvatar);
            pnlProfile.Dock = DockStyle.Top;
            pnlProfile.Location = new Point(0, 0);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(250, 130);
            pnlProfile.TabIndex = 1;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = false;
            lblUserRole.Font = new Font("Segoe UI", 9F);
            lblUserRole.ForeColor = Color.Silver;
            lblUserRole.Location = new Point(0, 105);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(250, 20);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "موظف استقبال";
            lblUserRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = false;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(0, 75);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(250, 28);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "يوسف البسيوني";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.White;
            pbAvatar.Location = new Point(100, 15);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(50, 50);
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(btnInvoice);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(btnMaximize);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblPrice);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(850, 80);
            pnlHeader.TabIndex = 1;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = Color.FromArgb(52, 152, 219);
            btnInvoice.Cursor = Cursors.Hand;
            btnInvoice.FlatAppearance.BorderSize = 0;
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInvoice.ForeColor = Color.White;
            btnInvoice.Location = new Point(243, 22);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(120, 40);
            btnInvoice.TabIndex = 3;
            btnInvoice.Text = "طباعة الفاتورة";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.DimGray;
            btnClose.Location = new Point(3, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMaximize.ForeColor = Color.DimGray;
            btnMaximize.Location = new Point(38, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(35, 35);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.DimGray;
            btnMinimize.Location = new Point(73, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 35);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "🗕";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 43, 54);
            lblTitle.Location = new Point(490, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "لوحة التحكم 📊";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Crimson;
            lblPrice.Location = new Point(23, 22);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(187, 37);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "الإجمالي: 0 ج.م";
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlPageRegister);
            pnlMain.Controls.Add(pnlPagePatients);
            pnlMain.Controls.Add(pnlPageSettings);
            pnlMain.Controls.Add(pnlPageDashboard);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 80);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20);
            pnlMain.Size = new Size(850, 670);
            pnlMain.TabIndex = 2;
            // 
            // pnlPageRegister
            // 
            pnlPageRegister.Controls.Add(pnlHistoryCard);
            pnlPageRegister.Controls.Add(pnlBookingCard);
            pnlPageRegister.Controls.Add(pnlRegisterCard);
            pnlPageRegister.Location = new Point(23, 23);
            pnlPageRegister.Name = "pnlPageRegister";
            pnlPageRegister.Size = new Size(800, 600);
            pnlPageRegister.TabIndex = 5;
            // 
            // pnlHistoryCard
            // 
            pnlHistoryCard.BackColor = Color.White;
            pnlHistoryCard.Controls.Add(dgvHistory);
            pnlHistoryCard.Controls.Add(lblHistoryTitle);
            pnlHistoryCard.Dock = DockStyle.Fill;
            pnlHistoryCard.Location = new Point(0, 300);
            pnlHistoryCard.Name = "pnlHistoryCard";
            pnlHistoryCard.Padding = new Padding(20, 60, 20, 20);
            pnlHistoryCard.Size = new Size(800, 300);
            pnlHistoryCard.TabIndex = 6;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(243, 156, 18);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(243, 156, 18);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvHistory.ColumnHeadersHeight = 45;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle8;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.GridColor = Color.FromArgb(238, 238, 238);
            dgvHistory.Location = new Point(20, 60);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 40;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(760, 220);
            dgvHistory.TabIndex = 4;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(211, 84, 0);
            lblHistoryTitle.Location = new Point(600, 15);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(158, 28);
            lblHistoryTitle.TabIndex = 6;
            lblHistoryTitle.Text = "التاريخ الطبي 📈";
            // 
            // pnlBookingCard
            // 
            pnlBookingCard.BackColor = Color.White;
            pnlBookingCard.Controls.Add(dtpBookingDate);
            pnlBookingCard.Controls.Add(label8);
            pnlBookingCard.Controls.Add(label5);
            pnlBookingCard.Controls.Add(btnBook);
            pnlBookingCard.Controls.Add(cmbExams);
            pnlBookingCard.Controls.Add(label4);
            pnlBookingCard.Controls.Add(cmbPatients);
            pnlBookingCard.Controls.Add(label3);
            pnlBookingCard.Dock = DockStyle.Top;
            pnlBookingCard.Location = new Point(0, 150);
            pnlBookingCard.Name = "pnlBookingCard";
            pnlBookingCard.Size = new Size(800, 150);
            pnlBookingCard.TabIndex = 4;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpBookingDate.Font = new Font("Segoe UI", 12F);
            dtpBookingDate.Format = DateTimePickerFormat.Short;
            dtpBookingDate.Location = new Point(20, 55);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new Size(160, 34);
            dtpBookingDate.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(180, 62);
            label8.Name = "label8";
            label8.Size = new Size(48, 23);
            label8.TabIndex = 6;
            label8.Text = "تاريخ:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(100, 110, 120);
            label5.Location = new Point(600, 15);
            label5.Name = "label5";
            label5.Size = new Size(173, 28);
            label5.TabIndex = 5;
            label5.Text = "تحديد وحجز الفحص";
            // 
            // btnBook
            // 
            btnBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBook.BackColor = Color.FromArgb(26, 188, 156);
            btnBook.Cursor = Cursors.Hand;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(20, 95);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(160, 45);
            btnBook.TabIndex = 4;
            btnBook.Text = "تأكيد الحجز ✔";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // cmbExams
            // 
            cmbExams.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbExams.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExams.Font = new Font("Segoe UI", 12F);
            cmbExams.FormattingEnabled = true;
            cmbExams.Location = new Point(234, 55);
            cmbExams.Name = "cmbExams";
            cmbExams.Size = new Size(196, 36);
            cmbExams.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(440, 62);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 2;
            label4.Text = "نوع الأشعة:";
            // 
            // cmbPatients
            // 
            cmbPatients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPatients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatients.Font = new Font("Segoe UI", 12F);
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(540, 55);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(180, 36);
            cmbPatients.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(730, 62);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 0;
            label3.Text = "المريض:";
            // 
            // pnlRegisterCard
            // 
            pnlRegisterCard.BackColor = Color.White;
            pnlRegisterCard.Controls.Add(btnClear);
            pnlRegisterCard.Controls.Add(btnEditPatient);
            pnlRegisterCard.Controls.Add(label7);
            pnlRegisterCard.Controls.Add(btnRegister);
            pnlRegisterCard.Controls.Add(txtPhone);
            pnlRegisterCard.Controls.Add(label2);
            pnlRegisterCard.Controls.Add(txtName);
            pnlRegisterCard.Controls.Add(label1);
            pnlRegisterCard.Dock = DockStyle.Top;
            pnlRegisterCard.Location = new Point(0, 0);
            pnlRegisterCard.Name = "pnlRegisterCard";
            pnlRegisterCard.Size = new Size(800, 150);
            pnlRegisterCard.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(236, 240, 241);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(20, 56);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(70, 45);
            btnClear.TabIndex = 8;
            btnClear.Text = "مسح ↺";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEditPatient
            // 
            btnEditPatient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditPatient.BackColor = Color.FromArgb(241, 196, 15);
            btnEditPatient.Cursor = Cursors.Hand;
            btnEditPatient.FlatAppearance.BorderSize = 0;
            btnEditPatient.FlatStyle = FlatStyle.Flat;
            btnEditPatient.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditPatient.ForeColor = Color.White;
            btnEditPatient.Location = new Point(100, 56);
            btnEditPatient.Name = "btnEditPatient";
            btnEditPatient.Size = new Size(80, 45);
            btnEditPatient.TabIndex = 7;
            btnEditPatient.Text = "تعديل ✎";
            btnEditPatient.UseVisualStyleBackColor = false;
            btnEditPatient.Click += btnEditPatient_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(100, 110, 120);
            label7.Location = new Point(600, 15);
            label7.Name = "label7";
            label7.Size = new Size(197, 28);
            label7.TabIndex = 6;
            label7.Text = "تسجيل بيانات المريض";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.BackColor = Color.FromArgb(52, 152, 219);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(190, 56);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(80, 45);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "تسجيل ✚";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(285, 62);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "أدخل رقم الهاتف";
            txtPhone.Size = new Size(175, 34);
            txtPhone.TabIndex = 3;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(460, 68);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 2;
            label2.Text = "رقم الهاتف:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(560, 62);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "أدخل اسم المريض";
            txtName.Size = new Size(160, 34);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(730, 68);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 0;
            label1.Text = "الاسم:";
            // 
            // pnlPagePatients
            // 
            pnlPagePatients.Controls.Add(pnlGridCard);
            pnlPagePatients.Location = new Point(23, 23);
            pnlPagePatients.Name = "pnlPagePatients";
            pnlPagePatients.Size = new Size(800, 600);
            pnlPagePatients.TabIndex = 4;
            // 
            // pnlGridCard
            // 
            pnlGridCard.BackColor = Color.White;
            pnlGridCard.Controls.Add(btnSearch);
            pnlGridCard.Controls.Add(txtSearch);
            pnlGridCard.Controls.Add(label6);
            pnlGridCard.Controls.Add(dgvData);
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Location = new Point(0, 0);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(20, 70, 20, 20);
            pnlGridCard.Size = new Size(800, 600);
            pnlGridCard.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(236, 240, 241);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(20, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(90, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "بحث برقم أو اسم المريض...";
            txtSearch.Size = new Size(250, 34);
            txtSearch.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(100, 110, 120);
            label6.Location = new Point(620, 20);
            label6.Name = "label6";
            label6.Size = new Size(147, 32);
            label6.TabIndex = 5;
            label6.Text = "قائمة المرضى";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(248, 250, 252);
            dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.BackgroundColor = Color.White;
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(233, 236, 239);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvData.ColumnHeadersHeight = 50;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvData.DefaultCellStyle = dataGridViewCellStyle12;
            dgvData.Dock = DockStyle.Fill;
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.GridColor = Color.FromArgb(238, 238, 238);
            dgvData.Location = new Point(20, 70);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersVisible = false;
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 45;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(760, 510);
            dgvData.TabIndex = 3;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.SelectionChanged += dgvData_SelectionChanged;
            // 
            // pnlPageSettings
            // 
            pnlPageSettings.BackColor = Color.FromArgb(245, 247, 250);
            pnlPageSettings.Controls.Add(btnSaveSettings);
            pnlPageSettings.Controls.Add(txtSettingName);
            pnlPageSettings.Controls.Add(label9);
            pnlPageSettings.Controls.Add(lblSettingsTitle);
            pnlPageSettings.Location = new Point(23, 23);
            pnlPageSettings.Name = "pnlPageSettings";
            pnlPageSettings.Size = new Size(800, 600);
            pnlPageSettings.TabIndex = 6;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveSettings.BackColor = Color.FromArgb(26, 188, 156);
            btnSaveSettings.Cursor = Cursors.Hand;
            btnSaveSettings.FlatAppearance.BorderSize = 0;
            btnSaveSettings.FlatStyle = FlatStyle.Flat;
            btnSaveSettings.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSaveSettings.ForeColor = Color.White;
            btnSaveSettings.Location = new Point(550, 165);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(130, 42);
            btnSaveSettings.TabIndex = 3;
            btnSaveSettings.Text = "حفظ ✔";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // txtSettingName
            // 
            txtSettingName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSettingName.BorderStyle = BorderStyle.FixedSingle;
            txtSettingName.Font = new Font("Segoe UI", 13F);
            txtSettingName.Location = new Point(350, 165);
            txtSettingName.Name = "txtSettingName";
            txtSettingName.Size = new Size(190, 36);
            txtSettingName.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(80, 80, 80);
            label9.Location = new Point(550, 130);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 1;
            label9.Text = "الاسم الجديد";
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSettingsTitle.AutoSize = true;
            lblSettingsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSettingsTitle.ForeColor = Color.FromArgb(33, 43, 54);
            lblSettingsTitle.Location = new Point(550, 60);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(168, 37);
            lblSettingsTitle.TabIndex = 0;
            lblSettingsTitle.Text = "⚙️ الإعدادات";
            // 
            // pnlPageDashboard
            // 
            pnlPageDashboard.Controls.Add(lblTodayBookings);
            pnlPageDashboard.Controls.Add(lblTodayBookingsTitle);
            pnlPageDashboard.Controls.Add(lblTotalPatients);
            pnlPageDashboard.Controls.Add(lblTotalPatientsTitle);
            pnlPageDashboard.Controls.Add(lblDashTitle);
            pnlPageDashboard.Location = new Point(23, 23);
            pnlPageDashboard.Name = "pnlPageDashboard";
            pnlPageDashboard.Size = new Size(800, 600);
            pnlPageDashboard.TabIndex = 3;
            // 
            // lblTodayBookings
            // 
            lblTodayBookings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTodayBookings.AutoSize = true;
            lblTodayBookings.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTodayBookings.ForeColor = Color.FromArgb(26, 188, 156);
            lblTodayBookings.Location = new Point(100, 150);
            lblTodayBookings.Name = "lblTodayBookings";
            lblTodayBookings.Size = new Size(70, 81);
            lblTodayBookings.TabIndex = 4;
            lblTodayBookings.Text = "0";
            // 
            // lblTodayBookingsTitle
            // 
            lblTodayBookingsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTodayBookingsTitle.AutoSize = true;
            lblTodayBookingsTitle.Font = new Font("Segoe UI", 16F);
            lblTodayBookingsTitle.ForeColor = Color.DimGray;
            lblTodayBookingsTitle.Location = new Point(80, 100);
            lblTodayBookingsTitle.Name = "lblTodayBookingsTitle";
            lblTodayBookingsTitle.Size = new Size(210, 37);
            lblTodayBookingsTitle.TabIndex = 3;
            lblTodayBookingsTitle.Text = "حجوزات اليوم 📅";
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPatients.AutoSize = true;
            lblTotalPatients.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalPatients.ForeColor = Color.FromArgb(52, 152, 219);
            lblTotalPatients.Location = new Point(500, 150);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(70, 81);
            lblTotalPatients.TabIndex = 2;
            lblTotalPatients.Text = "0";
            // 
            // lblTotalPatientsTitle
            // 
            lblTotalPatientsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPatientsTitle.AutoSize = true;
            lblTotalPatientsTitle.Font = new Font("Segoe UI", 16F);
            lblTotalPatientsTitle.ForeColor = Color.DimGray;
            lblTotalPatientsTitle.Location = new Point(450, 100);
            lblTotalPatientsTitle.Name = "lblTotalPatientsTitle";
            lblTotalPatientsTitle.Size = new Size(230, 37);
            lblTotalPatientsTitle.TabIndex = 1;
            lblTotalPatientsTitle.Text = "إجمالي المرضى 👥";
            // 
            // lblDashTitle
            // 
            lblDashTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDashTitle.AutoSize = true;
            lblDashTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblDashTitle.ForeColor = Color.FromArgb(33, 43, 54);
            lblDashTitle.Location = new Point(600, 20);
            lblDashTitle.Name = "lblDashTitle";
            lblDashTitle.Size = new Size(145, 41);
            lblDashTitle.TabIndex = 0;
            lblDashTitle.Text = "نظرة عامة";
            // 
            // ReceptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1100, 750);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReceptionForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لوحة الاستقبال";
            Load += ReceptionForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlPageRegister.ResumeLayout(false);
            pnlHistoryCard.ResumeLayout(false);
            pnlHistoryCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlBookingCard.ResumeLayout(false);
            pnlBookingCard.PerformLayout();
            pnlRegisterCard.ResumeLayout(false);
            pnlRegisterCard.PerformLayout();
            pnlPagePatients.ResumeLayout(false);
            pnlGridCard.ResumeLayout(false);
            pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            pnlPageSettings.ResumeLayout(false);
            pnlPageSettings.PerformLayout();
            pnlPageDashboard.ResumeLayout(false);
            pnlPageDashboard.PerformLayout();
            ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavRegister;
        private System.Windows.Forms.Button btnNavPatients;
        private System.Windows.Forms.Button btnNavSettings;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Panel pnlMain;
        
        // Pages
        private System.Windows.Forms.Panel pnlPageDashboard;
        private System.Windows.Forms.Label lblDashTitle;
        private System.Windows.Forms.Label lblTotalPatientsTitle;
        private System.Windows.Forms.Label lblTotalPatients;
        private System.Windows.Forms.Label lblTodayBookingsTitle;
        private System.Windows.Forms.Label lblTodayBookings;
        
        private System.Windows.Forms.Panel pnlPageRegister;
        private System.Windows.Forms.Panel pnlRegisterCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlBookingCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPatients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbExams;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel pnlHistoryCard;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.DataGridView dgvHistory;
        
        private System.Windows.Forms.Panel pnlPagePatients;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvData;
        
        private System.Windows.Forms.Panel pnlPageSettings;
        private System.Windows.Forms.Label lblSettingsTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSettingName;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}
