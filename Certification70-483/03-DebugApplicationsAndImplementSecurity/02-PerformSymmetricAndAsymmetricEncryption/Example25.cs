using System.Security.Permissions;

namespace Certification70_483._03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption
{
    /// <summary>
    /// Declarative CAS
    /// </summary>
    public class Example25
    {

        public static void Start()
        {
            DeclarativeCAS();
        }

        [FileIOPermission(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Read)]
        public static void DeclarativeCAS()
        {
        }
    }
}
