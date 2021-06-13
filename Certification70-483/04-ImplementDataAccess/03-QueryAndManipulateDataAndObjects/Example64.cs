using Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.common;
using System;

namespace Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects
{
    /// <summary>
    /// Sample XML
    /// </summary>
    public class Example64
    {
        public static void Start()
        {
            var sampleXml = new SampleXml().ReturnSampleXml();
            Console.WriteLine(sampleXml);
        }
    }
}
