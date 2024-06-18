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

        public int Divide(int right, int left)
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

        public int Multiply(int right, int left)
        {
            return right * left;
        }

        public int Subtract(int right, int left)
        {
            return right - left;
        }

        public int Sum(int right, int left)
        {
            return right + left;
        }
        public string CalculateExpression(List<String> _Buffer, string currentValue)
        {
            _Buffer.Add(currentValue);
            List<string> _Expression = new();
            while (_Buffer.Count() >= 3)
            {
                _Buffer = ExpressionSolver(_Buffer);
            }
            return _Buffer[0].ToString();
        }
        private List<string> ExpressionSolver(List<string> _Buffer)
        {
            foreach (var item in _Buffer.Select((value, index) => (value, index)))
            {
                List<string> _Expression = new();
                if (item.value == "(")
                {
                    foreach (var InnerItem in _Buffer.Select((value, index) => (value, index)))
                    {
                        if (item.value != ")")
                        {
                            _Expression.Add(InnerItem.value);
                        }
                        else
                        {
                            ExpressionSolver(_Expression);
                        }
                    }
                }
            }
            foreach (var item in _Buffer.Select((value, index) => (value, index)))
            {
                if (item.value == "*" || item.value == "/")
                {
                    return Calculate(_Buffer, item);
                }
            }
            foreach (var item in _Buffer.Select((value, index) => (value, index)))
            {
                if (item.value == "+" || item.value == "-")
                {
                    return Calculate(_Buffer, item);
                }
            }
            return _Buffer;
        }
        private List<string> Calculate(List<string> _Buffer, (string value, int index) item)
        {
            int rightvalue = 0;
            int leftvalue = 0;
            string operatorSymbol = "";
            operatorSymbol = item.value;
            var item2 = _Buffer[item.index - 1];
            if (!Int32.TryParse(item2, out rightvalue))
            {
                throw new Exception();
            }
            var item3 = _Buffer[item.index + 1];
            if (!Int32.TryParse(item3, out leftvalue))
            {
                throw new Exception();
            }
            switch (operatorSymbol)
            {
                case ("+"):
                    rightvalue = Sum(rightvalue, leftvalue);
                    break;
                case ("-"):
                    rightvalue = Subtract(rightvalue, leftvalue);
                    break;
                case ("*"):
                    rightvalue = Multiply(rightvalue, leftvalue);
                    break;
                case ("/"):
                    rightvalue = Divide(rightvalue, leftvalue);
                    break;
                default:
                    rightvalue = 0;
                    break;
            }
            _Buffer[item.index - 1] = rightvalue.ToString();
            _Buffer.Remove(leftvalue.ToString());
            _Buffer.Remove(item.value);
            return _Buffer;
        }
    }
}