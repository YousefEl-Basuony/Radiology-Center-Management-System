using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace WinForms_TEST
{
    public partial class UC_MedicalReport : UserControl
    {
        // ── الكلاس الخاص ببيانات المريض (بدل المنتجات في الكاشير) ──
        private class PatientItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
        }

        private List<PatientItem> _allPatients = new List<PatientItem>();
        private List<Panel> _dropdownCards = new List<Panel>();
        private int _selectedIndex = -1;

        // المتغيرات اللي هتشيل بيانات المريض اللي تم اختياره للتقرير
        private int _selectedPatientId = 0;
        private string _selectedPatientName = "";

        // جملة الاتصال (عدلها باسم قاعدة بيانات مركز الأشعة بتاعتك)
        private string _connString = @"Server=.\SQLEXPRESS;Database=Radiology_DB;Integrated Security=True;TrustServerCertificate=True;";

        // ── أدوات القائمة المنسدلة (Dynamic) للبحث عن مريض ──
        private Panel pnl_dropdown;
        private FlowLayoutPanel flp_dropdown_cards;
        private Panel pnl_shortcuts;

        // ✨ السر العظيم لمنع رعشة الشاشة (Flickering) - عاش يا هندسة ✨
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public UC_MedicalReport()
        {
            InitializeComponent();
            BuildDropdownUI();
            LoadAllPatients(); // تحميل أسماء المرضى عشان البحث السريع
        }

        // ==========================================
        // 1. بناء قائمة البحث المنسدلة (للمرضى)
        // ==========================================
        private void BuildDropdownUI()
        {
            if (txt_searchPatient == null) return; // تأكد إنك مسمي مربع البحث txt_searchPatient

            pnl_dropdown = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Visible = false,
                Size = new Size(txt_searchPatient.Width, 0),
                TabIndex = 99
            };

            pnl_dropdown.Paint += (s, e) => {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var pen = new Pen(Color.FromArgb(180, 200, 230), 1.5f))
                {
                    var rect = new RectangleF(0.5f, 0.5f, pnl_dropdown.Width - 1, pnl_dropdown.Height - 1);
                    using (var path = RoundedRect(rect, 10)) e.Graphics.DrawPath(pen, path);
                }
            };

            flp_dropdown_cards = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                WrapContents = false,
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                Padding = new Padding(6, 6, 6, 0),
                RightToLeft = RightToLeft.Yes
            };

            pnl_shortcuts = new Panel { Dock = DockStyle.Bottom, Height = 30, BackColor = Color.FromArgb(245, 246, 250) };
            var lblShortcuts = new Label { Text = "↑↓ تنقل   |   Enter اختيار   |   Esc إغلاق", Font = new Font("Cairo", 7.5f), ForeColor = Color.FromArgb(130, 130, 150), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
            pnl_shortcuts.Controls.Add(lblShortcuts);

            pnl_dropdown.Controls.Add(flp_dropdown_cards);
            pnl_dropdown.Controls.Add(pnl_shortcuts);

            if (txt_searchPatient.Parent != null)
            {
                txt_searchPatient.Parent.Controls.Add(pnl_dropdown);
                pnl_dropdown.BringToFront();
            }
        }

        // ==========================================
        // 2. تحميل البيانات والرسم 
        // ==========================================
        private void LoadAllPatients()
        {
            _allPatients.Clear();
            try
            {
                using (var conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    // بنجيب بيانات المرضى من الداتابيز
                    using (var cmd = new SqlCommand("SELECT Id, Name, Phone FROM Patients", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _allPatients.Add(new PatientItem
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString(),
                                Phone = reader["Phone"]?.ToString() ?? ""
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في تحميل المرضى: " + ex.Message); }
        }

        private void RenderDropdownCards(List<PatientItem> patients)
        {
            if (flp_dropdown_cards == null) return;
            flp_dropdown_cards.Controls.Clear(); _dropdownCards.Clear();
            foreach (var p in patients)
            {
                var card = CreateDropdownCard(p);
                flp_dropdown_cards.Controls.Add(card); _dropdownCards.Add(card);
            }
        }

        private Panel CreateDropdownCard(PatientItem p)
        {
            int cardW = flp_dropdown_cards.Width - 20;
            var card = new Panel { Tag = p, Cursor = Cursors.Hand, BackColor = Color.White, Margin = new Padding(2), Size = new Size(cardW, 62) };

            var lblN = new Label { Text = p.Name, Font = new Font("Cairo", 10.5f, FontStyle.Bold), Location = new Point(cardW - 200, 8), Size = new Size(190, 26), RightToLeft = RightToLeft.Yes, TextAlign = ContentAlignment.MiddleRight };
            var lblPhone = new Label { Text = p.Phone, Font = new Font("Cairo", 9f), ForeColor = Color.Gray, Location = new Point(8, 12), Size = new Size(120, 38), TextAlign = ContentAlignment.MiddleLeft };

            card.Controls.Add(lblN); card.Controls.Add(lblPhone);

            // لما نضغط على المريض، نختاره للتقرير
            Action selectPatient = () => { SelectPatientForReport(p); HideDropdown(); txt_searchPatient.Clear(); };
            card.Click += (s, e) => selectPatient();
            lblN.Click += (s, e) => selectPatient();
            lblPhone.Click += (s, e) => selectPatient();
            return card;
        }

        private void SelectPatientForReport(PatientItem p)
        {
            _selectedPatientId = p.Id;
            _selectedPatientName = p.Name;

            // افترض إن عندك Label أو TextBox بيعرض اسم المريض المختار
            if (lbl_SelectedPatientName != null)
                lbl_SelectedPatientName.Text = p.Name;

            MessageBox.Show($"تم اختيار المريض: {p.Name} للتقرير.", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // 3. أحداث البحث والتحكم بالكيبورد
        // ==========================================
        private void txt_searchPatient_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchPatient == null) return;
            string kw = txt_searchPatient.Text.Trim();
            if (string.IsNullOrEmpty(kw)) { HideDropdown(); return; }

            var filtered = _allPatients.FindAll(p => p.Name.IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0 || p.Phone.Contains(kw));

            if (filtered.Count == 0) { HideDropdown(); return; }

            RenderDropdownCards(filtered);
            pnl_dropdown.Location = new Point(txt_searchPatient.Left, txt_searchPatient.Bottom + 2);
            pnl_dropdown.Size = new Size(txt_searchPatient.Width, Math.Min(filtered.Count * 66, 280) + 38);
            pnl_dropdown.Visible = true;
            pnl_dropdown.BringToFront();
            SetSelectedCard(0);
        }

        private void txt_searchPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (pnl_dropdown != null && pnl_dropdown.Visible && _selectedIndex >= 0 && _selectedIndex < _dropdownCards.Count)
                {
                    var p = _dropdownCards[_selectedIndex].Tag as PatientItem;
                    if (p != null) { SelectPatientForReport(p); HideDropdown(); txt_searchPatient.Clear(); }
                }
                return;
            }

            if (pnl_dropdown == null || !pnl_dropdown.Visible) return;
            if (e.KeyCode == Keys.Down) { e.SuppressKeyPress = true; SetSelectedCard(_selectedIndex + 1); }
            else if (e.KeyCode == Keys.Up) { e.SuppressKeyPress = true; SetSelectedCard(_selectedIndex - 1); }
            else if (e.KeyCode == Keys.Escape) { HideDropdown(); txt_searchPatient.Clear(); }
        }

        private void SetSelectedCard(int idx)
        {
            if (_dropdownCards.Count == 0) return;
            idx = Math.Max(0, Math.Min(idx, _dropdownCards.Count - 1));
            if (_selectedIndex >= 0 && _selectedIndex < _dropdownCards.Count) SetCardHighlight(_dropdownCards[_selectedIndex], false);
            _selectedIndex = idx;
            SetCardHighlight(_dropdownCards[idx], true);
            flp_dropdown_cards.ScrollControlIntoView(_dropdownCards[_selectedIndex]);
        }

        private void SetCardHighlight(Panel c, bool s) { c.BackColor = s ? Color.FromArgb(214, 234, 248) : Color.White; foreach (Control ctrl in c.Controls) ctrl.BackColor = c.BackColor; }
        private void HideDropdown() { if (pnl_dropdown != null) pnl_dropdown.Visible = false; _selectedIndex = -1; }

        // ==========================================
        // 4. دوال مساعدة للرسم
        // ==========================================
        private GraphicsPath RoundedRect(RectangleF b, float r)
        {
            GraphicsPath p = new GraphicsPath(); float d = r * 2;
            p.AddArc(b.X, b.Y, d, d, 180, 90); p.AddArc(b.Right - d, b.Y, d, d, 270, 90);
            p.AddArc(b.Right - d, b.Bottom - d, d, d, 0, 90); p.AddArc(b.X, b.Bottom - d, d, d, 90, 90);
            return p;
        }

        // ==========================================
        // 5. زر الحفظ (أهم جزء للتقرير الطبي)
        // ==========================================
        private void btn_SaveReport_Click(object sender, EventArgs e)
        {
            // 1. التحقق من إدخال البيانات الأساسية
            if (_selectedPatientId == 0)
            {
                MessageBox.Show("يا هندسة لازم تختار مريض الأول!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(rtb_Diagnosis.Text))
            {
                MessageBox.Show("مينفعش التقرير يكون من غير تشخيص!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(_connString))
                {
                    con.Open();

                    // هنا معندناش تفاصيل فاتورة ومخزن، هو Insert واحد بس في جدول التقارير
                    string insertReport = @"
                        INSERT INTO MedicalReports 
                        (PatientId, DoctorName, ScanType, Diagnosis, Notes, ReportDate) 
                        VALUES 
                        (@pId, @docName, @scanType, @diagnosis, @notes, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertReport, con))
                    {
                        cmd.Parameters.AddWithValue("@pId", _selectedPatientId);
                        cmd.Parameters.AddWithValue("@docName", txt_DoctorName.Text.Trim()); // اسم الطبيب
                        cmd.Parameters.AddWithValue("@scanType", cmb_ScanType.Text); // نوع الأشعة
                        cmd.Parameters.AddWithValue("@diagnosis", rtb_Diagnosis.Text.Trim()); // التشخيص
                        cmd.Parameters.AddWithValue("@notes", rtb_Notes.Text.Trim()); // الملاحظات
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("تم حفظ التقرير الطبي بنجاح! 🎉\nوتقدر تطبعه دلوقتي.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تفعيل زرار الطباعة (لو كنت عامله Disabled)
                    if (btn_PrintReport != null) btn_PrintReport.Enabled = true;

                    // تصفير الشاشة للمريض اللي بعده
                    ClearScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ أثناء الحفظ في الداتابيز: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearScreen()
        {
            _selectedPatientId = 0;
            _selectedPatientName = "";
            if (lbl_SelectedPatientName != null) lbl_SelectedPatientName.Text = "لم يتم تحديد مريض";
            if (txt_DoctorName != null) txt_DoctorName.Clear();
            if (cmb_ScanType != null) cmb_ScanType.SelectedIndex = -1;
            if (rtb_Diagnosis != null) rtb_Diagnosis.Clear();
            if (rtb_Notes != null) rtb_Notes.Clear();
            if (txt_searchPatient != null) txt_searchPatient.Clear();
        }

        // زر الطباعة (بتحط جواه كود الطباعة بتاعك)
        private void btn_PrintReport_Click(object sender, EventArgs e)
        {
            // ضيف كود الـ PrintDocument أو Crystal Reports هنا
            MessageBox.Show("جاري تجهيز الطباعة...", "طباعة");
        }
    }
}