using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_Controller
{
    public class Calculator_Controller
    {
        //private List<string> _Buffer = [];
        public string CurrentNumber { get; set; }
        internal ExpressionBuilder<string> expression = new();

        public void SetOperator(string buttonclicked)
        {
            if (Int32.TryParse(CurrentNumber, out int Number))
            {
                Node<string> value = new(Number.ToString());
                expression.AddNode(value);
            }
            Node<string> operatorvalue = new(buttonclicked);
            expression.AddNode(operatorvalue);
            CurrentNumber = "";
        }

        public static int Divide(int right, int left)
        {
            if (!(left == 0))
            {
                return right / left;
            }
            else
            {
                return 0;
            }

        }

        public static int Multiply(int right, int left) => right * left;

        public static int Subtract(int right, int left) => right - left;

        public static int Sum(int right, int left) => right + left;
        public string CalculateExpression()
        {
            
            var RPNexpression = expression.ConvertToRPN();
            return expression.CalculateRPN(RPNexpression);
        }
        public void InterpetNumber(string button)
        {
            CurrentNumber += button;
        }
        public string GetExpression()
        {
            
            string current = expression.Walk();
            return current + CurrentNumber;
        }
    }
}