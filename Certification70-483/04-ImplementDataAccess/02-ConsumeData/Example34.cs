using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{
    /// <summary>
    /// Updating rows with ExecuteNonQuery
    /// </summary>
    public class Example34
    {
        public static async void Start()
        {
            await UpdateRows();
        }

        public static async Task UpdateRows()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE People SET FirstName='John'",
                    connection);
                await connection.OpenAsync();
                int numberOfUpdatedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Updated {0} rows", numberOfUpdatedRows);
            }
        }
    }
}
