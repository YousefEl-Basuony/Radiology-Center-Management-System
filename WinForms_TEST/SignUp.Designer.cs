namespace WinForms_TEST
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            lblClinicIcon = new Label();
            label1 = new Label();
            lblClinicName = new Label();
            lblTagline = new Label();
            lblDesign = new Label();
            lnkSignUp = new LinkLabel();
            lblSignUpPrompt = new Label();
            pnlRight = new Panel();
            label3 = new Label();
            label2 = new Label();
            btnClose = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblRoleLabel = new Label();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            lblFirstName = new Label();
            textBox1 = new TextBox();
            pnlLine1 = new Panel();
            lblLastName = new Label();
            textBox2 = new TextBox();
            pnlLine2 = new Panel();
            lblUserName = new Label();
            textBox4 = new TextBox();
            pnlLine4 = new Panel();
            lblPhone = new Label();
            textBox3 = new TextBox();
            pnlLine3 = new Panel();
            lblEmail = new Label();
            textBox6 = new TextBox();
            pnlLine6 = new Panel();
            lblPassword = new Label();
            textBox5 = new TextBox();
            pnlLine5 = new Panel();
            chkShowPassword = new CheckBox();
            btnSignUp = new Button();
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
            pnlLeft.TabIndex = 0;
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
            label1.TabIndex = 10;
            label1.Text = "Welcome Back!👋";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblClinicName
            // 
            lblClinicName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblClinicName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicName.ForeColor = Color.White;
            lblClinicName.Location = new Point(20, 264);
            lblClinicName.Name = "lblClinicName";
            lblClinicName.Size = new Size(350, 50);
            lblClinicName.TabIndex = 8;
            lblClinicName.Text = "Taybah Center";
            lblClinicName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTagline
            // 
            lblTagline.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTagline.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.FromArgb(220, 240, 255);
            lblTagline.Location = new Point(12, 419);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(350, 60);
            lblTagline.TabIndex = 9;
            lblTagline.Text = "Your health is our priority\nAdvanced care, trusted results";
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            lblTagline.Click += lblTagline_Click;
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
            lnkSignUp.DisabledLinkColor = Color.Transparent;
            lnkSignUp.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkSignUp.ForeColor = Color.RoyalBlue;
            lnkSignUp.LinkColor = Color.RoyalBlue;
            lnkSignUp.Location = new Point(384, 548);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(90, 28);
            lnkSignUp.TabIndex = 4;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Login";
            lnkSignUp.TextAlign = ContentAlignment.MiddleLeft;
            lnkSignUp.VisitedLinkColor = Color.RoyalBlue;
            lnkSignUp.LinkClicked += lnkSignUp_LinkClicked;
            // 
            // lblSignUpPrompt
            // 
            lblSignUpPrompt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSignUpPrompt.BackColor = Color.Transparent;
            lblSignUpPrompt.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSignUpPrompt.ForeColor = Color.DimGray;
            lblSignUpPrompt.ImageAlign = ContentAlignment.MiddleRight;
            lblSignUpPrompt.Location = new Point(122, 550);
            lblSignUpPrompt.Name = "lblSignUpPrompt";
            lblSignUpPrompt.Size = new Size(260, 26);
            lblSignUpPrompt.TabIndex = 3;
            lblSignUpPrompt.Text = "Already have an account?";
            lblSignUpPrompt.TextAlign = ContentAlignment.MiddleRight;
            lblSignUpPrompt.Click += lblSignUpPrompt_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(label3);
            pnlRight.Controls.Add(label2);
            pnlRight.Controls.Add(btnClose);
            pnlRight.Controls.Add(lblTitle);
            pnlRight.Controls.Add(lnkSignUp);
            pnlRight.Controls.Add(lblSubtitle);
            pnlRight.Controls.Add(lblSignUpPrompt);
            pnlRight.Controls.Add(lblRoleLabel);
            pnlRight.Controls.Add(radioButton1);
            pnlRight.Controls.Add(radioButton3);
            pnlRight.Controls.Add(lblFirstName);
            pnlRight.Controls.Add(textBox1);
            pnlRight.Controls.Add(pnlLine1);
            pnlRight.Controls.Add(lblLastName);
            pnlRight.Controls.Add(textBox2);
            pnlRight.Controls.Add(pnlLine2);
            pnlRight.Controls.Add(lblUserName);
            pnlRight.Controls.Add(textBox4);
            pnlRight.Controls.Add(pnlLine4);
            pnlRight.Controls.Add(lblPhone);
            pnlRight.Controls.Add(textBox3);
            pnlRight.Controls.Add(pnlLine3);
            pnlRight.Controls.Add(lblEmail);
            pnlRight.Controls.Add(textBox6);
            pnlRight.Controls.Add(pnlLine6);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(textBox5);
            pnlRight.Controls.Add(pnlLine5);
            pnlRight.Controls.Add(chkShowPassword);
            pnlRight.Controls.Add(btnSignUp);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(390, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(595, 585);
            pnlRight.TabIndex = 1;
            pnlRight.Paint += pnlRight_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(539, 7);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 28;
            label3.Text = "⬜";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(505, 8);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 27;
            label2.Text = "➖";
            label2.Click += label2_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Gray;
            btnClose.Location = new Point(568, -3);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 38);
            btnClose.TabIndex = 26;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(8, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(580, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sign Up";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.SteelBlue;
            lblSubtitle.Location = new Point(21, 86);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(540, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Create an account:";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // lblRoleLabel
            // 
            lblRoleLabel.AutoSize = true;
            lblRoleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleLabel.ForeColor = Color.DimGray;
            lblRoleLabel.Location = new Point(122, 134);
            lblRoleLabel.Name = "lblRoleLabel";
            lblRoleLabel.Size = new Size(47, 23);
            lblRoleLabel.TabIndex = 2;
            lblRoleLabel.Text = "Role:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.FromArgb(60, 115, 175);
            radioButton1.Location = new Point(203, 132);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 27);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Doctor";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.White;
            radioButton3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = Color.FromArgb(60, 115, 175);
            radioButton3.Location = new Point(335, 132);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(98, 27);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Assistant";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.DimGray;
            lblFirstName.Location = new Point(43, 188);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(92, 23);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(43, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 25);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pnlLine1
            // 
            pnlLine1.BackColor = Color.DeepSkyBlue;
            pnlLine1.Location = new Point(43, 240);
            pnlLine1.Name = "pnlLine1";
            pnlLine1.Size = new Size(220, 2);
            pnlLine1.TabIndex = 8;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.DimGray;
            lblLastName.Location = new Point(335, 188);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(91, 23);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(335, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 25);
            textBox2.TabIndex = 10;
            // 
            // pnlLine2
            // 
            pnlLine2.BackColor = Color.DeepSkyBlue;
            pnlLine2.Location = new Point(335, 240);
            pnlLine2.Name = "pnlLine2";
            pnlLine2.Size = new Size(220, 2);
            pnlLine2.TabIndex = 11;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.DimGray;
            lblUserName.Location = new Point(43, 262);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(95, 23);
            lblUserName.TabIndex = 12;
            lblUserName.Text = "User Name";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(43, 286);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 25);
            textBox4.TabIndex = 13;
            // 
            // pnlLine4
            // 
            pnlLine4.BackColor = Color.DeepSkyBlue;
            pnlLine4.Location = new Point(43, 314);
            pnlLine4.Name = "pnlLine4";
            pnlLine4.Size = new Size(220, 2);
            pnlLine4.TabIndex = 14;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.DimGray;
            lblPhone.Location = new Point(335, 262);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(127, 23);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Phone Number";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(335, 286);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 25);
            textBox3.TabIndex = 16;
            // 
            // pnlLine3
            // 
            pnlLine3.BackColor = Color.DeepSkyBlue;
            pnlLine3.Location = new Point(335, 314);
            pnlLine3.Name = "pnlLine3";
            pnlLine3.Size = new Size(220, 2);
            pnlLine3.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(43, 336);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(43, 360);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(220, 25);
            textBox6.TabIndex = 19;
            // 
            // pnlLine6
            // 
            pnlLine6.BackColor = Color.DeepSkyBlue;
            pnlLine6.Location = new Point(43, 388);
            pnlLine6.Name = "pnlLine6";
            pnlLine6.Size = new Size(220, 2);
            pnlLine6.TabIndex = 20;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(335, 336);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 23);
            lblPassword.TabIndex = 21;
            lblPassword.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(335, 360);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '●';
            textBox5.Size = new Size(170, 25);
            textBox5.TabIndex = 22;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // pnlLine5
            // 
            pnlLine5.BackColor = Color.DeepSkyBlue;
            pnlLine5.Location = new Point(335, 388);
            pnlLine5.Name = "pnlLine5";
            pnlLine5.Size = new Size(220, 2);
            pnlLine5.TabIndex = 23;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.FromArgb(80, 110, 160);
            chkShowPassword.Location = new Point(510, 360);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(65, 22);
            chkShowPassword.TabIndex = 24;
            chkShowPassword.Text = "👁 Show";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSignUp.BackColor = Color.FromArgb(60, 115, 175);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(96, 446);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(400, 60);
            btnSignUp.TabIndex = 25;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(985, 585);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(700, 500);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Left side
        private Panel pnlLeft;

        // Right side
        private Panel pnlRight;
        private Label lblSubtitle;
        private Label lblRoleLabel;
        private RadioButton radioButton1;
        private RadioButton radioButton3;

        // Row 1
        private Label lblFirstName;
        private TextBox textBox1;
        private Panel pnlLine1;
        private Label lblLastName;
        private TextBox textBox2;
        private Panel pnlLine2;

        // Row 2
        private Label lblUserName;
        private TextBox textBox4;
        private Panel pnlLine4;
        private Label lblPhone;
        private TextBox textBox3;
        private Panel pnlLine3;

        // Row 3
        private Label lblEmail;
        private TextBox textBox6;
        private Panel pnlLine6;
        private Label lblPassword;
        private TextBox textBox5;
        private Panel pnlLine5;
        private CheckBox chkShowPassword;

        private Button btnSignUp;
        private Label label3;
        private Label label2;
        private Button btnClose;
        private Label lblClinicIcon;
        private Label label1;
        private Label lblClinicName;
        private Label lblTagline;
        private LinkLabel lnkSignUp;
        private Label lblDesign;
        private Label lblSignUpPrompt;
        private Label lblTitle;
    }
}