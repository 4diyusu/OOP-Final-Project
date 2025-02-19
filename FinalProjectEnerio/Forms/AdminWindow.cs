using FinalProjectEnerio.Repositories;
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
using System.Data.Common;
using System.Data.Sql;

namespace FinalProjectEnerio.Forms
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();

            ReadRegistrationModel();
            ReadProductsModel();
        }

        public void ReadRegistrationModel()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("User ID");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Email Address");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Password");
            dataTable.Columns.Add("Gender");

            var repo = new AccountRepository();
            var accountModels = repo.ReadAccountModel();

            foreach (var accountModel in accountModels)
            {
                var row = dataTable.NewRow();

                row["User ID"] = accountModel.user_id;
                row["First Name"] = accountModel.first_name;
                row["Last Name"] = accountModel.last_name;
                row["Phone"] = accountModel.phone;
                row["Email Address"] = accountModel.email_address;
                row["Address"] = accountModel.address;
                row["Username"] = accountModel.username;
                row["Password"] = accountModel.password;
                row["Gender"] = accountModel.gender;

                dataTable.Rows.Add(row);

            }

            this.dtGridViewAccounts.DataSource = dataTable;
        }

        public void ReadProductsModel()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Product Price");
            dataTable.Columns.Add("Product ID");
            dataTable.Columns.Add("Product Brand");

            var repo = new ProductRepository();
            var productModels = repo.ReadProductModel();

            foreach (var productModel in productModels)
            {
                var row = dataTable.NewRow();

                row["Product Name"] = productModel.product_name;
                row["Product Price"] = productModel.product_price;
                row["Product ID"] = productModel.product_id;
                row["Product Brand"] = productModel.product_brand;

                dataTable.Rows.Add(row);

            }

            this.dtGridViewProducts.DataSource = dataTable;
        }

        public void ReadTransactionHistory()
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123"))
                {
                    connection.Open();

                    string query = "SELECT [transaction_id], [transaction_time], [product_name], [quantity], [price] FROM [dboPCGato].[dbo].[tblTransactionHistory]";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                dataGridViewTransactionHistory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction data: " + ex.Message);
            }
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            ReadTransactionHistory();
        }

        public void AddTransaction(int transaction_id, DateTime transaction_time, string product_name, int quantity, double price)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123"))
                {
                    connection.Open();
                    string query = @"INSERT INTO [dboPCGato].[dbo].[tblTransactionHistory]
                             ([transaction_id], [transaction_time], [product_name], [quantity], [price])
                             VALUES (@transaction_id, @transaction_time, @product_name, @quantity, @price)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@transaction_id", transaction_id);
                        cmd.Parameters.AddWithValue("@transaction_time", transaction_time);
                        cmd.Parameters.AddWithValue("@product_name", product_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@price", price);

                        cmd.ExecuteNonQuery();
                    }
                }

                ReadTransactionHistory();

                MessageBox.Show("Transaction read successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting transaction: " + ex.Message);
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminAccountUpdate adminAccountUpdate = new AdminAccountUpdate();
            adminAccountUpdate.ShowDialog();
            this.Close();
        }

        private void dtGridViewAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdminEditProductData_Click(object sender, EventArgs e)
        {
            AdminProductUpdate adminProductUpdate = new AdminProductUpdate();
            adminProductUpdate.ShowDialog();
            this.Close();
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM tblAccounts WHERE phone=@phone", sqlConnection);
            command.Parameters.AddWithValue("@phone", txtBxUserSearch.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtGridViewAccounts.DataSource = dataTable;
        }

        private void btnAdminSearchProduct_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM tblProducts WHERE product_brand=@product_brand", sqlConnection);
            command.Parameters.AddWithValue("@product_brand", txtBxAdminSearchProduct.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dtGridViewProducts.DataSource = dataTable;
        }

    }
}
