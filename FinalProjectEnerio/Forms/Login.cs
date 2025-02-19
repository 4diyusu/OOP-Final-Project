using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectEnerio.Models;
using FinalProjectEnerio.Repositories;

namespace FinalProjectEnerio.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void lLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
            this.Close();
        }

        private void btnConfirmLogin_Click(object sender, EventArgs e)
        {
            string username = txtBxLoginUsername.Text;
            string password = txtBxLoginPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                this.Hide();
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.ShowDialog();
                this.Close();
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
                sqlConnection.Open();
                string query = "SELECT COUNT(*) FROM tblAccounts WHERE username=@username AND password=@password";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@username", txtBxLoginUsername.Text);
                command.Parameters.AddWithValue("@password", txtBxLoginPassword.Text);
                int count = (int)command.ExecuteScalar();
                sqlConnection.Close();
                if (count > 0)
                {
                    MessageBox.Show("Login Success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    CustomerMainWindow customerMainWindow = new CustomerMainWindow();
                    customerMainWindow.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error in Login","Error!");
                }
            }
        }

        private void lLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
            this.Close();
        }

        private void cBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBxLoginPassword.PasswordChar = cBoxPassword.Checked ? '\0' : '*';
        }

        private void lLblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AccountRecoveryWindow accountRecoveryWindow = new AccountRecoveryWindow();
            accountRecoveryWindow.ShowDialog();
            this.Close();
        }

    }
}
