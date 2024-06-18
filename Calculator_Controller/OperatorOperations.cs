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
            int rightvalue = 0;
            int leftvalue = 0;
            string operatorSymbol = "";
            foreach (var item in _Buffer.Select((value, index) => (value, index)))
            {
                if (item.value == "*" || item.value == "/")
                {
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
                    rightvalue = SubQuerry((int)rightvalue, (int)leftvalue, operatorSymbol);
                    _Buffer[item.index - 1] = rightvalue.ToString();
                    _Buffer.Remove(leftvalue.ToString());
                    _Buffer.Remove(item.value);
                    return _Buffer;
                }
            }
            foreach (var item in _Buffer.Select((value, index) => (value, index)))
            {
                if (item.value == "+" || item.value == "-")
                {
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
                    rightvalue = SubQuerry((int)rightvalue, (int)leftvalue, operatorSymbol);
                    _Buffer[item.index - 1] = rightvalue.ToString();
                    _Buffer.Remove(leftvalue.ToString());
                    _Buffer.Remove(item.value);
                    return _Buffer;
                }
            }
            return _Buffer;
        }


        private int SubQuerry(int rightvalue, int leftvalue, string operatorSymbol)
        {
            int result;
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
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}