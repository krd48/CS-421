using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor1
{
    public interface IVisitor
    {
        void Visit(ValueExpression expr);
        void Visit(AddExpression expr);
        void Visit(SubtractExpression expr);
        void Visit(MultiplyExpression expr);
        void Visit(DivideExpression expr);
    }


}
