using System;
using System.Linq.Expressions;

namespace Certification70_483._02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection
{
    /// <summary>
    /// Creating “Hello World!” with an expression tree
    /// </summary>
    public static class Example78
    {
        public static void Start()
        {
            BlockExpression blockExpr = Expression.Block(
                Expression.Call(null,
                typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
                Expression.Constant("Hello ")
                ),
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
                    Expression.Constant("World!")
                )
            );
            Expression.Lambda<Action>(blockExpr).Compile()();
        }
    }
}
