using System;
using Xunit.Sdk;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.common
{
    public class CategoryAttribute : Attribute, ITraitAttribute
    {
        public CategoryAttribute(string value)
        { }
    }
}
