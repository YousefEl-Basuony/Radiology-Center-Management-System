using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinForms_TEST
{
    public partial class EmployeeManagement : Form
    {
        private string connStr = @"Data Source=YOUSEFEL-BASUON;Initial Catalog=Taybah Center;Integrated Security=True;TrustServerCertificate=True;";
        private int selectedEmployeeID = -1;
        private string userType;

        public EmployeeManagement(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            // Ensure the Employees table exists before querying it
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    new SqlCommand(@"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employees' AND xtype='U')
                        CREATE TABLE Employees (
                            EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
                            FullName   NVARCHAR(200),
                            Username   NVARCHAR(100),
                            Password   NVARCHAR(255),
                            UserType   NVARCHAR(50),
                            Phone      NVARCHAR(20)
                        )", conn).ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في إنشاء جدول الموظفين:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Only Doctor and Admin can add/edit/delete employees
            if (userType != "Doctor" && userType != "Admin")
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnClear.Visible = false;
            }
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT EmployeeID, FullName, Username, UserType, Phone FROM Employees";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmployees.DataSource = dt;

                    dgvEmployees.Columns["EmployeeID"].HeaderText = "الرقم";
                    dgvEmployees.Columns["FullName"].HeaderText = "الاسم";
                    dgvEmployees.Columns["Username"].HeaderText = "اسم المستخدم";
                    dgvEmployees.Columns["UserType"].HeaderText = "النوع";
                    dgvEmployees.Columns["Phone"].HeaderText = "التليفون";
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ:\n" + ex.Message); }
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null || dgvEmployees.CurrentRow.IsNewRow) return;
            try
            {
                DataGridViewRow row = dgvEmployees.CurrentRow;
                if (row.Cells["EmployeeID"].Value != null && row.Cells["EmployeeID"].Value != DBNull.Value)
                {
                    selectedEmployeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                    txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                    txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
                    txtPassword.Text = "";
                    cmbUserType.Text = row.Cells["UserType"].Value?.ToString() ?? "";
                    txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                }
            }
            catch { /* Ignore selection errors if any */ }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO Employees (FullName, Username, Password, UserType, Phone) VALUES (@FullName, @Username, @Password, @UserType, @Phone)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("تم الاضافة بنجاح");
                ClearFields();
                LoadEmployees();
            }
            catch (Exception ex) { MessageBox.Show("خطأ:\n" + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == -1) { MessageBox.Show("اختار موظف اولا"); return; }
            if (!ValidateInputs()) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "UPDATE Employees SET FullName=@FullName, Username=@Username, Password=@Password, UserType=@UserType, Phone=@Phone WHERE EmployeeID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@ID", selectedEmployeeID);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("تم التعديل بنجاح");
                ClearFields();
                LoadEmployees();
            }
            catch (Exception ex) { MessageBox.Show("خطأ:\n" + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == -1) { MessageBox.Show("اختار موظف اولا"); return; }
            if (MessageBox.Show("متاكد؟", "حذف", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", selectedEmployeeID);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("تم الحذف بنجاح");
                ClearFields();
                LoadEmployees();
            }
            catch (Exception ex) { MessageBox.Show("خطأ:\n" + ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e) { ClearFields(); }

        private void btnClose_Click(object sender, EventArgs e) { Application.Exit(); }

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

        private void ClearFields()
        {
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            cmbUserType.SelectedIndex = 0;
            selectedEmployeeID = -1;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text)) { MessageBox.Show("ادخل الاسم"); return false; }
            if (string.IsNullOrWhiteSpace(txtUsername.Text)) { MessageBox.Show("ادخل اسم المستخدم"); return false; }
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) { MessageBox.Show("ادخل كلمة المرور"); return false; }
            return true;
        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}