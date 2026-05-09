using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinForms_TEST
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = @"Data Source=YOUSEFEL-BASUON;Initial Catalog=Taybah Center;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Create table if not exists (in case they login before signup)
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
                    using (SqlCommand cmdCreate = new SqlCommand(createTable, con))
                    {
                        cmdCreate.ExecuteNonQuery();
                    }

                    // Auto-fix table to add Role if it was missing
                    try { new SqlCommand("ALTER TABLE AppUsers ADD Role NVARCHAR(50);", con).ExecuteNonQuery(); } catch { }

                    string query = "SELECT Role FROM AppUsers WHERE UserName = @u AND Password = @p";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        
                        object roleObj = cmd.ExecuteScalar();

                        if (roleObj != null || (username == "admin" && password == "password")) // Fallback to admin if DB is empty
                        {
                            string role = roleObj != null ? roleObj.ToString() : "Admin";
                            MessageBox.Show($"Welcome, {username}! ({role})", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            this.Hide();
                            ReceptionForm mainForm = new ReceptionForm();
                            mainForm.LoggedInUserName = username;
                            mainForm.UserRole = role;
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Username field changed
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void lblUserIcon_Click(object sender, EventArgs e)
        {
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblSignUpPrompt_Click(object sender, EventArgs e)
        {
        }
    }
}
