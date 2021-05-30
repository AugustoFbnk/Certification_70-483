using System.Data.SqlClient;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{
    /// <summary>
    /// Creating a connection string with SqlConnectionStringBuilder
    /// </summary>
    public class Example28
    {
        public static void Start()
        {
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = @"(localdb)\v11.0";
            sqlConnectionStringBuilder.InitialCatalog = "ProgrammingInCSharp";
            string connectionString = sqlConnectionStringBuilder.ToString();
        }
    }
}
