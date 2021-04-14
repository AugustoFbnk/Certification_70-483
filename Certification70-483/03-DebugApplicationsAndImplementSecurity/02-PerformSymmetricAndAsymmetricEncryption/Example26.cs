using System;
using System.Security;
using System.Security.Permissions;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{
    /// <summary>
    /// Imperative CAS
    /// </summary>
    public class Example26
    {

        public static void Start()
        {
            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Read;
            try
            {
                f.Demand();
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }
        }
    }
}
