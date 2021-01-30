using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace Certification70_483._02_CreateAndUseTypes.CreateTypes
{
    /// <summary>
    /// Using the is and as operators
    /// </summary>
    public static class Example27
    {
        public static void Start()
        {
            OpenConnection(new SqlConnection());
            LogStream(new MemoryStream());
        }

        static void OpenConnection(DbConnection connection)
        {
            if (connection is SqlConnection)
            {

            }
        }
        static void LogStream(Stream stream)
        {
            MemoryStream memoryStream = stream as MemoryStream;
            if (memoryStream != null)
            {

            }
        }
    }
}
