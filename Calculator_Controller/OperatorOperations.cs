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
    public class OperatorOperations
    {
        public List<string> SetOperator(List<string> buffer, string buttonclicked, string currentValue)
        {
            buffer.Add(currentValue);
            buffer.Add(buttonclicked);
            return buffer;
        }

        private int Divide(int right, int left)
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

        private int Multiply(int right, int left)
        {
            return right * left;
        }

        private int Subtract(int right, int left)
        {
            return right - left;
        }

        public int Sum(int right, int left)
        {
            return right + left;
        }
        public string calculateExpression(List<String> _Buffer, string currentValue)
        {
            int result = 0;
            int rightvalue = 0;
            int leftvalue = 0;
            string operatorSymbol = "";
            _Buffer.Add(currentValue);
            foreach (var item in _Buffer)
            {
                if (Int32.TryParse(item, out int number) && rightvalue == 0)
                {
                    rightvalue = number;
                }
                else if (Int32.TryParse(item, out number))
                {
                    leftvalue = number;
                }
                else
                {
                    operatorSymbol = item;
                }
            }
            switch (operatorSymbol)
            {
                case ("+"):
                    result = Sum(rightvalue, leftvalue);
                    break;
                case ("-"):
                    result = Subtract(rightvalue, leftvalue);
                    break;
                case ("*"):
                    result = Multiply(rightvalue, leftvalue);
                    break;
                case ("/"):
                    result = Divide(rightvalue, leftvalue);
                    break;
            }
            return result.ToString();
        }
    }
}
