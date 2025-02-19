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
    public partial class AccountRecoveryWindow : Form
    {
        public AccountRecoveryWindow()
        {
            InitializeComponent();
        }

        private void btnCheckCredentials_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
            sqlConnection.Open();
            string query = "SELECT COUNT(*) FROM tblAccounts WHERE username=@username AND first_name=@first_name AND last_name=@last_name AND phone=@phone";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", txtBxRecoverUsername.Text);
            command.Parameters.AddWithValue("@first_name", txtBxRecoverFirstName.Text);
            command.Parameters.AddWithValue("@last_name", txtBxRecoverLastName.Text);
            command.Parameters.AddWithValue("@phone", txtBxRecoverPhone.Text);
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();
            if (count > 0)
            {
                lblChangePassword.Visible = true;
                txtBxChangePassword.Visible = true;
                btnRecoverConfirm.Visible = true;
                MessageBox.Show("Credentials Confirmed!");
            }
            else
            {
                MessageBox.Show("Error in Credentials");
            }

        }

        private void btnRecoverConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("UPDATE tblAccounts SET password=@password WHERE phone=@phone", sqlConnection);
            command.Parameters.AddWithValue("@phone", txtBxRecoverPhone.Text);
            command.Parameters.AddWithValue("@password", txtBxChangePassword.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();

            txtBxChangePassword.Text = "";
            MessageBox.Show("Password Change Successful!");
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btnRecoverCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
