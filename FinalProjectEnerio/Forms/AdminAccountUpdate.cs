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
    public partial class AdminAccountUpdate : Form
    {
        public AdminAccountUpdate()
        {
            InitializeComponent();
        }

        private void btnAECancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.ShowDialog();
            this.Close();
        }

        private void btnAEConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE tblAccounts SET first_name=@first_name, last_name=@last_name, phone=@phone, email_address=@email_address," +
                                                "address=@address, username=@username, password=@password, gender=@gender WHERE user_id=@user_id", sqlConnection);
            command.Parameters.AddWithValue("@user_id", int.Parse(txtBxAEUserID.Text));
            command.Parameters.AddWithValue("@first_name", txtBxAEFirstName.Text);
            command.Parameters.AddWithValue("@last_name", txtBxAELastName.Text);
            command.Parameters.AddWithValue("@phone", txtBxAEPhone.Text);
            command.Parameters.AddWithValue("@email_address", txtBxAEEmail.Text);
            command.Parameters.AddWithValue("@address", txtBxAEAddress.Text);
            command.Parameters.AddWithValue("@username", txtBxAEUsername.Text);
            command.Parameters.AddWithValue("@password", txtBxAEPassword.Text);
            command.Parameters.AddWithValue("@gender", txtBxAEGender.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();

            txtBxAEFirstName.Text = "";
            txtBxAELastName.Text = "";
            txtBxAEPhone.Text = "";
            txtBxAEEmail.Text = "";
            txtBxAEAddress.Text = "";
            txtBxAEUsername.Text = "";
            txtBxAEPassword.Text = "";
            txtBxAEGender.Text = "";

            MessageBox.Show("Account Update Successful!");
            this.Hide();
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.ShowDialog();
            this.Close();
        }

        private void txtBxAEUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("DELETE tblAccounts WHERE user_id=@user_id", sqlConnection);
            command.Parameters.AddWithValue("@user_id", int.Parse(txtBxAEUserID.Text));

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete user?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Account Successfully Deleted!");
                this.Hide();
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
