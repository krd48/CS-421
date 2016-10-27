using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor2
{
    public class Evaluator : Visitor
    {
        private Stack<int> Stack = new Stack<int>();

        protected override void Visit(ValueExpression expr)
        {
            Stack.Push(expr.Value);
        }

        protected override void Visit(AddExpression expr)
        {
            Visit(expr.Left);
            Visit(expr.Right);

            var right = Stack.Pop();
            var left = Stack.Pop();
            Stack.Push(left + right);
        }

        protected override void Visit(SubtractExpression expr)
        {
            Visit(expr.Left);
            Visit(expr.Right);

            var right = Stack.Pop();
            var left = Stack.Pop();
            Stack.Push(left - right);
        }

        protected override void Visit(MultiplyExpression expr)
        {
            Visit(expr.Left);
            Visit(expr.Right);

            var right = Stack.Pop();
            var left = Stack.Pop();
            Stack.Push(left * right);
        }

        protected override void Visit(DivideExpression expr)
        {
            Visit(expr.Left);
            Visit(expr.Right);

            var right = Stack.Pop();
            var left = Stack.Pop();
            Stack.Push(left / right);
        }

        public int Result
        {
            get
            {
                return Stack.Pop();
            }
        }

    }
}
