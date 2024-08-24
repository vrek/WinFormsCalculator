using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator_Controller
{
    public class ExpressionBuilder <T>
    {
        public Node<T>? First { get; private set; }
        public Node<T>? Last{get; private set;}
        public int Count { get; private set;}

        //enum Enum_Operators
        //    {multiply,
        //     divide,
        //     add,
        //     subtract                
        //    }

        public ExpressionBuilder()
        {
            this.Count = 0;
            this.First = null;
            this.Last = null;
        }

        public void AddNode(Node<T> newNode)
        {
            if (this.Count == 0)
            {
                this.First =newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }

        public void RemoveNode(Node<T> NodeBeforeRemoved)
        {
            if (NodeBeforeRemoved.Next == this.Last)
            {
                this.Last = NodeBeforeRemoved;
            }
            else if (NodeBeforeRemoved == this.Last)
            {
                throw new InvalidOperationException();
            }
            else
            {
                NodeBeforeRemoved.Next = NodeBeforeRemoved.Next.Next;
            }
        }

        public Queue<string> ConvertToRPN()
        {
            
            Stack<string> operators = new();
            Queue<string> output = new();
            Node<T> CurrentNode;
            string CurrentData;
            if (this.Count > 0)
            {
                CurrentNode = this.First;
                do
                {
                    CurrentData = CurrentNode.Data;
                    if (Int32.TryParse(CurrentData, out _))
                    {
                        output.Enqueue(CurrentData);
                    }
                    else if (CurrentData == "+" || CurrentData == "-")
                    {
                        string topstack = operators.Peek();
                        if (topstack == "*" || topstack == "/")
                        {
                            output.Enqueue(operators.Pop());
                            operators.Push(CurrentData);
                        }
                    }
                    else if (CurrentData == "*" || CurrentData == "/")
                    {
                        operators.Push(CurrentData);
                    }
                    else if (CurrentData == "(")
                    {
                        operators.Push(CurrentData);
                    }
                    else if (CurrentData == ")") {
                        string topstack = "";
                        while (topstack != "(")
                        {
                            topstack = operators.Peek();
                            output.Enqueue(operators.Pop());
                        } 
                    }
                    CurrentNode = CurrentNode.Next;
                } while (CurrentNode.Next != null);
                while (operators.Count > 0)
                {
                    output.Enqueue(operators.Pop());
                }
            }
            return output;
        }
        public string CalculateRPN(Queue<string>expression)
        {
            //Calculator_Controller controller = new();
            string CurrentData;
            Stack<string> output = new();
            while (expression.Count > 0)
            {
                CurrentData = expression.Dequeue();
                int firstOperand;
                int secondOperand;
                if (Int32.TryParse(CurrentData, out _))
                {
                    output.Push(CurrentData);
                }
                else if (CurrentData == "*") 
                {
                    Int32.TryParse(expression.Dequeue(),out firstOperand);
                    Int32.TryParse(expression.Dequeue(), out secondOperand);
                    string result = Calculator_Controller.Multiply(firstOperand, secondOperand).ToString();
                    expression.Enqueue(result);
                }
                else if (CurrentData == "/")
                {
                    Int32.TryParse(expression.Dequeue(), out firstOperand);
                    Int32.TryParse(expression.Dequeue(), out secondOperand);
                    string result = Calculator_Controller.Multiply(firstOperand, secondOperand).ToString();
                    expression.Enqueue(result);
                }
                else if (CurrentData == "+")
                {
                    Int32.TryParse(expression.Dequeue(), out firstOperand);
                    Int32.TryParse(expression.Dequeue(), out secondOperand);
                    string result = Calculator_Controller.Multiply(firstOperand, secondOperand).ToString();
                    expression.Enqueue(result);
                }
                else if (CurrentData == "-")
                {
                    Int32.TryParse(expression.Dequeue(), out firstOperand);
                    Int32.TryParse(expression.Dequeue(), out secondOperand);
                    string result = Calculator_Controller.Multiply(firstOperand, secondOperand).ToString();
                    expression.Enqueue(result);
                }
            }
            return expression.First();
        }

        public string Walk()
        {
            Node<T> CurrentNode;
            string Result = "";
            CurrentNode = this.First;
            while (CurrentNode != null) {
                Result += CurrentNode.Data;
                CurrentNode = CurrentNode.Next;
            }
            return Result;
        }
    }
}
