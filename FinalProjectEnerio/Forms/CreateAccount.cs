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
using FinalProjectEnerio.Models;
using FinalProjectEnerio.Repositories;

namespace FinalProjectEnerio.Forms
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            AccountModel accountModel = new AccountModel();

            accountModel.first_name = txtBxFirstName.Text;
            accountModel.last_name = txtBxLastName.Text;
            accountModel.phone = txtBxPhone.Text;
            accountModel.email_address = txtBxEmail.Text;
            accountModel.address = txtBxAddress.Text;
            accountModel.username = txtBxUsernameSignup.Text;
            accountModel.password = txtBxPasswordSignup.Text;
            accountModel.gender = cBxGender.Text;


            var repo = new AccountRepository();
            repo.createAccount(accountModel);


            MessageBox.Show("Account Succesfully Created! \nPlease Proceed to the Login Page.");
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            this.Close();
        }
    }
}
