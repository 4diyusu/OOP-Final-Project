using FinalProjectEnerio.Components.ProductNamespace;
using FinalProjectEnerio.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEnerio.Repositories
{
    public class ProductRepository
    {
        
        private readonly string connectionstring = "Data Source=DESKTOP-KAEPC\\SQLEXPRESS;Initial Catalog=dboPCGato;Persist Security Info=True;User ID=sa;Password=kevin123";

        public List<ProductModel> ReadProductModel()
        {
            var productModels = new List<ProductModel>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();

                    string query = "SELECT * FROM [dboPCGato].[dbo].[tblProducts]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ProductModel productModel = new ProductModel();

                                productModel.product_id = reader.GetInt32(0);
                                productModel.product_brand = reader.GetString(1);
                                productModel.product_name = reader.GetString(2);
                                productModel.product_price = reader.GetInt32(3);
                                

                                productModels.Add(productModel);
                            }
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return productModels;
        }

    }
}

