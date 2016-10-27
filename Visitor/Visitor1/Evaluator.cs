using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor1
{
    public class Evaluator : IVisitor
    {
        public void Visit(ValueExpression expr)
        {
            // Do nothing
        }

        public void Visit(AddExpression expr)
        {
            if (expr.Left.Value.HasValue && expr.Right.Value.HasValue)
            {
                expr.Value = expr.Left.Value.Value + expr.Right.Value.Value;
            }
        }

        public void Visit(SubtractExpression expr)
        {
            if (expr.Left.Value.HasValue && expr.Right.Value.HasValue)
            {
                expr.Value = expr.Left.Value.Value - expr.Right.Value.Value;
            }
        }

        public void Visit(MultiplyExpression expr)
        {
            if (expr.Left.Value.HasValue && expr.Right.Value.HasValue)
            {
                expr.Value = expr.Left.Value.Value * expr.Right.Value.Value;
            }
        }

        public void Visit(DivideExpression expr)
        {
            if (expr.Left.Value.HasValue && expr.Right.Value.HasValue)
            {
                expr.Value = expr.Left.Value.Value / expr.Right.Value.Value;
            }
        }
    }
}
