namespace FinalProjectEnerio.Forms
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            pictureBox1 = new PictureBox();
            pnlSignUp = new Panel();
            cBxGender = new ComboBox();
            lLblPrivacyPolicy = new LinkLabel();
            lLblTermsofService = new LinkLabel();
            lblAnd = new Label();
            lblConditions = new Label();
            txtBxAddress = new TextBox();
            txtBxPasswordSignup = new TextBox();
            txtBxUsernameSignup = new TextBox();
            txtBxEmail = new TextBox();
            txtBxPhone = new TextBox();
            txtBxLastName = new TextBox();
            txtBxFirstName = new TextBox();
            lblQuickandEasy = new Label();
            lblSignUp = new Label();
            pnlSUbuttons = new Panel();
            btnCreateAccount = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSignUp.SuspendLayout();
            pnlSUbuttons.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-13, -137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1270, 955);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlSignUp
            // 
            pnlSignUp.BackColor = SystemColors.ControlLightLight;
            pnlSignUp.BorderStyle = BorderStyle.FixedSingle;
            pnlSignUp.Controls.Add(cBxGender);
            pnlSignUp.Controls.Add(lLblPrivacyPolicy);
            pnlSignUp.Controls.Add(lLblTermsofService);
            pnlSignUp.Controls.Add(lblAnd);
            pnlSignUp.Controls.Add(lblConditions);
            pnlSignUp.Controls.Add(txtBxAddress);
            pnlSignUp.Controls.Add(txtBxPasswordSignup);
            pnlSignUp.Controls.Add(txtBxUsernameSignup);
            pnlSignUp.Controls.Add(txtBxEmail);
            pnlSignUp.Controls.Add(txtBxPhone);
            pnlSignUp.Controls.Add(txtBxLastName);
            pnlSignUp.Controls.Add(txtBxFirstName);
            pnlSignUp.Controls.Add(lblQuickandEasy);
            pnlSignUp.Controls.Add(lblSignUp);
            pnlSignUp.Location = new Point(65, 100);
            pnlSignUp.Name = "pnlSignUp";
            pnlSignUp.Size = new Size(335, 326);
            pnlSignUp.TabIndex = 1;
            // 
            // cBxGender
            // 
            cBxGender.ForeColor = SystemColors.WindowFrame;
            cBxGender.FormattingEnabled = true;
            cBxGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cBxGender.Location = new Point(182, 161);
            cBxGender.Name = "cBxGender";
            cBxGender.Size = new Size(124, 23);
            cBxGender.TabIndex = 14;
            cBxGender.Text = "Gender";
            // 
            // lLblPrivacyPolicy
            // 
            lLblPrivacyPolicy.AutoSize = true;
            lLblPrivacyPolicy.Location = new Point(182, 286);
            lLblPrivacyPolicy.Name = "lLblPrivacyPolicy";
            lLblPrivacyPolicy.Size = new Size(80, 15);
            lLblPrivacyPolicy.TabIndex = 13;
            lLblPrivacyPolicy.TabStop = true;
            lLblPrivacyPolicy.Text = "Privacy Policy";
            // 
            // lLblTermsofService
            // 
            lLblTermsofService.AutoSize = true;
            lLblTermsofService.Location = new Point(64, 287);
            lLblTermsofService.Name = "lLblTermsofService";
            lLblTermsofService.Size = new Size(92, 15);
            lLblTermsofService.TabIndex = 12;
            lLblTermsofService.TabStop = true;
            lLblTermsofService.Text = "Terms of Service";
            // 
            // lblAnd
            // 
            lblAnd.AutoSize = true;
            lblAnd.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnd.Location = new Point(156, 288);
            lblAnd.Name = "lblAnd";
            lblAnd.Size = new Size(27, 13);
            lblAnd.TabIndex = 11;
            lblAnd.Text = "and";
            // 
            // lblConditions
            // 
            lblConditions.AutoSize = true;
            lblConditions.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConditions.Location = new Point(84, 275);
            lblConditions.Name = "lblConditions";
            lblConditions.Size = new Size(171, 13);
            lblConditions.TabIndex = 10;
            lblConditions.Text = "By proceeding, you agree to the";
            // 
            // txtBxAddress
            // 
            txtBxAddress.Cursor = Cursors.IBeam;
            txtBxAddress.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxAddress.ForeColor = SystemColors.WindowFrame;
            txtBxAddress.Location = new Point(21, 237);
            txtBxAddress.Name = "txtBxAddress";
            txtBxAddress.Size = new Size(285, 22);
            txtBxAddress.TabIndex = 9;
            txtBxAddress.Text = "Address";
            // 
            // txtBxPasswordSignup
            // 
            txtBxPasswordSignup.Cursor = Cursors.IBeam;
            txtBxPasswordSignup.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxPasswordSignup.ForeColor = SystemColors.WindowFrame;
            txtBxPasswordSignup.Location = new Point(182, 124);
            txtBxPasswordSignup.Name = "txtBxPasswordSignup";
            txtBxPasswordSignup.Size = new Size(124, 22);
            txtBxPasswordSignup.TabIndex = 8;
            txtBxPasswordSignup.Text = "Password";
            // 
            // txtBxUsernameSignup
            // 
            txtBxUsernameSignup.Cursor = Cursors.IBeam;
            txtBxUsernameSignup.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxUsernameSignup.ForeColor = SystemColors.WindowFrame;
            txtBxUsernameSignup.Location = new Point(182, 87);
            txtBxUsernameSignup.Name = "txtBxUsernameSignup";
            txtBxUsernameSignup.Size = new Size(124, 22);
            txtBxUsernameSignup.TabIndex = 7;
            txtBxUsernameSignup.Text = "Username";
            // 
            // txtBxEmail
            // 
            txtBxEmail.Cursor = Cursors.IBeam;
            txtBxEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxEmail.ForeColor = SystemColors.WindowFrame;
            txtBxEmail.Location = new Point(21, 200);
            txtBxEmail.Name = "txtBxEmail";
            txtBxEmail.Size = new Size(145, 22);
            txtBxEmail.TabIndex = 5;
            txtBxEmail.Text = "Email Address";
            // 
            // txtBxPhone
            // 
            txtBxPhone.Cursor = Cursors.IBeam;
            txtBxPhone.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxPhone.ForeColor = SystemColors.WindowFrame;
            txtBxPhone.Location = new Point(21, 161);
            txtBxPhone.Name = "txtBxPhone";
            txtBxPhone.Size = new Size(145, 22);
            txtBxPhone.TabIndex = 4;
            txtBxPhone.Text = "Phone";
            // 
            // txtBxLastName
            // 
            txtBxLastName.Cursor = Cursors.IBeam;
            txtBxLastName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxLastName.ForeColor = SystemColors.WindowFrame;
            txtBxLastName.Location = new Point(21, 124);
            txtBxLastName.Name = "txtBxLastName";
            txtBxLastName.Size = new Size(135, 22);
            txtBxLastName.TabIndex = 3;
            txtBxLastName.Text = "Last Name";
            // 
            // txtBxFirstName
            // 
            txtBxFirstName.Cursor = Cursors.IBeam;
            txtBxFirstName.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxFirstName.ForeColor = SystemColors.WindowFrame;
            txtBxFirstName.Location = new Point(21, 87);
            txtBxFirstName.Name = "txtBxFirstName";
            txtBxFirstName.Size = new Size(135, 22);
            txtBxFirstName.TabIndex = 2;
            txtBxFirstName.Text = "First Name";
            // 
            // lblQuickandEasy
            // 
            lblQuickandEasy.AutoSize = true;
            lblQuickandEasy.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuickandEasy.Location = new Point(21, 50);
            lblQuickandEasy.Name = "lblQuickandEasy";
            lblQuickandEasy.Size = new Size(104, 13);
            lblQuickandEasy.TabIndex = 1;
            lblQuickandEasy.Text = "It's quick and easy!";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.Location = new Point(12, 10);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(133, 40);
            lblSignUp.TabIndex = 0;
            lblSignUp.Text = "SIGN UP";
            // 
            // pnlSUbuttons
            // 
            pnlSUbuttons.BackColor = Color.WhiteSmoke;
            pnlSUbuttons.BorderStyle = BorderStyle.FixedSingle;
            pnlSUbuttons.Controls.Add(btnCreateAccount);
            pnlSUbuttons.Controls.Add(btnCancel);
            pnlSUbuttons.Location = new Point(65, 477);
            pnlSUbuttons.Name = "pnlSUbuttons";
            pnlSUbuttons.Size = new Size(335, 100);
            pnlSUbuttons.TabIndex = 2;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(182, 29);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(135, 42);
            btnCreateAccount.TabIndex = 1;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(21, 29);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 42);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(pnlSUbuttons);
            Controls.Add(pnlSignUp);
            Controls.Add(pictureBox1);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSignUp.ResumeLayout(false);
            pnlSignUp.PerformLayout();
            pnlSUbuttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel pnlSignUp;
        private Label lblSignUp;
        private Panel pnlSUbuttons;
        private Label lblQuickandEasy;
        private TextBox txtBxAddress;
        private TextBox txtBxPasswordSignup;
        private TextBox txtBxUsernameSignup;
        private TextBox txtBxEmail;
        private TextBox txtBxPhone;
        private TextBox txtBxLastName;
        private TextBox txtBxFirstName;
        private Label lblConditions;
        private Label lblAnd;
        private LinkLabel lLblPrivacyPolicy;
        private LinkLabel lLblTermsofService;
        private Button btnCreateAccount;
        private Button btnCancel;
        private ComboBox cBxGender;
    }
}