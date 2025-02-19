namespace FinalProjectEnerio.Forms
{
    partial class PaymentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentWindow));
            pnlPayment = new Panel();
            tbCtrlPayment = new TabControl();
            tbPageOneTime = new TabPage();
            panel1 = new Panel();
            lblPaymentTotal = new Label();
            btnConfirmPayment = new Button();
            lblPayHere = new Label();
            lblAmountDue = new Label();
            txtBxOneTimePayment = new TextBox();
            tbPageTerm = new TabPage();
            panel2 = new Panel();
            btnCheck = new Button();
            lblTermExplanation = new Label();
            txtBxMonthsToPay = new TextBox();
            lblMonthsCount = new Label();
            lblTermAmountDue = new Label();
            btnConfirmPaymentTerm = new Button();
            label2 = new Label();
            label3 = new Label();
            txtBxTermPayment = new TextBox();
            lblPayment = new Label();
            pictureBox1 = new PictureBox();
            pnlChange = new Panel();
            btnOpenReceipt = new Button();
            lblChangeE = new Label();
            lblChange = new Label();
            lblQuote = new Label();
            btnPaymentCancel = new Button();
            pnlPayment.SuspendLayout();
            tbCtrlPayment.SuspendLayout();
            tbPageOneTime.SuspendLayout();
            panel1.SuspendLayout();
            tbPageTerm.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlChange.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPayment
            // 
            pnlPayment.Controls.Add(tbCtrlPayment);
            pnlPayment.Controls.Add(lblPayment);
            pnlPayment.Location = new Point(60, 33);
            pnlPayment.Name = "pnlPayment";
            pnlPayment.Size = new Size(335, 402);
            pnlPayment.TabIndex = 3;
            // 
            // tbCtrlPayment
            // 
            tbCtrlPayment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCtrlPayment.Controls.Add(tbPageOneTime);
            tbCtrlPayment.Controls.Add(tbPageTerm);
            tbCtrlPayment.Location = new Point(3, 75);
            tbCtrlPayment.Name = "tbCtrlPayment";
            tbCtrlPayment.SelectedIndex = 0;
            tbCtrlPayment.Size = new Size(329, 324);
            tbCtrlPayment.TabIndex = 1;
            // 
            // tbPageOneTime
            // 
            tbPageOneTime.Controls.Add(panel1);
            tbPageOneTime.Location = new Point(4, 24);
            tbPageOneTime.Name = "tbPageOneTime";
            tbPageOneTime.Padding = new Padding(3);
            tbPageOneTime.Size = new Size(321, 296);
            tbPageOneTime.TabIndex = 0;
            tbPageOneTime.Text = "One Time Payment";
            tbPageOneTime.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPaymentTotal);
            panel1.Controls.Add(btnConfirmPayment);
            panel1.Controls.Add(lblPayHere);
            panel1.Controls.Add(lblAmountDue);
            panel1.Controls.Add(txtBxOneTimePayment);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 284);
            panel1.TabIndex = 5;
            // 
            // lblPaymentTotal
            // 
            lblPaymentTotal.AutoSize = true;
            lblPaymentTotal.Location = new Point(29, 55);
            lblPaymentTotal.Name = "lblPaymentTotal";
            lblPaymentTotal.Size = new Size(106, 15);
            lblPaymentTotal.TabIndex = 0;
            lblPaymentTotal.Text = "Total Amount Due:";
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.AutoSize = true;
            btnConfirmPayment.Location = new Point(141, 179);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(111, 25);
            btnConfirmPayment.TabIndex = 4;
            btnConfirmPayment.Text = "Confirm Payment";
            btnConfirmPayment.UseVisualStyleBackColor = true;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // lblPayHere
            // 
            lblPayHere.AutoSize = true;
            lblPayHere.Location = new Point(29, 132);
            lblPayHere.Name = "lblPayHere";
            lblPayHere.Size = new Size(146, 15);
            lblPayHere.TabIndex = 1;
            lblPayHere.Text = "Enter amount of payment:";
            // 
            // lblAmountDue
            // 
            lblAmountDue.AutoSize = true;
            lblAmountDue.Location = new Point(141, 55);
            lblAmountDue.Name = "lblAmountDue";
            lblAmountDue.Size = new Size(16, 15);
            lblAmountDue.TabIndex = 3;
            lblAmountDue.Text = "...";
            // 
            // txtBxOneTimePayment
            // 
            txtBxOneTimePayment.Location = new Point(29, 150);
            txtBxOneTimePayment.Name = "txtBxOneTimePayment";
            txtBxOneTimePayment.Size = new Size(239, 23);
            txtBxOneTimePayment.TabIndex = 2;
            txtBxOneTimePayment.TextChanged += txtBxOneTimePayment_TextChanged;
            // 
            // tbPageTerm
            // 
            tbPageTerm.Controls.Add(panel2);
            tbPageTerm.Location = new Point(4, 24);
            tbPageTerm.Name = "tbPageTerm";
            tbPageTerm.Padding = new Padding(3);
            tbPageTerm.Size = new Size(321, 296);
            tbPageTerm.TabIndex = 1;
            tbPageTerm.Text = "Term Payment";
            tbPageTerm.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCheck);
            panel2.Controls.Add(lblTermExplanation);
            panel2.Controls.Add(txtBxMonthsToPay);
            panel2.Controls.Add(lblMonthsCount);
            panel2.Controls.Add(lblTermAmountDue);
            panel2.Controls.Add(btnConfirmPaymentTerm);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtBxTermPayment);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 284);
            panel2.TabIndex = 6;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(193, 91);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblTermExplanation
            // 
            lblTermExplanation.AutoSize = true;
            lblTermExplanation.Location = new Point(29, 95);
            lblTermExplanation.Name = "lblTermExplanation";
            lblTermExplanation.Size = new Size(28, 15);
            lblTermExplanation.TabIndex = 7;
            lblTermExplanation.Text = ".......";
            // 
            // txtBxMonthsToPay
            // 
            txtBxMonthsToPay.Location = new Point(193, 44);
            txtBxMonthsToPay.Name = "txtBxMonthsToPay";
            txtBxMonthsToPay.Size = new Size(75, 23);
            txtBxMonthsToPay.TabIndex = 6;
            txtBxMonthsToPay.TextChanged += txtBxMonthsToPay_TextChanged;
            // 
            // lblMonthsCount
            // 
            lblMonthsCount.AutoSize = true;
            lblMonthsCount.Location = new Point(29, 47);
            lblMonthsCount.Name = "lblMonthsCount";
            lblMonthsCount.Size = new Size(158, 15);
            lblMonthsCount.TabIndex = 5;
            lblMonthsCount.Text = "Enter total of months to pay:";
            // 
            // lblTermAmountDue
            // 
            lblTermAmountDue.AutoSize = true;
            lblTermAmountDue.Location = new Point(29, 138);
            lblTermAmountDue.Name = "lblTermAmountDue";
            lblTermAmountDue.Size = new Size(106, 15);
            lblTermAmountDue.TabIndex = 0;
            lblTermAmountDue.Text = "Total Amount Due:";
            // 
            // btnConfirmPaymentTerm
            // 
            btnConfirmPaymentTerm.AutoSize = true;
            btnConfirmPaymentTerm.Location = new Point(141, 227);
            btnConfirmPaymentTerm.Name = "btnConfirmPaymentTerm";
            btnConfirmPaymentTerm.Size = new Size(111, 25);
            btnConfirmPaymentTerm.TabIndex = 4;
            btnConfirmPaymentTerm.Text = "Confirm Payment";
            btnConfirmPaymentTerm.UseVisualStyleBackColor = true;
            btnConfirmPaymentTerm.Click += btnConfirmPaymentTerm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 180);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter amount of payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 138);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 3;
            label3.Text = "...";
            // 
            // txtBxTermPayment
            // 
            txtBxTermPayment.Location = new Point(29, 198);
            txtBxTermPayment.Name = "txtBxTermPayment";
            txtBxTermPayment.Size = new Size(239, 23);
            txtBxTermPayment.TabIndex = 2;
            txtBxTermPayment.TextChanged += txtBxTermPayment_TextChanged;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayment.Location = new Point(87, 15);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(150, 45);
            lblPayment.TabIndex = 0;
            lblPayment.Text = "Payment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 822);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnlChange
            // 
            pnlChange.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChange.Controls.Add(btnOpenReceipt);
            pnlChange.Controls.Add(lblChangeE);
            pnlChange.Controls.Add(lblChange);
            pnlChange.Controls.Add(lblQuote);
            pnlChange.Location = new Point(60, 485);
            pnlChange.Name = "pnlChange";
            pnlChange.Size = new Size(335, 116);
            pnlChange.TabIndex = 5;
            // 
            // btnOpenReceipt
            // 
            btnOpenReceipt.Location = new Point(190, 65);
            btnOpenReceipt.Name = "btnOpenReceipt";
            btnOpenReceipt.Size = new Size(75, 23);
            btnOpenReceipt.TabIndex = 8;
            btnOpenReceipt.Text = "Receipt";
            btnOpenReceipt.UseVisualStyleBackColor = true;
            btnOpenReceipt.Click += btnOpenReceipt_Click;
            // 
            // lblChangeE
            // 
            lblChangeE.AutoSize = true;
            lblChangeE.Location = new Point(76, 28);
            lblChangeE.Name = "lblChangeE";
            lblChangeE.Size = new Size(16, 15);
            lblChangeE.TabIndex = 4;
            lblChangeE.Text = "...";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(19, 28);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(51, 15);
            lblChange.TabIndex = 1;
            lblChange.Text = "Change:";
            // 
            // lblQuote
            // 
            lblQuote.AutoSize = true;
            lblQuote.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuote.Location = new Point(19, 91);
            lblQuote.Name = "lblQuote";
            lblQuote.Size = new Size(294, 15);
            lblQuote.TabIndex = 0;
            lblQuote.Text = "Hope you enjoyed your purchase, please come again!";
            // 
            // btnPaymentCancel
            // 
            btnPaymentCancel.BackColor = Color.Transparent;
            btnPaymentCancel.Location = new Point(12, 4);
            btnPaymentCancel.Name = "btnPaymentCancel";
            btnPaymentCancel.Size = new Size(75, 23);
            btnPaymentCancel.TabIndex = 9;
            btnPaymentCancel.Text = "Cancel";
            btnPaymentCancel.UseVisualStyleBackColor = false;
            btnPaymentCancel.Click += btnPaymentCancel_Click;
            // 
            // PaymentWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 681);
            Controls.Add(btnPaymentCancel);
            Controls.Add(pnlChange);
            Controls.Add(pnlPayment);
            Controls.Add(pictureBox1);
            Name = "PaymentWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PaymentWindow";
            pnlPayment.ResumeLayout(false);
            pnlPayment.PerformLayout();
            tbCtrlPayment.ResumeLayout(false);
            tbPageOneTime.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tbPageTerm.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlChange.ResumeLayout(false);
            pnlChange.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPayment;
        private Label lblPayment;
        private PictureBox pictureBox1;
        private TabControl tbCtrlPayment;
        private TabPage tbPageOneTime;
        private TabPage tbPageTerm;
        private Panel pnlChange;
        private Label lblAmountDue;
        private TextBox txtBxOneTimePayment;
        private Label lblPayHere;
        private Label lblPaymentTotal;
        private Label lblChange;
        private Label lblQuote;
        private Panel panel1;
        private Button btnConfirmPayment;
        private Panel panel2;
        private TextBox txtBxMonthsToPay;
        private Label lblMonthsCount;
        private Label lblTermAmountDue;
        private Button btnConfirmPaymentTerm;
        private Label label2;
        private Label label3;
        private TextBox txtBxTermPayment;
        private Label lblChangeE;
        private Label lblTermExplanation;
        private Button btnOpenReceipt;
        private Button btnPaymentCancel;
        private Button btnCheck;
    }
}