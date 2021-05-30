using System.IO;
using System.Security.AccessControl;

namespace Certification70_483._04_ImplementDataAccess._01_PerformIOOperations
{
    /// <summary>
    /// Setting access control for a directory
    /// </summary>
    public class Example04
    {

        public static void Start()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("TestDirectory");
            directoryInfo.Create();
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(
             new FileSystemAccessRule("everyone",
             FileSystemRights.ReadAndExecute,
             AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }
    }
}
