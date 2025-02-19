namespace FinalProjectEnerio.Forms
{
    partial class AccountRecoveryWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountRecoveryWindow));
            pBoxAccountRecoverybg = new PictureBox();
            pnlLogin = new Panel();
            btnRecoverConfirm = new Button();
            btnRecoverCancel = new Button();
            lblMakeSure = new Label();
            txtBxChangePassword = new TextBox();
            lblChangePassword = new Label();
            btnCheckCredentials = new Button();
            txtBxRecoverPhone = new TextBox();
            txtBxRecoverLastName = new TextBox();
            txtBxRecoverFirstName = new TextBox();
            txtBxRecoverUsername = new TextBox();
            lblRecoverPhone = new Label();
            lblRecoverLastName = new Label();
            lblRecoverFirstName = new Label();
            lblRecoverUsername = new Label();
            lblAccountRecovery = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxAccountRecoverybg).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pBoxAccountRecoverybg
            // 
            pBoxAccountRecoverybg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBoxAccountRecoverybg.Image = (Image)resources.GetObject("pBoxAccountRecoverybg.Image");
            pBoxAccountRecoverybg.Location = new Point(-703, -21);
            pBoxAccountRecoverybg.Name = "pBoxAccountRecoverybg";
            pBoxAccountRecoverybg.Size = new Size(1203, 706);
            pBoxAccountRecoverybg.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxAccountRecoverybg.TabIndex = 0;
            pBoxAccountRecoverybg.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnRecoverConfirm);
            pnlLogin.Controls.Add(btnRecoverCancel);
            pnlLogin.Controls.Add(lblMakeSure);
            pnlLogin.Controls.Add(txtBxChangePassword);
            pnlLogin.Controls.Add(lblChangePassword);
            pnlLogin.Controls.Add(btnCheckCredentials);
            pnlLogin.Controls.Add(txtBxRecoverPhone);
            pnlLogin.Controls.Add(txtBxRecoverLastName);
            pnlLogin.Controls.Add(txtBxRecoverFirstName);
            pnlLogin.Controls.Add(txtBxRecoverUsername);
            pnlLogin.Controls.Add(lblRecoverPhone);
            pnlLogin.Controls.Add(lblRecoverLastName);
            pnlLogin.Controls.Add(lblRecoverFirstName);
            pnlLogin.Controls.Add(lblRecoverUsername);
            pnlLogin.Controls.Add(lblAccountRecovery);
            pnlLogin.Location = new Point(62, 117);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(335, 402);
            pnlLogin.TabIndex = 2;
            // 
            // btnRecoverConfirm
            // 
            btnRecoverConfirm.Location = new Point(201, 327);
            btnRecoverConfirm.Name = "btnRecoverConfirm";
            btnRecoverConfirm.Size = new Size(75, 23);
            btnRecoverConfirm.TabIndex = 14;
            btnRecoverConfirm.Text = "Confirm";
            btnRecoverConfirm.UseVisualStyleBackColor = true;
            btnRecoverConfirm.Visible = false;
            btnRecoverConfirm.Click += btnRecoverConfirm_Click;
            // 
            // btnRecoverCancel
            // 
            btnRecoverCancel.Location = new Point(60, 327);
            btnRecoverCancel.Name = "btnRecoverCancel";
            btnRecoverCancel.Size = new Size(75, 23);
            btnRecoverCancel.TabIndex = 13;
            btnRecoverCancel.Text = "Cancel";
            btnRecoverCancel.UseVisualStyleBackColor = true;
            btnRecoverCancel.Click += btnRecoverCancel_Click;
            // 
            // lblMakeSure
            // 
            lblMakeSure.AutoSize = true;
            lblMakeSure.Location = new Point(60, 374);
            lblMakeSure.Name = "lblMakeSure";
            lblMakeSure.Size = new Size(216, 15);
            lblMakeSure.TabIndex = 12;
            lblMakeSure.Text = "Make sure to remember your password!";
            // 
            // txtBxChangePassword
            // 
            txtBxChangePassword.Location = new Point(32, 295);
            txtBxChangePassword.Name = "txtBxChangePassword";
            txtBxChangePassword.Size = new Size(271, 23);
            txtBxChangePassword.TabIndex = 11;
            txtBxChangePassword.Visible = false;
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Location = new Point(32, 268);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(101, 15);
            lblChangePassword.TabIndex = 10;
            lblChangePassword.Text = "Change Password";
            lblChangePassword.Visible = false;
            // 
            // btnCheckCredentials
            // 
            btnCheckCredentials.AutoSize = true;
            btnCheckCredentials.Location = new Point(180, 236);
            btnCheckCredentials.Name = "btnCheckCredentials";
            btnCheckCredentials.Size = new Size(112, 25);
            btnCheckCredentials.TabIndex = 9;
            btnCheckCredentials.Text = "Check Credentials";
            btnCheckCredentials.UseVisualStyleBackColor = true;
            btnCheckCredentials.Click += btnCheckCredentials_Click;
            // 
            // txtBxRecoverPhone
            // 
            txtBxRecoverPhone.Location = new Point(111, 195);
            txtBxRecoverPhone.Name = "txtBxRecoverPhone";
            txtBxRecoverPhone.Size = new Size(192, 23);
            txtBxRecoverPhone.TabIndex = 8;
            // 
            // txtBxRecoverLastName
            // 
            txtBxRecoverLastName.Location = new Point(111, 158);
            txtBxRecoverLastName.Name = "txtBxRecoverLastName";
            txtBxRecoverLastName.Size = new Size(192, 23);
            txtBxRecoverLastName.TabIndex = 7;
            // 
            // txtBxRecoverFirstName
            // 
            txtBxRecoverFirstName.Location = new Point(111, 122);
            txtBxRecoverFirstName.Name = "txtBxRecoverFirstName";
            txtBxRecoverFirstName.Size = new Size(192, 23);
            txtBxRecoverFirstName.TabIndex = 6;
            // 
            // txtBxRecoverUsername
            // 
            txtBxRecoverUsername.Location = new Point(111, 85);
            txtBxRecoverUsername.Name = "txtBxRecoverUsername";
            txtBxRecoverUsername.Size = new Size(192, 23);
            txtBxRecoverUsername.TabIndex = 5;
            // 
            // lblRecoverPhone
            // 
            lblRecoverPhone.AutoSize = true;
            lblRecoverPhone.Location = new Point(32, 198);
            lblRecoverPhone.Name = "lblRecoverPhone";
            lblRecoverPhone.Size = new Size(41, 15);
            lblRecoverPhone.TabIndex = 4;
            lblRecoverPhone.Text = "Phone";
            // 
            // lblRecoverLastName
            // 
            lblRecoverLastName.AutoSize = true;
            lblRecoverLastName.Location = new Point(32, 161);
            lblRecoverLastName.Name = "lblRecoverLastName";
            lblRecoverLastName.Size = new Size(63, 15);
            lblRecoverLastName.TabIndex = 3;
            lblRecoverLastName.Text = "Last Name";
            // 
            // lblRecoverFirstName
            // 
            lblRecoverFirstName.AutoSize = true;
            lblRecoverFirstName.Location = new Point(32, 125);
            lblRecoverFirstName.Name = "lblRecoverFirstName";
            lblRecoverFirstName.Size = new Size(64, 15);
            lblRecoverFirstName.TabIndex = 2;
            lblRecoverFirstName.Text = "First Name";
            // 
            // lblRecoverUsername
            // 
            lblRecoverUsername.AutoSize = true;
            lblRecoverUsername.Location = new Point(32, 88);
            lblRecoverUsername.Name = "lblRecoverUsername";
            lblRecoverUsername.RightToLeft = RightToLeft.No;
            lblRecoverUsername.Size = new Size(60, 15);
            lblRecoverUsername.TabIndex = 1;
            lblRecoverUsername.Text = "Username";
            // 
            // lblAccountRecovery
            // 
            lblAccountRecovery.AutoSize = true;
            lblAccountRecovery.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountRecovery.Location = new Point(32, 15);
            lblAccountRecovery.Name = "lblAccountRecovery";
            lblAccountRecovery.Size = new Size(271, 45);
            lblAccountRecovery.TabIndex = 0;
            lblAccountRecovery.Text = "Recover Account";
            // 
            // AccountRecoveryWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(pnlLogin);
            Controls.Add(pBoxAccountRecoverybg);
            Name = "AccountRecoveryWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Recovery";
            ((System.ComponentModel.ISupportInitialize)pBoxAccountRecoverybg).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pBoxAccountRecoverybg;
        private Panel pnlLogin;
        private Label lblAccountRecovery;
        private Label lblChangePassword;
        private Button btnCheckCredentials;
        private TextBox txtBxRecoverPhone;
        private TextBox txtBxRecoverLastName;
        private TextBox txtBxRecoverFirstName;
        private TextBox txtBxRecoverUsername;
        private Label lblRecoverPhone;
        private Label lblRecoverLastName;
        private Label lblRecoverFirstName;
        private Label lblRecoverUsername;
        private Label lblMakeSure;
        private TextBox txtBxChangePassword;
        private Button btnRecoverConfirm;
        private Button btnRecoverCancel;
    }
}