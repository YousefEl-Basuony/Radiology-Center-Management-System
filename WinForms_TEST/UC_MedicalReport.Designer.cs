namespace WinForms_TEST
{
    partial class UC_MedicalReport
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.txt_searchPatient = new System.Windows.Forms.TextBox();
            this.lbl_SelectedPatientName = new System.Windows.Forms.Label();
            this.txt_DoctorName = new System.Windows.Forms.TextBox();
            this.cmb_ScanType = new System.Windows.Forms.ComboBox();
            this.rtb_Diagnosis = new System.Windows.Forms.RichTextBox();
            this.rtb_Notes = new System.Windows.Forms.RichTextBox();
            this.btn_SaveReport = new System.Windows.Forms.Button();
            this.btn_PrintReport = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txt_searchPatient
            // 
            this.txt_searchPatient.Location = new System.Drawing.Point(50, 30);
            this.txt_searchPatient.Name = "txt_searchPatient";
            this.txt_searchPatient.Size = new System.Drawing.Size(250, 20);
            this.txt_searchPatient.TabIndex = 0;
            this.txt_searchPatient.TextChanged += new System.EventHandler(this.txt_searchPatient_TextChanged);
            this.txt_searchPatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_searchPatient_KeyDown);
            // 
            // lbl_SelectedPatientName
            // 
            this.lbl_SelectedPatientName.Location = new System.Drawing.Point(50, 70);
            this.lbl_SelectedPatientName.Name = "lbl_SelectedPatientName";
            this.lbl_SelectedPatientName.Size = new System.Drawing.Size(250, 20);
            this.lbl_SelectedPatientName.TabIndex = 1;
            this.lbl_SelectedPatientName.Text = "لم يتم تحديد مريض";
            // 
            // txt_DoctorName
            // 
            this.txt_DoctorName.Location = new System.Drawing.Point(50, 110);
            this.txt_DoctorName.Name = "txt_DoctorName";
            this.txt_DoctorName.Size = new System.Drawing.Size(250, 20);
            this.txt_DoctorName.TabIndex = 2;
            this.txt_DoctorName.Text = "اسم الطبيب المعالج";
            // 
            // cmb_ScanType
            // 
            this.cmb_ScanType.Location = new System.Drawing.Point(50, 150);
            this.cmb_ScanType.Name = "cmb_ScanType";
            this.cmb_ScanType.Size = new System.Drawing.Size(250, 21);
            this.cmb_ScanType.TabIndex = 3;
            this.cmb_ScanType.Text = "نوع الأشعة";
            // 
            // rtb_Diagnosis
            // 
            this.rtb_Diagnosis.Location = new System.Drawing.Point(50, 190);
            this.rtb_Diagnosis.Name = "rtb_Diagnosis";
            this.rtb_Diagnosis.Size = new System.Drawing.Size(400, 100);
            this.rtb_Diagnosis.TabIndex = 4;
            this.rtb_Diagnosis.Text = "اكتب التشخيص هنا...";
            // 
            // rtb_Notes
            // 
            this.rtb_Notes.Location = new System.Drawing.Point(50, 310);
            this.rtb_Notes.Name = "rtb_Notes";
            this.rtb_Notes.Size = new System.Drawing.Size(400, 80);
            this.rtb_Notes.TabIndex = 5;
            this.rtb_Notes.Text = "اكتب الملاحظات الطبية هنا...";
            // 
            // btn_SaveReport
            // 
            this.btn_SaveReport.Location = new System.Drawing.Point(50, 410);
            this.btn_SaveReport.Name = "btn_SaveReport";
            this.btn_SaveReport.Size = new System.Drawing.Size(120, 40);
            this.btn_SaveReport.TabIndex = 6;
            this.btn_SaveReport.Text = "حفظ التقرير";
            this.btn_SaveReport.Click += new System.EventHandler(this.btn_SaveReport_Click);
            // 
            // btn_PrintReport
            // 
            this.btn_PrintReport.Location = new System.Drawing.Point(190, 410);
            this.btn_PrintReport.Name = "btn_PrintReport";
            this.btn_PrintReport.Size = new System.Drawing.Size(120, 40);
            this.btn_PrintReport.TabIndex = 7;
            this.btn_PrintReport.Text = "طباعة";
            this.btn_PrintReport.Click += new System.EventHandler(this.btn_PrintReport_Click);
            // 
            // UC_MedicalReport
            // 
            this.Controls.Add(this.btn_PrintReport);
            this.Controls.Add(this.btn_SaveReport);
            this.Controls.Add(this.rtb_Notes);
            this.Controls.Add(this.rtb_Diagnosis);
            this.Controls.Add(this.cmb_ScanType);
            this.Controls.Add(this.txt_DoctorName);
            this.Controls.Add(this.lbl_SelectedPatientName);
            this.Controls.Add(this.txt_searchPatient);
            this.Name = "UC_MedicalReport";
            this.Size = new System.Drawing.Size(800, 500);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_searchPatient;
        private System.Windows.Forms.Label lbl_SelectedPatientName;
        private System.Windows.Forms.TextBox txt_DoctorName;
        private System.Windows.Forms.ComboBox cmb_ScanType;
        private System.Windows.Forms.RichTextBox rtb_Diagnosis;
        private System.Windows.Forms.RichTextBox rtb_Notes;
        private System.Windows.Forms.Button btn_SaveReport;
        private System.Windows.Forms.Button btn_PrintReport;
    }
}