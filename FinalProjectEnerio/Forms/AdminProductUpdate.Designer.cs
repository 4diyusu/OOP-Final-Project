namespace FinalProjectEnerio.Forms
{
    partial class AdminProductUpdate
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
            btnConfirmProductUpdate = new Button();
            lblProductName = new Label();
            lblAdminUpdateProduct = new Label();
            lblProductPrice = new Label();
            lblProductId = new Label();
            txtBxProductID = new TextBox();
            txtBxProductName = new TextBox();
            txtBxProductPrice = new TextBox();
            btnExitProductUpdate = new Button();
            lblProductUpdateNote = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfirmProductUpdate
            // 
            btnConfirmProductUpdate.Location = new Point(302, 261);
            btnConfirmProductUpdate.Name = "btnConfirmProductUpdate";
            btnConfirmProductUpdate.Size = new Size(75, 23);
            btnConfirmProductUpdate.TabIndex = 0;
            btnConfirmProductUpdate.Text = "Confirm";
            btnConfirmProductUpdate.UseVisualStyleBackColor = true;
            btnConfirmProductUpdate.Click += btnConfirmProductUpdate_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(84, 137);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            // 
            // lblAdminUpdateProduct
            // 
            lblAdminUpdateProduct.AutoSize = true;
            lblAdminUpdateProduct.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminUpdateProduct.Location = new Point(12, 9);
            lblAdminUpdateProduct.Name = "lblAdminUpdateProduct";
            lblAdminUpdateProduct.Size = new Size(304, 45);
            lblAdminUpdateProduct.TabIndex = 19;
            lblAdminUpdateProduct.Text = "UPDATE PRODUCT";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(90, 189);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(78, 15);
            lblProductPrice.TabIndex = 20;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(105, 87);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(63, 15);
            lblProductId.TabIndex = 21;
            lblProductId.Text = "Product ID";
            // 
            // txtBxProductID
            // 
            txtBxProductID.Location = new Point(174, 84);
            txtBxProductID.Name = "txtBxProductID";
            txtBxProductID.Size = new Size(203, 23);
            txtBxProductID.TabIndex = 22;
            // 
            // txtBxProductName
            // 
            txtBxProductName.Location = new Point(174, 134);
            txtBxProductName.Name = "txtBxProductName";
            txtBxProductName.Size = new Size(203, 23);
            txtBxProductName.TabIndex = 23;
            // 
            // txtBxProductPrice
            // 
            txtBxProductPrice.Location = new Point(174, 186);
            txtBxProductPrice.Name = "txtBxProductPrice";
            txtBxProductPrice.Size = new Size(203, 23);
            txtBxProductPrice.TabIndex = 24;
            // 
            // btnExitProductUpdate
            // 
            btnExitProductUpdate.Location = new Point(174, 261);
            btnExitProductUpdate.Name = "btnExitProductUpdate";
            btnExitProductUpdate.Size = new Size(75, 23);
            btnExitProductUpdate.TabIndex = 25;
            btnExitProductUpdate.Text = "Cancel";
            btnExitProductUpdate.UseVisualStyleBackColor = true;
            btnExitProductUpdate.Click += btnExitProductUpdate_Click;
            // 
            // lblProductUpdateNote
            // 
            lblProductUpdateNote.AutoSize = true;
            lblProductUpdateNote.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductUpdateNote.Location = new Point(12, 220);
            lblProductUpdateNote.Name = "lblProductUpdateNote";
            lblProductUpdateNote.Size = new Size(62, 30);
            lblProductUpdateNote.TabIndex = 26;
            lblProductUpdateNote.Text = "Note";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 250);
            label1.Name = "label1";
            label1.Size = new Size(130, 45);
            label1.TabIndex = 27;
            label1.Text = "Admin will have to \r\nmanually change price \r\nin GUI too.";
            // 
            // AdminProductUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 309);
            Controls.Add(label1);
            Controls.Add(lblProductUpdateNote);
            Controls.Add(btnExitProductUpdate);
            Controls.Add(txtBxProductPrice);
            Controls.Add(txtBxProductName);
            Controls.Add(txtBxProductID);
            Controls.Add(lblProductId);
            Controls.Add(lblProductPrice);
            Controls.Add(lblAdminUpdateProduct);
            Controls.Add(lblProductName);
            Controls.Add(btnConfirmProductUpdate);
            Name = "AdminProductUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProductUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmProductUpdate;
        private Label lblProductName;
        private Label lblAdminUpdateProduct;
        private Label lblProductPrice;
        private Label lblProductId;
        private TextBox txtBxProductID;
        private TextBox txtBxProductName;
        private TextBox txtBxProductPrice;
        private Button btnExitProductUpdate;
        private Label lblProductUpdateNote;
        private Label label1;
    }
}