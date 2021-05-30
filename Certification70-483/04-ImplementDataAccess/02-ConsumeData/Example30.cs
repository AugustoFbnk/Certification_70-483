using System.Configuration;
using System.Data.SqlClient;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{
    /// <summary>
    /// Using a connection string from an external configuration file
    /// </summary>
    public class Example30
    {
        public static void Start()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }
    }
}
