using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // مكتبة الداتا بيز (مهمة جداً)

namespace WinForms_TEST
{
    public partial class Frm_MedicalReport : Form
    {
        // جملة الاتصال بتاعتك بالسيرفر وقاعدة البيانات بالمللي
        string connString = @"Server=YOUSEFEL-BASUON;Database=Taybah Center;Integrated Security=True;TrustServerCertificate=True;";

        public Frm_MedicalReport()
        {
            InitializeComponent();
        }

        // ==========================================
        // 1. كود زرار الحفظ
        // ==========================================
        private void btn_SaveReport_Click(object sender, EventArgs e)
        {
            // تأكد إن الخانات المهمة مش فاضية الأول
            if (string.IsNullOrWhiteSpace(txt_searchPatient.Text) || string.IsNullOrWhiteSpace(rtb_Diagnosis.Text))
            {
                MessageBox.Show("يا هندسة لازم تكتب اسم المريض والتشخيص على الأقل عشان نحفظ!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    // كود الـ Insert لجدول التقارير
                    string query = @"INSERT INTO MedicalReports 
                                   (PatientName, DoctorName, ScanType, ReportDate, Diagnosis, Notes) 
                                   VALUES 
                                   (@Patient, @Doctor, @Scan, @Date, @Diag, @Notes)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Patient", txt_searchPatient.Text.Trim());
                        cmd.Parameters.AddWithValue("@Doctor", txt_DoctorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Scan", cmb_ScanType.Text);
                        cmd.Parameters.AddWithValue("@Date", dtp_ReportDate.Value);
                        cmd.Parameters.AddWithValue("@Diag", rtb_Diagnosis.Text.Trim());
                        cmd.Parameters.AddWithValue("@Notes", rtb_Notes.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("عاش يا بشمهندس! تم حفظ التقرير في الداتا بيز بنجاح 🎉", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // نفضي الشاشة عشان التقرير اللي بعده
                    btn_Clear_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ في الاتصال بالداتا بيز: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 2. كود زرار التعديل
        // ==========================================
        private void btn_EditReport_Click(object sender, EventArgs e)
        {
            // في الطبيعي بنعدل بالـ ID، بس عشان الشاشة دي مفهاش ID، هنعدل بناءً على "اسم المريض"
            if (string.IsNullOrWhiteSpace(txt_searchPatient.Text))
            {
                MessageBox.Show("اكتب اسم المريض اللي عايز تعدل تقريره الأول!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    string query = @"UPDATE MedicalReports SET 
                                    DoctorName = @Doctor, 
                                    ScanType = @Scan, 
                                    ReportDate = @Date, 
                                    Diagnosis = @Diag, 
                                    Notes = @Notes 
                                    WHERE PatientName = @Patient";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Patient", txt_searchPatient.Text.Trim());
                        cmd.Parameters.AddWithValue("@Doctor", txt_DoctorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Scan", cmb_ScanType.Text);
                        cmd.Parameters.AddWithValue("@Date", dtp_ReportDate.Value);
                        cmd.Parameters.AddWithValue("@Diag", rtb_Diagnosis.Text.Trim());
                        cmd.Parameters.AddWithValue("@Notes", rtb_Notes.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("تم تعديل التقرير بنجاح يا ريس!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("مفيش تقرير مسجل باسم المريض ده عشان يتعدل!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التعديل: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 3. كود زرار المسح
        // ==========================================
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_searchPatient.Clear();
            txt_DoctorName.Clear();
            cmb_ScanType.SelectedIndex = -1;
            rtb_Diagnosis.Clear();
            rtb_Notes.Clear();
            dtp_ReportDate.Value = DateTime.Now;
        }
    }
}