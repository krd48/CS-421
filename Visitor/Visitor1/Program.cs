using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visitor1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var expr = new AddExpression
            {
                Left = new ValueExpression { Value = 3 },
                Right = new MultiplyExpression
                {
                    Left = new ValueExpression { Value = 2 },
                    Right = new ValueExpression { Value = 7 }
                }
            };

            var printer = new Printer();
            expr.Accept(printer);
            Console.WriteLine();

            var evaluator = new Evaluator();
            expr.Accept(evaluator);
            Console.WriteLine(expr.Value.Value);
        }


    }
}
