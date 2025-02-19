namespace FinalProjectEnerio
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            btnCreateAccount = new Button();
            btnLogin = new Button();
            lblWelcome = new Label();
            pBoxLoginBG = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxLoginBG).BeginInit();
            SuspendLayout();
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(503, 216);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(137, 32);
            btnCreateAccount.TabIndex = 12;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(503, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 32);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Gainsboro;
            lblWelcome.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(454, 141);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(204, 47);
            lblWelcome.TabIndex = 14;
            lblWelcome.Text = "WELCOME!";
            // 
            // pBoxLoginBG
            // 
            pBoxLoginBG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBoxLoginBG.Image = (Image)resources.GetObject("pBoxLoginBG.Image");
            pBoxLoginBG.Location = new Point(-8, -19);
            pBoxLoginBG.Name = "pBoxLoginBG";
            pBoxLoginBG.Size = new Size(720, 480);
            pBoxLoginBG.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxLoginBG.TabIndex = 11;
            pBoxLoginBG.TabStop = false;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(704, 441);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogin);
            Controls.Add(btnCreateAccount);
            Controls.Add(pBoxLoginBG);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to PC GATO";
            ((System.ComponentModel.ISupportInitialize)pBoxLoginBG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private LinkLabel lLabelRegister;
        private Label lblNoAccount;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCreateAccount;
        private Button btnLogin;
        private Label lblWelcome;
        private PictureBox pBoxLoginBG;
    }
}
