using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddChiliDataBase
{
    public class DataBaseConnector
    {
        private const string connectionString = @"Server=.\SQLEXPRESS;Database=Chili;Trusted_Connection=yes;";
        
        public void GetChili()
        {
            string query = @"SELECT * FROM Chili.Chili";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                var result = command.ExecuteReader();

                while (result.Read())
                {
                    var chilies = result["Name"];
                }
            }
        }
    }
}
