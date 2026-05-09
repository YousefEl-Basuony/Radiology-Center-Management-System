namespace WinForms_TEST
{
    partial class Frm_MedicalReport
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlTop = new Panel();
            btn_PrintReport = new Button();
            lblHeader = new Label();
            pnlMain = new Panel();
            btn_Clear = new Button();
            btn_EditReport = new Button();
            btn_SaveReport = new Button();
            rtb_Notes = new RichTextBox();
            lblNotes = new Label();
            rtb_Diagnosis = new RichTextBox();
            lblDiagnosis = new Label();
            lblSection2 = new Label();
            dtp_ReportDate = new DateTimePicker();
            lblDate = new Label();
            cmb_ScanType = new ComboBox();
            lblScanType = new Label();
            txt_DoctorName = new TextBox();
            lblDoctor = new Label();
            txt_searchPatient = new TextBox();
            lblPatientName = new Label();
            lblSection1 = new Label();
            pnlTop.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(btn_PrintReport);
            pnlTop.Controls.Add(lblHeader);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(4, 5, 4, 5);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1333, 108);
            pnlTop.TabIndex = 1;
            // 
            // btn_PrintReport
            // 
            btn_PrintReport.BackColor = Color.FromArgb(52, 152, 219);
            btn_PrintReport.FlatAppearance.BorderSize = 0;
            btn_PrintReport.FlatStyle = FlatStyle.Flat;
            btn_PrintReport.Font = new Font("Arial", 11F, FontStyle.Bold);
            btn_PrintReport.ForeColor = Color.White;
            btn_PrintReport.Location = new Point(53, 23);
            btn_PrintReport.Margin = new Padding(4, 5, 4, 5);
            btn_PrintReport.Name = "btn_PrintReport";
            btn_PrintReport.Size = new Size(187, 62);
            btn_PrintReport.TabIndex = 7;
            btn_PrintReport.Text = "🖨️ طباعة التقرير";
            btn_PrintReport.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(30, 43, 52);
            lblHeader.Location = new Point(1000, 31);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(221, 32);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "📝 قسم التقارير الطبية";
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.None;
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(btn_Clear);
            pnlMain.Controls.Add(btn_EditReport);
            pnlMain.Controls.Add(btn_SaveReport);
            pnlMain.Controls.Add(rtb_Notes);
            pnlMain.Controls.Add(lblNotes);
            pnlMain.Controls.Add(rtb_Diagnosis);
            pnlMain.Controls.Add(lblDiagnosis);
            pnlMain.Controls.Add(lblSection2);
            pnlMain.Controls.Add(dtp_ReportDate);
            pnlMain.Controls.Add(lblDate);
            pnlMain.Controls.Add(cmb_ScanType);
            pnlMain.Controls.Add(lblScanType);
            pnlMain.Controls.Add(txt_DoctorName);
            pnlMain.Controls.Add(lblDoctor);
            pnlMain.Controls.Add(txt_searchPatient);
            pnlMain.Controls.Add(lblPatientName);
            pnlMain.Controls.Add(lblSection1);
            pnlMain.Location = new Point(100, 154);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1133, 923);
            pnlMain.TabIndex = 0;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.FromArgb(224, 224, 224);
            btn_Clear.FlatAppearance.BorderSize = 0;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_Clear.ForeColor = Color.Black;
            btn_Clear.Location = new Point(293, 785);
            btn_Clear.Margin = new Padding(4, 5, 4, 5);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(200, 62);
            btn_Clear.TabIndex = 6;
            btn_Clear.Text = "مسح";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_EditReport
            // 
            btn_EditReport.BackColor = Color.FromArgb(241, 196, 15);
            btn_EditReport.FlatAppearance.BorderSize = 0;
            btn_EditReport.FlatStyle = FlatStyle.Flat;
            btn_EditReport.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_EditReport.ForeColor = Color.White;
            btn_EditReport.Location = new Point(507, 785);
            btn_EditReport.Margin = new Padding(4, 5, 4, 5);
            btn_EditReport.Name = "btn_EditReport";
            btn_EditReport.Size = new Size(200, 62);
            btn_EditReport.TabIndex = 5;
            btn_EditReport.Text = "تعديل";
            btn_EditReport.UseVisualStyleBackColor = false;
            btn_EditReport.Click += btn_EditReport_Click;
            // 
            // btn_SaveReport
            // 
            btn_SaveReport.BackColor = Color.FromArgb(52, 152, 219);
            btn_SaveReport.FlatAppearance.BorderSize = 0;
            btn_SaveReport.FlatStyle = FlatStyle.Flat;
            btn_SaveReport.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_SaveReport.ForeColor = Color.White;
            btn_SaveReport.Location = new Point(720, 785);
            btn_SaveReport.Margin = new Padding(4, 5, 4, 5);
            btn_SaveReport.Name = "btn_SaveReport";
            btn_SaveReport.Size = new Size(200, 62);
            btn_SaveReport.TabIndex = 4;
            btn_SaveReport.Text = "حفظ";
            btn_SaveReport.UseVisualStyleBackColor = false;
            btn_SaveReport.Click += btn_SaveReport_Click;
            // 
            // rtb_Notes
            // 
            rtb_Notes.BorderStyle = BorderStyle.FixedSingle;
            rtb_Notes.Font = new Font("Arial", 11F);
            rtb_Notes.Location = new Point(107, 615);
            rtb_Notes.Margin = new Padding(4, 5, 4, 5);
            rtb_Notes.Name = "rtb_Notes";
            rtb_Notes.Size = new Size(812, 106);
            rtb_Notes.TabIndex = 3;
            rtb_Notes.Text = "";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblNotes.Location = new Point(933, 615);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(71, 22);
            lblNotes.TabIndex = 2;
            lblNotes.Text = "ملاحظات:";
            // 
            // rtb_Diagnosis
            // 
            rtb_Diagnosis.BorderStyle = BorderStyle.FixedSingle;
            rtb_Diagnosis.Font = new Font("Arial", 11F);
            rtb_Diagnosis.Location = new Point(107, 385);
            rtb_Diagnosis.Margin = new Padding(4, 5, 4, 5);
            rtb_Diagnosis.Name = "rtb_Diagnosis";
            rtb_Diagnosis.Size = new Size(812, 167);
            rtb_Diagnosis.TabIndex = 3;
            rtb_Diagnosis.Text = "";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblDiagnosis.Location = new Point(933, 385);
            lblDiagnosis.Margin = new Padding(4, 0, 4, 0);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(77, 22);
            lblDiagnosis.TabIndex = 2;
            lblDiagnosis.Text = "التشخيص:";
            // 
            // lblSection2
            // 
            lblSection2.AutoSize = true;
            lblSection2.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblSection2.ForeColor = Color.Gray;
            lblSection2.Location = new Point(893, 308);
            lblSection2.Margin = new Padding(4, 0, 4, 0);
            lblSection2.Name = "lblSection2";
            lblSection2.Size = new Size(146, 24);
            lblSection2.TabIndex = 1;
            lblSection2.Text = "تفاصيل التقرير الطبي";
            // 
            // dtp_ReportDate
            // 
            dtp_ReportDate.Font = new Font("Arial", 11F);
            dtp_ReportDate.Format = DateTimePickerFormat.Short;
            dtp_ReportDate.Location = new Point(107, 195);
            dtp_ReportDate.Margin = new Padding(4, 5, 4, 5);
            dtp_ReportDate.Name = "dtp_ReportDate";
            dtp_ReportDate.Size = new Size(319, 29);
            dtp_ReportDate.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblDate.Location = new Point(440, 200);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(95, 22);
            lblDate.TabIndex = 3;
            lblDate.Text = "تاريخ التقرير:";
            // 
            // cmb_ScanType
            // 
            cmb_ScanType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ScanType.FlatStyle = FlatStyle.Flat;
            cmb_ScanType.Font = new Font("Arial", 11F);
            cmb_ScanType.FormattingEnabled = true;
            cmb_ScanType.Items.AddRange(new object[] { "أشعة سينية (X-Ray)", "رنين مغناطيسي (MRI)", "أشعة مقطعية (CT Scan)", "موجات فوق صوتية (Ultrasound)" });
            cmb_ScanType.Location = new Point(600, 195);
            cmb_ScanType.Margin = new Padding(4, 5, 4, 5);
            cmb_ScanType.Name = "cmb_ScanType";
            cmb_ScanType.Size = new Size(319, 29);
            cmb_ScanType.TabIndex = 2;
            // 
            // lblScanType
            // 
            lblScanType.AutoSize = true;
            lblScanType.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblScanType.Location = new Point(933, 200);
            lblScanType.Margin = new Padding(4, 0, 4, 0);
            lblScanType.Name = "lblScanType";
            lblScanType.Size = new Size(86, 22);
            lblScanType.TabIndex = 1;
            lblScanType.Text = "نوع الأشعة:";
            // 
            // txt_DoctorName
            // 
            txt_DoctorName.BorderStyle = BorderStyle.FixedSingle;
            txt_DoctorName.Font = new Font("Arial", 11F);
            txt_DoctorName.Location = new Point(107, 103);
            txt_DoctorName.Margin = new Padding(4, 5, 4, 5);
            txt_DoctorName.Name = "txt_DoctorName";
            txt_DoctorName.Size = new Size(319, 29);
            txt_DoctorName.TabIndex = 2;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblDoctor.Location = new Point(440, 108);
            lblDoctor.Margin = new Padding(4, 0, 4, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(104, 22);
            lblDoctor.TabIndex = 1;
            lblDoctor.Text = "الطبيب المعالج:";
            // 
            // txt_searchPatient
            // 
            txt_searchPatient.BorderStyle = BorderStyle.FixedSingle;
            txt_searchPatient.Font = new Font("Arial", 11F);
            txt_searchPatient.Location = new Point(600, 103);
            txt_searchPatient.Margin = new Padding(4, 5, 4, 5);
            txt_searchPatient.Name = "txt_searchPatient";
            txt_searchPatient.Size = new Size(319, 29);
            txt_searchPatient.TabIndex = 2;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Arial", 11F, FontStyle.Bold);
            lblPatientName.Location = new Point(933, 108);
            lblPatientName.Margin = new Padding(4, 0, 4, 0);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(94, 22);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "اسم المريض:";
            // 
            // lblSection1
            // 
            lblSection1.AutoSize = true;
            lblSection1.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblSection1.ForeColor = Color.Gray;
            lblSection1.Location = new Point(893, 31);
            lblSection1.Margin = new Padding(4, 0, 4, 0);
            lblSection1.Name = "lblSection1";
            lblSection1.Size = new Size(165, 24);
            lblSection1.TabIndex = 0;
            lblSection1.Text = "بيانات المريض والزيارة";
            // 
            // Frm_MedicalReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1333, 1055);
            Controls.Add(pnlMain);
            Controls.Add(pnlTop);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frm_MedicalReport";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نظام الأشعة - قسم التقارير الطبية";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btn_PrintReport;
        private System.Windows.Forms.Label lblSection1;
        private System.Windows.Forms.TextBox txt_searchPatient;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txt_DoctorName;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cmb_ScanType;
        private System.Windows.Forms.Label lblScanType;
        private System.Windows.Forms.DateTimePicker dtp_ReportDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSection2;
        private System.Windows.Forms.RichTextBox rtb_Diagnosis;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.RichTextBox rtb_Notes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btn_SaveReport;
        private System.Windows.Forms.Button btn_EditReport;
        private System.Windows.Forms.Button btn_Clear;
    }
}