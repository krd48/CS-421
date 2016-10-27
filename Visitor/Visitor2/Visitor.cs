using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor2
{
    public abstract class Visitor
    {
        public void Visit(Expression expr)
        {
            switch (expr.Type)
            {
                case ExpressionType.Value:
                    Visit((ValueExpression)expr);
                    break;
                case ExpressionType.Add:
                    Visit((AddExpression)expr);
                    break;
                case ExpressionType.Subtract:
                    Visit((SubtractExpression)expr);
                    break;
                case ExpressionType.Multiply:
                    Visit((MultiplyExpression)expr);
                    break;
                case ExpressionType.Divide:
                    Visit((DivideExpression)expr);
                    break;
                default:
                    // Throw?
                    break;
            }
        }

        protected abstract void Visit(ValueExpression expr);
        protected abstract void Visit(AddExpression expr);
        protected abstract void Visit(SubtractExpression expr);
        protected abstract void Visit(MultiplyExpression expr);
        protected abstract void Visit(DivideExpression expr);
    }


}
