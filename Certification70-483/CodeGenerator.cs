using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

namespace Certification70_483
{
    public class CodeGenerator
    {
        public void GenerateDefaultClass(string fileName, string className, string namespaceName)
        {

            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace myNamespace = new CodeNamespace(namespaceName);
            CodeTypeDeclaration myClass = new CodeTypeDeclaration(className)
            {
                Attributes = MemberAttributes.Public | MemberAttributes.Static
            };

            var start = new CodeMemberMethod
            {
                Name = "Start",
                Attributes = MemberAttributes.Public | MemberAttributes.Static
            };
            compileUnit.Namespaces.Add(myNamespace);
            myNamespace.Types.Add(myClass);
            myClass.Members.Add(start);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                IndentedTextWriter tw = new IndentedTextWriter(sw, " ");
                provider.GenerateCodeFromCompileUnit(compileUnit, tw,
                new CodeGeneratorOptions());
                tw.Close();
            }
        }
    }
}
