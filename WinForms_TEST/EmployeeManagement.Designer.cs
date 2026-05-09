namespace WinForms_TEST
{
    partial class EmployeeManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlLeft = new Panel();
            lblTagline = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlRight = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            lblFullName = new Label();
            txtFullName = new TextBox();
            pnlLineFullName = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            pnlLineUsername = new Panel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            pnlLinePassword = new Panel();
            lblPhone = new Label();
            txtPhone = new TextBox();
            pnlLinePhone = new Panel();
            lblUserType = new Label();
            cmbUserType = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvEmployees = new DataGridView();
            pnlLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRight.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(60, 115, 175);
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.Controls.Add(label1);
            pnlLeft.Controls.Add(panel1);
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(200, 100);
            pnlLeft.TabIndex = 0;
            // 
            // lblTagline
            // 
            lblTagline.ForeColor = Color.FromArgb(220, 240, 255);
            lblTagline.Location = new Point(0, 0);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(100, 23);
            lblTagline.TabIndex = 0;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 25, 25);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(25, 25, 25);
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.ForeColor = Color.Gainsboro;
            btnClose.Location = new Point(0, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.ForeColor = Color.Gainsboro;
            btnMaximize.Location = new Point(0, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(75, 23);
            btnMaximize.TabIndex = 1;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.Location = new Point(0, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(75, 23);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(panel3);
            pnlRight.Controls.Add(lblFullName);
            pnlRight.Controls.Add(txtFullName);
            pnlRight.Controls.Add(pnlLineFullName);
            pnlRight.Controls.Add(lblUsername);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(pnlLineUsername);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(pnlLinePassword);
            pnlRight.Controls.Add(lblPhone);
            pnlRight.Controls.Add(txtPhone);
            pnlRight.Controls.Add(pnlLinePhone);
            pnlRight.Controls.Add(lblUserType);
            pnlRight.Controls.Add(cmbUserType);
            pnlRight.Controls.Add(btnAdd);
            pnlRight.Controls.Add(btnUpdate);
            pnlRight.Controls.Add(btnDelete);
            pnlRight.Controls.Add(btnClear);
            pnlRight.Controls.Add(dgvEmployees);
            pnlRight.Location = new Point(0, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(200, 100);
            pnlRight.TabIndex = 1;
            pnlRight.Paint += pnlRight_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(25, 25, 25);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnMaximize);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnMinimize);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(25, 25, 25);
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // lblFullName
            // 
            lblFullName.ForeColor = Color.FromArgb(100, 100, 100);
            lblFullName.Location = new Point(0, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Location = new Point(0, 0);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 20);
            txtFullName.TabIndex = 2;
            // 
            // pnlLineFullName
            // 
            pnlLineFullName.BackColor = Color.FromArgb(60, 115, 175);
            pnlLineFullName.Location = new Point(0, 0);
            pnlLineFullName.Name = "pnlLineFullName";
            pnlLineFullName.Size = new Size(200, 100);
            pnlLineFullName.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.ForeColor = Color.FromArgb(100, 100, 100);
            lblUsername.Location = new Point(0, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(0, 0);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 20);
            txtUsername.TabIndex = 5;
            // 
            // pnlLineUsername
            // 
            pnlLineUsername.BackColor = Color.FromArgb(60, 115, 175);
            pnlLineUsername.Location = new Point(0, 0);
            pnlLineUsername.Name = "pnlLineUsername";
            pnlLineUsername.Size = new Size(200, 100);
            pnlLineUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.ForeColor = Color.FromArgb(100, 100, 100);
            lblPassword.Location = new Point(0, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(0, 0);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 20);
            txtPassword.TabIndex = 8;
            // 
            // pnlLinePassword
            // 
            pnlLinePassword.BackColor = Color.FromArgb(60, 115, 175);
            pnlLinePassword.Location = new Point(0, 0);
            pnlLinePassword.Name = "pnlLinePassword";
            pnlLinePassword.Size = new Size(200, 100);
            pnlLinePassword.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.ForeColor = Color.FromArgb(100, 100, 100);
            lblPhone.Location = new Point(0, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Location = new Point(0, 0);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 20);
            txtPhone.TabIndex = 11;
            // 
            // pnlLinePhone
            // 
            pnlLinePhone.BackColor = Color.FromArgb(60, 115, 175);
            pnlLinePhone.Location = new Point(0, 0);
            pnlLinePhone.Name = "pnlLinePhone";
            pnlLinePhone.Size = new Size(200, 100);
            pnlLinePhone.TabIndex = 12;
            // 
            // lblUserType
            // 
            lblUserType.ForeColor = Color.FromArgb(100, 100, 100);
            lblUserType.Location = new Point(0, 0);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(100, 23);
            lblUserType.TabIndex = 13;
            // 
            // cmbUserType
            // 
            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.Location = new Point(0, 0);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(121, 28);
            cmbUserType.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(60, 115, 175);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 140, 0);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(0, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 18;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 80, 162);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployees.ColumnHeadersHeight = 29;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.Location = new Point(0, 0);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(240, 150);
            dgvEmployees.TabIndex = 19;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // EmployeeManagement
            // 
            BackColor = Color.White;
            ClientSize = new Size(847, 346);
            Controls.Add(pnlLeft);
            Controls.Add(pnlRight);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeManagement";
            Load += EmployeeManagement_Load;
            pnlLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel pnlLineFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlLineUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlLinePassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel pnlLinePhone;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblTagline;
    }
}