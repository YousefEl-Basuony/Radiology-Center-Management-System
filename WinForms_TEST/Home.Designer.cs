namespace WinForms_TEST
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            pnlRight = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            btnClose = new Button();
            lblWelcomeSub = new Label();
            lblBtnSeparator = new Label();
            btnLogin = new Button();
            lblOr = new Label();
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
            lblClinicIcon.Text = "\U0001fa7b";
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
            label1.Text = "Welcome! 👋";
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
            lblTagline.Text = "Your health is our priority\nAdvanced imaging, trusted results";
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
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(label4);
            pnlRight.Controls.Add(label3);
            pnlRight.Controls.Add(label2);
            pnlRight.Controls.Add(lblTitle);
            pnlRight.Controls.Add(btnClose);
            pnlRight.Controls.Add(lblWelcomeSub);
            pnlRight.Controls.Add(lblBtnSeparator);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(lblOr);
            pnlRight.Controls.Add(btnSignUp);
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
            label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(60, 549);
            label4.Name = "label4";
            label4.Size = new Size(466, 26);
            label4.TabIndex = 12;
            label4.Text = "Taybah X-Ray Center — Secure & Reliable System";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            lblTitle.Text = "Taybah X-Ray Center";
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
            // lblWelcomeSub
            // 
            lblWelcomeSub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcomeSub.BackColor = Color.Transparent;
            lblWelcomeSub.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcomeSub.ForeColor = Color.SteelBlue;
            lblWelcomeSub.Location = new Point(0, 105);
            lblWelcomeSub.Name = "lblWelcomeSub";
            lblWelcomeSub.Size = new Size(595, 35);
            lblWelcomeSub.TabIndex = 7;
            lblWelcomeSub.Text = "Please login or create a new account to continue";
            lblWelcomeSub.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcomeSub.Click += lblWelcomeSub_Click;
            // 
            // lblBtnSeparator
            // 
            lblBtnSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBtnSeparator.BackColor = Color.DeepSkyBlue;
            lblBtnSeparator.Location = new Point(63, 150);
            lblBtnSeparator.Name = "lblBtnSeparator";
            lblBtnSeparator.Size = new Size(466, 2);
            lblBtnSeparator.TabIndex = 13;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(60, 115, 175);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(63, 200);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(466, 60);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "🔑   Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblOr
            // 
            lblOr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblOr.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOr.ForeColor = Color.Silver;
            lblOr.Location = new Point(63, 278);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(466, 28);
            lblOr.TabIndex = 14;
            lblOr.Text = "─────────────  or  ─────────────";
            lblOr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSignUp.BackColor = Color.White;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(60, 115, 175);
            btnSignUp.FlatAppearance.BorderSize = 2;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.FromArgb(60, 115, 175);
            btnSignUp.Location = new Point(63, 318);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(466, 60);
            btnSignUp.TabIndex = 15;
            btnSignUp.Text = "✨   Create Account";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Home
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
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taybah X-Ray Center";
            Load += Home_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Left side
        private Panel pnlLeft;
        private Label lblClinicIcon;
        private Label label1;
        private Label lblClinicName;
        private Label lblTagline;
        private Label lblDesign;
        // Right side
        private Panel pnlRight;
        private Label lblTitle;
        private Button btnClose;
        private Label label2;
        private Label label3;
        private Label lblWelcomeSub;
        private Label lblBtnSeparator;
        private Button btnLogin;
        private Label lblOr;
        private Button btnSignUp;
        private Label label4;
    }
}