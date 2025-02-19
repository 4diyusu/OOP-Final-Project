using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace FinalProjectEnerio.Forms
{

    public partial class PaymentWindow : Form
    {

        public PaymentWindow()
        {
            InitializeComponent();

            //_adminWindow = adminTransactionHistory;
        }


        public void SetLabelText(string text)
        {
            lblAmountDue.Text = text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmPaymentTerm_Click(object sender, EventArgs e)
        {
            double interest = .1;
            double term;
            double perterm_payment;
            double total_perterm_payment;
            double amount_due;
            double downpayment;
            double change;

            downpayment = Convert.ToDouble(txtBxTermPayment.Text);
            term = Convert.ToDouble(txtBxMonthsToPay.Text);
            amount_due = Convert.ToDouble(lblAmountDue.Text);
            perterm_payment = (amount_due / term);
            total_perterm_payment = perterm_payment + (perterm_payment * interest);
            amount_due = total_perterm_payment;

            change = downpayment - amount_due;

            if (change < 0)
            {
                MessageBox.Show("Payment must be above the amount due.", "Error");
            }
            else
            {
                change = Math.Round(change, 2);
                lblChangeE.Text = Convert.ToString(change);
                MessageBox.Show("Payment Success!", "Payment Received");
                MessageBox.Show("Receipt Saved!", "Receipt");

                /*
                int transaction_id = 0;
                DateTime transaction_time;
                double price = amount_due;
                int quantity = 0;
                string product_name = "";


                _adminWindow.AddTransaction(
                    transaction_id,
                    transaction_time = DateTime.Now,
                    product_name,
                    quantity,
                    price
                );*/
                
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {

            double amount_due;
            double payment;
            double change;

            amount_due = Convert.ToDouble(lblAmountDue.Text);
            payment = Convert.ToDouble(txtBxOneTimePayment.Text);
            change = payment - amount_due;
            if (change < 0)
            {
                MessageBox.Show("Payment must be above the amount due.", "Error");
            }
            else
            {
                change = Math.Round(change, 2);
                lblChangeE.Text = Convert.ToString(change);
                MessageBox.Show("Payment Success!", "Payment Received");
                MessageBox.Show("Receipt Saved!", "Receipt");

                /*
                int transaction_id = 0;
                DateTime transaction_time;
                double price = amount_due;
                int quantity = 0;
                string product_name = "";


                _adminWindow.AddTransaction(
                    transaction_id,
                    transaction_time = DateTime.Now,
                    product_name,
                    quantity, 
                    price
                );*/
            }
        }

        private void btnOpenReceipt_Click(object sender, EventArgs e)
        {
            string directoryPath = @"S:\Visual Studio Projects\FinalProjectEnerio\Receipts";

            var latestReceipt = Directory.GetFiles(directoryPath, "receipt_*.txt")
                                          .OrderByDescending(f => File.GetCreationTime(f))
                                          .FirstOrDefault();

            if (latestReceipt != null)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = latestReceipt,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening the receipt: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("No receipt found.", "Error");
            }
        }

        private void btnPaymentCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMainWindow customerMainWindow = new CustomerMainWindow();
            customerMainWindow.ShowDialog();
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double interest = .1;
            double term;
            double perterm_payment;
            double total_perterm_payment;
            double amount_due;

            term = Convert.ToDouble(txtBxMonthsToPay.Text);
            amount_due = Convert.ToDouble(lblAmountDue.Text);
            perterm_payment = (amount_due / term);
            total_perterm_payment = perterm_payment + (perterm_payment * interest);

            total_perterm_payment = Math.Round(total_perterm_payment, 2);
            lblTermExplanation.Text = Convert.ToString(total_perterm_payment);
        }

        private void txtBxMonthsToPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBxMonthsToPay.Text, out _))
                {
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxMonthsToPay.Clear(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBxTermPayment_TextChanged(object sender, EventArgs e)
        {
            /*
            string product_name = ;

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123");
            sqlConnection.Open();
            string query = "SELECT COUNT(*) FROM tblTransactionHistory WHERE username=@username AND password=@password";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", txtBxLoginUsername.Text);
            command.Parameters.AddWithValue("@password", txtBxLoginPassword.Text);
            int count = (int)command.ExecuteScalar();
            sqlConnection.Close();


            try
            {
                if (!int.TryParse(txtBxTermPayment.Text, out _))
                {
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxTermPayment.Clear(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void txtBxOneTimePayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBxOneTimePayment.Text, out _))
                {
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBxOneTimePayment.Clear(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
