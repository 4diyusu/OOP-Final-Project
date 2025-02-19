using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectEnerio.Models;

namespace FinalProjectEnerio.Repositories
{
    public class CartRepository
    {
        private readonly string connectionstring = "Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123";
        /*
        public List<CartModel> ReadCartModel()
        {
            var cart = new List<CartModel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    string query = "SELECT transaction_id, transaction_time, product_name, quantity, price FROM [dboPCGato].[dbo].[dboTransactionHistory]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CartModel cartItems = new CartModel
                                {
                                    transaction_id = reader.GetInt32(0),
                                    product_name = reader.GetString(1),
                                    quantity = reader.GetInt32(2),
                                    price = reader.GetInt32(3),
                                };

                                cart.Add(cartItems);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cart;

        }*/
    }
}
