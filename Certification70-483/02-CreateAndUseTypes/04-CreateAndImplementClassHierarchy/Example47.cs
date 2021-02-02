using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification70_483._02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy
{
    /// <summary>
    /// Overriding a virtual method
    /// </summary>
    public static class Example47
    {
        public static void Start()
        {
            var derived = new Derived();
            derived.CallExecute();
        }
    }

    class Base
    {
        protected virtual void Execute()
        { }
    }
    class Derived : Base
    {
        public void CallExecute()
        {
            Execute();
        }
        protected override void Execute()
        {
            Log("Before executing");
            base.Execute();
            Log("After executing");
        }
        private void Log(string message) { /* some logging code */ }
    }
}
