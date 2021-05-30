namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{

    /// <summary>
    /// Don’t manually concatenate strings to form a file path
    /// </summary>
    public class Example11
    {

        public static void Start()
        {
            string folder = @"C:\temp";
            string fileName = "test.dat";
            string fullPath = folder + fileName;
        }
    }
}
