using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProjectEnerio.Forms
{
    public partial class AdminProductUpdate : Form
    {
        public AdminProductUpdate()
        {
            InitializeComponent();
        }

        private void btnExitProductUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.ShowDialog();
            this.Close();
        }

        private void btnConfirmProductUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE tblProducts SET product_name=@product_name, product_price=@product_price, WHERE product_id=@product_id", sqlConnection);
            command.Parameters.AddWithValue("@product_id", int.Parse(txtBxProductID.Text));
            command.Parameters.AddWithValue("@product_name", txtBxProductName.Text);
            command.Parameters.AddWithValue("@product_price", txtBxProductPrice.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();

            txtBxProductID.Text = "";
            txtBxProductName.Text = "";
            txtBxProductPrice.Text = "";

            MessageBox.Show("Product Update Successful!");
            this.Hide();
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.ShowDialog();
            this.Close();
        }
    }
}
