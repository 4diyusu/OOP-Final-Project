namespace FinalProjectEnerio.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txtBxLoginUser = new TextBox();
            lblLogin = new Label();
            btnLoginAttempt = new Button();
            lblNoAccount = new Label();
            lLblSignUp = new LinkLabel();
            pnlLogin = new Panel();
            cBoxPassword = new CheckBox();
            lLblRegister = new LinkLabel();
            lblNoAccountyet = new Label();
            btnConfirmLogin = new Button();
            txtBxLoginPassword = new TextBox();
            txtBxLoginUsername = new TextBox();
            lLblResetPassword = new LinkLabel();
            lblForgotPassword = new Label();
            lblLogininLoginForm = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-180, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(936, 700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtBxLoginUser
            // 
            txtBxLoginUser.Cursor = Cursors.IBeam;
            txtBxLoginUser.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxLoginUser.ForeColor = SystemColors.ScrollBar;
            txtBxLoginUser.Location = new Point(32, 103);
            txtBxLoginUser.Name = "txtBxLoginUser";
            txtBxLoginUser.Size = new Size(259, 22);
            txtBxLoginUser.TabIndex = 7;
            txtBxLoginUser.Text = "Username";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(22, 36);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(106, 40);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // btnLoginAttempt
            // 
            btnLoginAttempt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginAttempt.Location = new Point(193, 202);
            btnLoginAttempt.Name = "btnLoginAttempt";
            btnLoginAttempt.Size = new Size(84, 27);
            btnLoginAttempt.TabIndex = 14;
            btnLoginAttempt.Text = "Login";
            btnLoginAttempt.UseVisualStyleBackColor = true;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoAccount.Location = new Point(137, 15);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(89, 13);
            lblNoAccount.TabIndex = 15;
            lblNoAccount.Text = "No account yet?";
            // 
            // lLblSignUp
            // 
            lLblSignUp.AutoSize = true;
            lLblSignUp.Location = new Point(232, 15);
            lLblSignUp.Name = "lLblSignUp";
            lLblSignUp.Size = new Size(48, 15);
            lLblSignUp.TabIndex = 16;
            lLblSignUp.TabStop = true;
            lLblSignUp.Text = "Sign Up";
            lLblSignUp.LinkClicked += lLblSignUp_LinkClicked;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(cBoxPassword);
            pnlLogin.Controls.Add(lLblRegister);
            pnlLogin.Controls.Add(lblNoAccountyet);
            pnlLogin.Controls.Add(btnConfirmLogin);
            pnlLogin.Controls.Add(txtBxLoginPassword);
            pnlLogin.Controls.Add(txtBxLoginUsername);
            pnlLogin.Controls.Add(lLblResetPassword);
            pnlLogin.Controls.Add(lblForgotPassword);
            pnlLogin.Controls.Add(lblLogininLoginForm);
            pnlLogin.Location = new Point(65, 160);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(335, 326);
            pnlLogin.TabIndex = 1;
            // 
            // cBoxPassword
            // 
            cBoxPassword.AutoSize = true;
            cBoxPassword.Location = new Point(171, 207);
            cBoxPassword.Name = "cBoxPassword";
            cBoxPassword.Size = new Size(108, 19);
            cBoxPassword.TabIndex = 8;
            cBoxPassword.Text = "Show Password";
            cBoxPassword.UseVisualStyleBackColor = true;
            cBoxPassword.CheckedChanged += cBoxPassword_CheckedChanged;
            // 
            // lLblRegister
            // 
            lLblRegister.AutoSize = true;
            lLblRegister.Location = new Point(258, 20);
            lLblRegister.Name = "lLblRegister";
            lLblRegister.Size = new Size(48, 15);
            lLblRegister.TabIndex = 7;
            lLblRegister.TabStop = true;
            lLblRegister.Text = "Sign Up";
            lLblRegister.LinkClicked += lLblRegister_LinkClicked;
            // 
            // lblNoAccountyet
            // 
            lblNoAccountyet.AutoSize = true;
            lblNoAccountyet.Location = new Point(159, 20);
            lblNoAccountyet.Name = "lblNoAccountyet";
            lblNoAccountyet.Size = new Size(93, 15);
            lblNoAccountyet.TabIndex = 6;
            lblNoAccountyet.Text = "No account yet?";
            // 
            // btnConfirmLogin
            // 
            btnConfirmLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmLogin.Location = new Point(204, 241);
            btnConfirmLogin.Name = "btnConfirmLogin";
            btnConfirmLogin.Size = new Size(75, 25);
            btnConfirmLogin.TabIndex = 5;
            btnConfirmLogin.Text = "Login";
            btnConfirmLogin.UseVisualStyleBackColor = true;
            btnConfirmLogin.Click += btnConfirmLogin_Click;
            // 
            // txtBxLoginPassword
            // 
            txtBxLoginPassword.ForeColor = SystemColors.WindowFrame;
            txtBxLoginPassword.Location = new Point(43, 178);
            txtBxLoginPassword.Name = "txtBxLoginPassword";
            txtBxLoginPassword.PasswordChar = '*';
            txtBxLoginPassword.Size = new Size(236, 23);
            txtBxLoginPassword.TabIndex = 4;
            txtBxLoginPassword.Text = "Password";
            // 
            // txtBxLoginUsername
            // 
            txtBxLoginUsername.ForeColor = SystemColors.WindowFrame;
            txtBxLoginUsername.Location = new Point(43, 124);
            txtBxLoginUsername.Name = "txtBxLoginUsername";
            txtBxLoginUsername.Size = new Size(236, 23);
            txtBxLoginUsername.TabIndex = 3;
            txtBxLoginUsername.Text = "Username";
            // 
            // lLblResetPassword
            // 
            lLblResetPassword.AutoSize = true;
            lLblResetPassword.Location = new Point(182, 291);
            lLblResetPassword.Name = "lLblResetPassword";
            lLblResetPassword.Size = new Size(88, 15);
            lLblResetPassword.TabIndex = 2;
            lLblResetPassword.TabStop = true;
            lLblResetPassword.Text = "Reset Password";
            lLblResetPassword.LinkClicked += lLblResetPassword_LinkClicked;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Location = new Point(76, 291);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(100, 15);
            lblForgotPassword.TabIndex = 1;
            lblForgotPassword.Text = "Forgot Password?";
            // 
            // lblLogininLoginForm
            // 
            lblLogininLoginForm.AutoSize = true;
            lblLogininLoginForm.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogininLoginForm.Location = new Point(26, 45);
            lblLogininLoginForm.Name = "lblLogininLoginForm";
            lblLogininLoginForm.Size = new Size(106, 40);
            lblLogininLoginForm.TabIndex = 0;
            lblLogininLoginForm.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(pnlLogin);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private LinkLabel lLblPrivacyPolicy;
        private LinkLabel lLblTermsofService;
        private Label lblAnd;
        private Label lblConditions;
        private TextBox txtBxAddress;
        private TextBox txtBxPassword;
        private TextBox txtBxLoginUser;
        private TextBox txtBxEmail;
        private TextBox txtBxPhone;
        private TextBox txtBxLastName;
        private TextBox txtBxFirstName;
        private Label lblQuickandEasy;
        private Label lblLogin;
        private Button btnLoginAttempt;
        private LinkLabel lLblSignUp;
        private Label lblNoAccount;
        private Panel pnlLogin;
        private Label lblLogininLoginForm;
        private LinkLabel lLblResetPassword;
        private Label lblForgotPassword;
        private TextBox txtBxLoginUsername;
        private LinkLabel lLblRegister;
        private Label lblNoAccountyet;
        private Button btnConfirmLogin;
        private TextBox txtBxLoginPassword;
        private CheckBox cBoxPassword;
    }
}