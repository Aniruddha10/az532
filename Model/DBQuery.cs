using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace WebApplication1.Model
{
    public class DBQuery
    {
        public List<ProductModel> Data
        {
            get
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                List<ProductModel> pm = new List<ProductModel>();

                //builder.DataSource = "caazuretestdbserver.database.windows.net";
                builder.DataSource = "caazuretestdbserver.database.windows.net";
                builder.UserID = "azuretestadmin";
                builder.Password = "Password@$";
                builder.InitialCatalog = "AzureTestDB";
                // builder.ConnectionString = "Server=tcp:caazuretestdbserver.database.windows.net,1433;Initial Catalog=AzureTestDB;Persist Security Info=False;User ID=azuretestadmin;Password=Password@$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                using (SqlConnection con = new SqlConnection(builder.ConnectionString))
                {
                    con.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select * from SalesLT.ProductModel");

                    using (SqlCommand cmd = new SqlCommand(sb.ToString(), con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            string s;
                            while(dr.Read())
                             pm.Add(new ProductModel() { ModelId = dr.GetInt32(0), ModelName = dr.GetString(1)});
                        }
                    }
                }

                return pm;

            }
        }
    }
}
