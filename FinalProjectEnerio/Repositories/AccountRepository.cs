using FinalProjectEnerio.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEnerio.Repositories
{
    public class AccountRepository
    {
        private readonly string connectionstring = "Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123";

        public List<AccountModel> ReadAccountModel()
        {
            var accountModels = new List<AccountModel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    string query = "SELECT * FROM [dboPCGato].[dbo].[tblAccounts]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AccountModel accountModel = new AccountModel();

                                accountModel.first_name = reader.GetString(0);
                                accountModel.last_name = reader.GetString(1);
                                accountModel.phone = reader.GetString(2);
                                accountModel.email_address = reader.GetString(3);
                                accountModel.address = reader.GetString(4);
                                accountModel.username = reader.GetString(5);
                                accountModel.password = reader.GetString(6);
                                accountModel.gender = reader.GetString(7);
                                accountModel.user_id = reader.GetInt32(8);

                                accountModels.Add(accountModel);
                            }
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return accountModels;
        }

        public void createAccount(AccountModel accountModel)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    string query = "INSERT INTO [dboPCGato].[dbo].[tblAccounts] " +
                        " (first_name, last_name, phone, email_address, address, username, password, gender) VALUES " +
                        " (@first_name, @last_name, @phone, @email_address, @address, @username, @password, @gender)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@first_name", accountModel.first_name);
                        command.Parameters.AddWithValue("@last_name", accountModel.last_name);
                        command.Parameters.AddWithValue("@phone", accountModel.phone);
                        command.Parameters.AddWithValue("@email_address", accountModel.email_address);
                        command.Parameters.AddWithValue("@address", accountModel.address);
                        command.Parameters.AddWithValue("@username", accountModel.username);
                        command.Parameters.AddWithValue("@password", accountModel.password);
                        command.Parameters.AddWithValue("@gender", accountModel.gender);


                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<AccountModel> ReadRegistration()
        {
            var registrationModels = new List<AccountModel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    string query = "SELECT * FROM [dboPCGato].[dbo].[tblAccounts]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AccountModel registrationModel = new AccountModel();

                                registrationModel.username = reader.GetString(0);
                                registrationModel.password = reader.GetString(1);

                                registrationModels.Add(registrationModel);
                            }
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return registrationModels;
        }
    }
}
