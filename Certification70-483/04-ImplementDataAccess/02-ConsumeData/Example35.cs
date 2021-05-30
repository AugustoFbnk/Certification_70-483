using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{
    /// <summary>
    /// Inserting values with a parameterized query
    /// </summary>
    public class Example35
    {

        public async static void Start()
        {
            await InsertRowWithParameterizedQuery();
        }

        public static async Task InsertRowWithParameterizedQuery()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO People([FirstName], [LastName], [MiddleName]) VALUES(@firstName, @lastName, @middleName)",
                    connection);
                await connection.OpenAsync();

                command.Parameters.AddWithValue("@firstName", "John");
                command.Parameters.AddWithValue("@lastName", "Doe");
                command.Parameters.AddWithValue("@middleName", "Little");
                int numberOfInsertedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Inserted {0} rows", numberOfInsertedRows);
            }
        }
    }
}
