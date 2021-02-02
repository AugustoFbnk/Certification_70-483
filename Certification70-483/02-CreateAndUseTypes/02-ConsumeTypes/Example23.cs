using System;
using System.IO;

namespace Certification70_483._02_CreateAndUseTypes._02_ConsumeTypes
{
    /// <summary>
    /// Explicitly casting a base type to a derived type
    /// </summary>
    public static class Example23
    {
        public static void Start()
        {
            Object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;
        }
    }
}
