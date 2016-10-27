using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor1
{
    public class Printer : IVisitor
    {
        public void Visit(ValueExpression expr)
        {
            Console.Write(expr.Value);
        }

        public void Visit(AddExpression expr)
        {
            Console.Write(" + ");
        }

        public void Visit(SubtractExpression expr)
        {
            Console.Write(" - ");
        }

        public void Visit(MultiplyExpression expr)
        {
            Console.Write(" * ");
        }

        public void Visit(DivideExpression expr)
        {
            Console.Write(" / ");
        }
    }
}
