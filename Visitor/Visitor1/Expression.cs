using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor1
{

    public abstract class Expression 
    {
        public int? Value { get; set; }
        public abstract void Accept(IVisitor visitor);
    }

    public class ValueExpression : Expression
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class AddExpression : Expression
    {
        public Expression Left { get; set; }
        public Expression Right { get; set; }

        public override void Accept(IVisitor visitor)
        {
            Left.Accept(visitor);
            visitor.Visit(this);
            Right.Accept(visitor);
        }
    }

    public class SubtractExpression : Expression
    {
        public Expression Left { get; set; }
        public Expression Right { get; set; }

        public override void Accept(IVisitor visitor)
        {
            Left.Accept(visitor);
            visitor.Visit(this);
            Right.Accept(visitor);
        }
    }

    public class MultiplyExpression : Expression
    {
        public Expression Left { get; set; }
        public Expression Right { get; set; }

        public override void Accept(IVisitor visitor)
        {
            Left.Accept(visitor);
            visitor.Visit(this);
            Right.Accept(visitor);
        }
    }

    public class DivideExpression : Expression
    {
        public Expression Left { get; set; }
        public Expression Right { get; set; }

        public override void Accept(IVisitor visitor)
        {
            Left.Accept(visitor);
            visitor.Visit(this);
            Right.Accept(visitor);
        }
    }

}
