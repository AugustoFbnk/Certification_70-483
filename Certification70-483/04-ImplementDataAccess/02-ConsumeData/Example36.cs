using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;

namespace Certification70_483._04_ImplementDataAccess._02_ConsumeData
{

    /// <summary>
    ///Using a TransactionScope
    /// </summary>
    public class Example36
    {

        public static void Start()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command1 = new SqlCommand(
                        "INSERT INTO People ([FirstName], [LastName], [MiddleName]) VALUES('John', 'Doe', null)",

                        connection);
                    SqlCommand command2 = new SqlCommand(
                        "INSERT INTO People ([FirstName], [LastName], [MiddleName]) VALUES('Jane', 'Doe', null)",

                        connection);
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
                transactionScope.Complete();
            }
        }
    }
}
