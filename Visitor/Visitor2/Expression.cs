using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor2
{

    public enum ExpressionType
    {
        Value,
        Add,
        Subtract,
        Multiply,
        Divide
    }


    public abstract class Expression 
    {
        protected Expression(ExpressionType type)
        {
            Type = type;
        }

        public ExpressionType Type { get; private set; }
    }

    public class ValueExpression : Expression
    {
        public ValueExpression()
            : base(ExpressionType.Value)
        {
        }

        public int Value { get; set; }
    }

    public class AddExpression : Expression
    {
        public AddExpression()
            : base(ExpressionType.Add)
        {
        }

        public Expression Left { get; set; }
        public Expression Right { get; set; }
    }

    public class SubtractExpression : Expression
    {
        public SubtractExpression()
            : base(ExpressionType.Subtract)
        {
        }

        public Expression Left { get; set; }
        public Expression Right { get; set; }
    }

    public class MultiplyExpression : Expression
    {
        public MultiplyExpression()
            : base(ExpressionType.Multiply)
        {
        }

        public Expression Left { get; set; }
        public Expression Right { get; set; }
    }

    public class DivideExpression : Expression
    {
        public DivideExpression()
            : base(ExpressionType.Divide)
        {
        }

        public Expression Left { get; set; }
        public Expression Right { get; set; }
    }

}
