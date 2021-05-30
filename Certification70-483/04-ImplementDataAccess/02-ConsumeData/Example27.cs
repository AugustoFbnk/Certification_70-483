using System.Data.SqlClient;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{
    /// <summary>
    ///  SqlConnection with a using statement to automatically close it
    /// </summary>
    public class Example27
    {
        public static void Start()
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Certification70_483._03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.common.ShopContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execute operations against the database
            } // Connection is automatically closed. 

        }
    }
}
