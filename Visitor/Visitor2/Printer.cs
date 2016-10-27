using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor2
{
    public class Printer : Visitor
    {
        protected override void Visit(ValueExpression expr)
        {
            Console.Write(expr.Value);
        }

        protected override void Visit(AddExpression expr)
        {
            Console.Write("(");
            Visit(expr.Left);
            Console.Write(" + ");
            Visit(expr.Right);
            Console.Write(")");
        }

        protected override void Visit(SubtractExpression expr)
        {
            Console.Write("(");
            Visit(expr.Left);
            Console.Write(" - ");
            Visit(expr.Right);
            Console.Write(")");
        }

        protected override void Visit(MultiplyExpression expr)
        {
            Console.Write("(");
            Visit(expr.Left);
            Console.Write(" * ");
            Visit(expr.Right);
            Console.Write(")");
        }

        protected override void Visit(DivideExpression expr)
        {
            Console.Write("(");
            Visit(expr.Left);
            Console.Write(" / ");
            Visit(expr.Right);
            Console.Write(")");
        }
    }
}
