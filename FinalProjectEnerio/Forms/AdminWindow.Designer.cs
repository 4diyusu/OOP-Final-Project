namespace FinalProjectEnerio.Forms
{
    partial class AdminWindow
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
            tbCtrlAdminTransactionHistory = new TabControl();
            tbAccounts = new TabPage();
            btnAdminSearch = new Button();
            txtBxUserSearch = new TextBox();
            btnAdminEdit = new Button();
            dtGridViewAccounts = new DataGridView();
            tbProductList = new TabPage();
            btnAdminSearchProduct = new Button();
            txtBxAdminSearchProduct = new TextBox();
            btnAdminEditProductData = new Button();
            dtGridViewProducts = new DataGridView();
            mStripAdmin = new MenuStrip();
            toolStripMenuAdmin = new ToolStripMenuItem();
            toolStripMenuLogout = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            dataGridViewTransactionHistory = new DataGridView();
            tbCtrlAdminTransactionHistory.SuspendLayout();
            tbAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewAccounts).BeginInit();
            tbProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewProducts).BeginInit();
            mStripAdmin.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionHistory).BeginInit();
            SuspendLayout();
            // 
            // tbCtrlAdminTransactionHistory
            // 
            tbCtrlAdminTransactionHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbCtrlAdminTransactionHistory.Controls.Add(tbAccounts);
            tbCtrlAdminTransactionHistory.Controls.Add(tbProductList);
            tbCtrlAdminTransactionHistory.Controls.Add(tabPage1);
            tbCtrlAdminTransactionHistory.Location = new Point(-2, 22);
            tbCtrlAdminTransactionHistory.Name = "tbCtrlAdminTransactionHistory";
            tbCtrlAdminTransactionHistory.SelectedIndex = 0;
            tbCtrlAdminTransactionHistory.Size = new Size(803, 431);
            tbCtrlAdminTransactionHistory.TabIndex = 0;
            // 
            // tbAccounts
            // 
            tbAccounts.Controls.Add(btnAdminSearch);
            tbAccounts.Controls.Add(txtBxUserSearch);
            tbAccounts.Controls.Add(btnAdminEdit);
            tbAccounts.Controls.Add(dtGridViewAccounts);
            tbAccounts.Location = new Point(4, 24);
            tbAccounts.Name = "tbAccounts";
            tbAccounts.Padding = new Padding(3);
            tbAccounts.Size = new Size(795, 403);
            tbAccounts.TabIndex = 0;
            tbAccounts.Text = "Accounts";
            tbAccounts.UseVisualStyleBackColor = true;
            // 
            // btnAdminSearch
            // 
            btnAdminSearch.AutoSize = true;
            btnAdminSearch.Location = new Point(500, 31);
            btnAdminSearch.Name = "btnAdminSearch";
            btnAdminSearch.Size = new Size(78, 25);
            btnAdminSearch.TabIndex = 5;
            btnAdminSearch.Text = "Search User";
            btnAdminSearch.UseVisualStyleBackColor = true;
            btnAdminSearch.Click += btnAdminSearch_Click;
            // 
            // txtBxUserSearch
            // 
            txtBxUserSearch.ForeColor = SystemColors.ScrollBar;
            txtBxUserSearch.Location = new Point(584, 33);
            txtBxUserSearch.Name = "txtBxUserSearch";
            txtBxUserSearch.Size = new Size(202, 23);
            txtBxUserSearch.TabIndex = 4;
            txtBxUserSearch.Text = "Input Phone Number of User";
            // 
            // btnAdminEdit
            // 
            btnAdminEdit.AutoSize = true;
            btnAdminEdit.Location = new Point(10, 31);
            btnAdminEdit.Name = "btnAdminEdit";
            btnAdminEdit.Size = new Size(90, 25);
            btnAdminEdit.TabIndex = 2;
            btnAdminEdit.Text = "Edit User Data";
            btnAdminEdit.UseVisualStyleBackColor = true;
            btnAdminEdit.Click += btnEdit_Click;
            // 
            // dtGridViewAccounts
            // 
            dtGridViewAccounts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtGridViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridViewAccounts.Location = new Point(10, 62);
            dtGridViewAccounts.Name = "dtGridViewAccounts";
            dtGridViewAccounts.Size = new Size(776, 330);
            dtGridViewAccounts.TabIndex = 0;
            dtGridViewAccounts.CellContentClick += dtGridViewAccounts_CellContentClick;
            // 
            // tbProductList
            // 
            tbProductList.Controls.Add(btnAdminSearchProduct);
            tbProductList.Controls.Add(txtBxAdminSearchProduct);
            tbProductList.Controls.Add(btnAdminEditProductData);
            tbProductList.Controls.Add(dtGridViewProducts);
            tbProductList.Location = new Point(4, 24);
            tbProductList.Name = "tbProductList";
            tbProductList.Padding = new Padding(3);
            tbProductList.Size = new Size(795, 403);
            tbProductList.TabIndex = 1;
            tbProductList.Text = "Product List";
            tbProductList.UseVisualStyleBackColor = true;
            // 
            // btnAdminSearchProduct
            // 
            btnAdminSearchProduct.AutoSize = true;
            btnAdminSearchProduct.Location = new Point(481, 31);
            btnAdminSearchProduct.Name = "btnAdminSearchProduct";
            btnAdminSearchProduct.Size = new Size(97, 25);
            btnAdminSearchProduct.TabIndex = 9;
            btnAdminSearchProduct.Text = "Search Product";
            btnAdminSearchProduct.UseVisualStyleBackColor = true;
            btnAdminSearchProduct.Click += btnAdminSearchProduct_Click;
            // 
            // txtBxAdminSearchProduct
            // 
            txtBxAdminSearchProduct.ForeColor = SystemColors.ScrollBar;
            txtBxAdminSearchProduct.Location = new Point(584, 33);
            txtBxAdminSearchProduct.Name = "txtBxAdminSearchProduct";
            txtBxAdminSearchProduct.Size = new Size(202, 23);
            txtBxAdminSearchProduct.TabIndex = 8;
            txtBxAdminSearchProduct.Text = "Input Product Brand";
            // 
            // btnAdminEditProductData
            // 
            btnAdminEditProductData.AutoSize = true;
            btnAdminEditProductData.Location = new Point(10, 31);
            btnAdminEditProductData.Name = "btnAdminEditProductData";
            btnAdminEditProductData.Size = new Size(109, 25);
            btnAdminEditProductData.TabIndex = 7;
            btnAdminEditProductData.Text = "Edit Product Data";
            btnAdminEditProductData.UseVisualStyleBackColor = true;
            btnAdminEditProductData.UseWaitCursor = true;
            btnAdminEditProductData.Click += btnAdminEditProductData_Click;
            // 
            // dtGridViewProducts
            // 
            dtGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridViewProducts.Location = new Point(10, 62);
            dtGridViewProducts.Name = "dtGridViewProducts";
            dtGridViewProducts.Size = new Size(776, 330);
            dtGridViewProducts.TabIndex = 6;
            // 
            // mStripAdmin
            // 
            mStripAdmin.Items.AddRange(new ToolStripItem[] { toolStripMenuAdmin });
            mStripAdmin.Location = new Point(0, 0);
            mStripAdmin.Name = "mStripAdmin";
            mStripAdmin.Size = new Size(800, 24);
            mStripAdmin.TabIndex = 1;
            mStripAdmin.Text = "menuStrip1";
            // 
            // toolStripMenuAdmin
            // 
            toolStripMenuAdmin.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuLogout });
            toolStripMenuAdmin.Name = "toolStripMenuAdmin";
            toolStripMenuAdmin.Size = new Size(55, 20);
            toolStripMenuAdmin.Text = "Admin";
            // 
            // toolStripMenuLogout
            // 
            toolStripMenuLogout.Name = "toolStripMenuLogout";
            toolStripMenuLogout.Size = new Size(112, 22);
            toolStripMenuLogout.Text = "Logout";
            toolStripMenuLogout.Click += accountToolStripMenuItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewTransactionHistory);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 403);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Customer Transaction History";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTransactionHistory
            // 
            dataGridViewTransactionHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactionHistory.Location = new Point(6, 55);
            dataGridViewTransactionHistory.Name = "dataGridViewTransactionHistory";
            dataGridViewTransactionHistory.Size = new Size(786, 342);
            dataGridViewTransactionHistory.TabIndex = 0;
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbCtrlAdminTransactionHistory);
            Controls.Add(mStripAdmin);
            Name = "AdminWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Window";
            tbCtrlAdminTransactionHistory.ResumeLayout(false);
            tbAccounts.ResumeLayout(false);
            tbAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewAccounts).EndInit();
            tbProductList.ResumeLayout(false);
            tbProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewProducts).EndInit();
            mStripAdmin.ResumeLayout(false);
            mStripAdmin.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactionHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbCtrlAdminTransactionHistory;
        private TabPage tbAccounts;
        private TabPage tbProductList;
        private Button btnAdminEdit;
        private DataGridView dtGridViewAccounts;
        private MenuStrip mStripAdmin;
        private ToolStripMenuItem toolStripMenuAdmin;
        private ToolStripMenuItem toolStripMenuLogout;
        private Button btnAdminSearch;
        private TextBox txtBxUserSearch;
        private Button btnAdminSearchProduct;
        private TextBox txtBxAdminSearchProduct;
        private Button btnAdminEditProductData;
        private DataGridView dtGridViewProducts;
        private TabPage tabPage1;
        private DataGridView dataGridViewTransactionHistory;
    }
}