namespace WinForms_TEST
{
    partial class Login
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlLeft = new Panel();
            lblClinicIcon = new Label();
            label1 = new Label();
            lblClinicName = new Label();
            lblTagline = new Label();
            lblDesign = new Label();
            lnkSignUp = new LinkLabel();
            lblWelcomeSub = new Label();
            pnlRight = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            btnClose = new Button();
            lblUserName = new Label();
            lblUserIcon = new Label();
            txtUsername = new TextBox();
            pnlUserLine = new Panel();
            lblPassword = new Label();
            lblLockIcon = new Label();
            txtPassword = new TextBox();
            pnlPassLine = new Panel();
            btnLogin = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(60, 115, 175);
            pnlLeft.Controls.Add(lblClinicIcon);
            pnlLeft.Controls.Add(label1);
            pnlLeft.Controls.Add(lblClinicName);
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.Controls.Add(lblDesign);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(390, 585);
            pnlLeft.TabIndex = 1;
            pnlLeft.Paint += pnlLeft_Paint;
            // 
            // lblClinicIcon
            // 
            lblClinicIcon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblClinicIcon.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClinicIcon.ForeColor = Color.White;
            lblClinicIcon.Location = new Point(0, 146);
            lblClinicIcon.Name = "lblClinicIcon";
            lblClinicIcon.Size = new Size(390, 90);
            lblClinicIcon.TabIndex = 0;
            lblClinicIcon.Text = "🏥";
            lblClinicIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 33);
            label1.Name = "label1";
            label1.Size = new Size(390, 55);
            label1.TabIndex = 6;
            label1.Text = "Welcome Back!👋";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lblClinicName
            // 
            lblClinicName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblClinicName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicName.ForeColor = Color.White;
            lblClinicName.Location = new Point(20, 264);
            lblClinicName.Name = "lblClinicName";
            lblClinicName.Size = new Size(350, 50);
            lblClinicName.TabIndex = 1;
            lblClinicName.Text = "Taybah Center";
            lblClinicName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            lblTagline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTagline.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.FromArgb(220, 240, 255);
            lblTagline.Location = new Point(12, 418);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(350, 60);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "Your health is our priority\nAdvanced care, trusted results";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesign
            // 
            lblDesign.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDesign.AutoSize = true;
            lblDesign.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesign.ForeColor = Color.FromArgb(180, 220, 240);
            lblDesign.Location = new Point(20, 545);
            lblDesign.Name = "lblDesign";
            lblDesign.Size = new Size(0, 20);
            lblDesign.TabIndex = 5;
            // 
            // lnkSignUp
            // 
            lnkSignUp.ActiveLinkColor = Color.DodgerBlue;
            lnkSignUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lnkSignUp.BackColor = Color.Transparent;
            lnkSignUp.DisabledLinkColor = Color.Black;
            lnkSignUp.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkSignUp.ForeColor = Color.RoyalBlue;
            lnkSignUp.LinkColor = Color.RoyalBlue;
            lnkSignUp.Location = new Point(376, 499);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(120, 28);
            lnkSignUp.TabIndex = 4;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign Up";
            lnkSignUp.TextAlign = ContentAlignment.MiddleLeft;
            lnkSignUp.VisitedLinkColor = Color.RoyalBlue;
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked;
            // 
            // lblWelcomeSub
            // 
            lblWelcomeSub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcomeSub.BackColor = Color.Transparent;
            lblWelcomeSub.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcomeSub.ForeColor = Color.SteelBlue;
            lblWelcomeSub.Location = new Point(6, 104);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Size = new Size(595, 35);
            lblWelcomeSub.TabIndex = 7;
            lblWelcomeSub.Text = "login to access your clinic dashboard";
            lblWelcomeSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(label4);
            pnlRight.Controls.Add(label3);
            pnlRight.Controls.Add(label2);
            pnlRight.Controls.Add(lblTitle);
            pnlRight.Controls.Add(btnClose);
            pnlRight.Controls.Add(lnkSignUp);
            pnlRight.Controls.Add(lblWelcomeSub);
            pnlRight.Controls.Add(lblUserName);
            pnlRight.Controls.Add(lblUserIcon);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(pnlUserLine);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(lblLockIcon);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(pnlPassLine);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(390, 0);
            pnlRight.Margin = new Padding(3, 4, 3, 4);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(595, 585);
            pnlRight.TabIndex = 0;
            pnlRight.Paint += pnlRight_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Location = new Point(60, 499);
            label4.Name = "label4";
            label4.Size = new Size(310, 26);
            label4.TabIndex = 12;
            label4.Text = "Don't have an account?";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(542, 0);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 11;
            label3.Text = "⬜";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(508, 2);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 11;
            label2.Text = "➖";
            label2.Click += label2_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(0, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(595, 71);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Login";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Gray;
            btnClose.Location = new Point(565, -7);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.DimGray;
            lblUserName.Location = new Point(63, 180);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(105, 25);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "User Name";
            lblUserName.Click += lblUserName_Click;
            // 
            // lblUserIcon
            // 
            lblUserIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserIcon.AutoSize = true;
            lblUserIcon.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserIcon.ForeColor = Color.DimGray;
            lblUserIcon.Location = new Point(510, 209);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new Size(47, 32);
            lblUserIcon.TabIndex = 3;
            lblUserIcon.Text = "👤";
            lblUserIcon.Click += lblUserIcon_Click;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(63, 209);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(440, 27);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // pnlUserLine
            // 
            pnlUserLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlUserLine.BackColor = Color.DeepSkyBlue;
            pnlUserLine.Location = new Point(63, 241);
            pnlUserLine.Margin = new Padding(3, 4, 3, 4);
            pnlUserLine.Name = "pnlUserLine";
            pnlUserLine.Size = new Size(490, 2);
            pnlUserLine.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(63, 288);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // lblLockIcon
            // 
            lblLockIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLockIcon.AutoSize = true;
            lblLockIcon.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLockIcon.ForeColor = Color.DimGray;
            lblLockIcon.Location = new Point(510, 316);
            lblLockIcon.Name = "lblLockIcon";
            lblLockIcon.Size = new Size(47, 32);
            lblLockIcon.TabIndex = 7;
            lblLockIcon.Text = "🔒";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(63, 323);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(440, 27);
            txtPassword.TabIndex = 8;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pnlPassLine
            // 
            pnlPassLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPassLine.BackColor = Color.DeepSkyBlue;
            pnlPassLine.Location = new Point(63, 352);
            pnlPassLine.Margin = new Padding(3, 4, 3, 4);
            pnlPassLine.Name = "pnlPassLine";
            pnlPassLine.Size = new Size(490, 2);
            pnlPassLine.TabIndex = 9;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(60, 115, 175);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(63, 416);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(466, 60);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(985, 585);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(700, 500);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Left side
        private Panel pnlLeft;
        private LinkLabel lnkSignUp;
        private Label lblDesign;
        // Right side
        private Panel pnlRight;
        private Panel pnlUserLine;
        private Panel pnlPassLine;
        private Label lblTitle;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblUserIcon;
        private Label lblLockIcon;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label lblWelcomeSub;
        private Label label2;
        private Label label3;
        private Label lblClinicName;
        private Label lblTagline;
        private Label lblClinicIcon;
        private Label label4;
    }
}
