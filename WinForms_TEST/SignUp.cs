using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinForms_TEST
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }



        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                textBox5.PasswordChar = '\0';
                chkShowPassword.Text = "👁 Hide";
            }
            else
            {
                textBox5.PasswordChar = '●';
                chkShowPassword.Text = "👁 Show";
            }
            textBox5.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string userName = textBox4.Text.Trim();
            string phone = textBox3.Text.Trim();
            string email = textBox6.Text.Trim();
            string password = textBox5.Text;
            string role = radioButton1.Checked ? "Doctor" : "Assistant";

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields.", "Sign Up",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = @"Data Source=YOUSEFEL-BASUON;Initial Catalog=Taybah Center;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Auto-fix the AppUsers table if it already exists but lacks columns
                    string createTable = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AppUsers' and xtype='U')
                        CREATE TABLE AppUsers (
                            UserID INT IDENTITY(1,1) PRIMARY KEY,
                            FirstName NVARCHAR(50),
                            LastName NVARCHAR(50),
                            UserName NVARCHAR(50) UNIQUE,
                            Phone NVARCHAR(20),
                            Email NVARCHAR(100),
                            Password NVARCHAR(255),
                            Role NVARCHAR(50)
                        )";
                    using (SqlCommand cmdCreate = new SqlCommand(createTable, conn))
                    {
                        cmdCreate.ExecuteNonQuery();
                    }

                    // Attempt to add missing columns in case the table existed before
                    try { new SqlCommand("ALTER TABLE AppUsers ADD FirstName NVARCHAR(50);", conn).ExecuteNonQuery(); } catch { }
                    try { new SqlCommand("ALTER TABLE AppUsers ADD LastName NVARCHAR(50);", conn).ExecuteNonQuery(); } catch { }
                    try { new SqlCommand("ALTER TABLE AppUsers ADD Phone NVARCHAR(20);", conn).ExecuteNonQuery(); } catch { }
                    try { new SqlCommand("ALTER TABLE AppUsers ADD Email NVARCHAR(100);", conn).ExecuteNonQuery(); } catch { }
                    try { new SqlCommand("ALTER TABLE AppUsers ADD Role NVARCHAR(50);", conn).ExecuteNonQuery(); } catch { }

                    // Check if username already exists
                    string checkQuery = "SELECT COUNT(*) FROM AppUsers WHERE UserName = @userName";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@userName", userName);
                        int count = (int)cmdCheck.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert User
                    string insertQuery = "INSERT INTO AppUsers (FirstName, LastName, UserName, Phone, Email, Password, Role) VALUES (@fn, @ln, @un, @ph, @em, @pw, @rl)";
                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@fn", firstName);
                        cmdInsert.Parameters.AddWithValue("@ln", lastName);
                        cmdInsert.Parameters.AddWithValue("@un", userName);
                        cmdInsert.Parameters.AddWithValue("@ph", phone);
                        cmdInsert.Parameters.AddWithValue("@em", email);
                        cmdInsert.Parameters.AddWithValue("@pw", password);
                        cmdInsert.Parameters.AddWithValue("@rl", role);
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Account created successfully for {firstName} {lastName}! You can now login.", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Hide();
                Login loginForm = new Login();
                loginForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login signUpForm = new Login();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSignUpPrompt_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTagline_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
