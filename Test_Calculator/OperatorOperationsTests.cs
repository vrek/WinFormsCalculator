using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_Controller.Tests
{
    [TestClass()]
    public class OperatorOperationsTests
    {
        [TestMethod()]
        public void When_given_2_and_2_Sum_returns_4()
        {
            //Arrange
            int result;
            //Act
            result = Calculator_Controller.Sum(2, 2);
            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void When_given_2_and_0_Divide_returns_0()
        {
            //Arrange
            int result;
            //Act
            result = Calculator_Controller.Divide(2, 0);
            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void When_given_2_and_add_with_3_returns_5()
        {
            Calculator_Controller ops = new Calculator_Controller();
            string result;
            ops.InterpetNumber("2");
            ops.SetOperator("+");
            ops.InterpetNumber("3");


            result = ops.CalculateExpression();

            Assert.AreEqual("5", result);

        }
        [TestMethod()]
        public void When_given_buffer_containing_2_and_add_and_5_and_add_with_3_as_currentValue_returns_10()
        {
            Calculator_Controller ops = new Calculator_Controller();
            string result;
            List<string> buffer = new List<string>();
            buffer.Add("2");
            buffer.Add("+");
            buffer.Add("5");
            buffer.Add("+");

            result = ops.CalculateExpression();

            Assert.AreEqual("10", result);

        }
        [TestMethod()]
        public void When_given_buffer_containing_2_and_add_and_5_and_multiply_with_3_as_currentValue_returns_17()
        {
            Calculator_Controller ops = new Calculator_Controller();
            string result;
            string currentValue = "3";
            List<string> buffer = new List<string>();
            buffer.Add("2");
            buffer.Add("+");
            buffer.Add("5");
            buffer.Add("*");

            result = ops.CalculateExpression();

            Assert.AreEqual("17", result);

        }
        [TestMethod()]
        public void When_given_buffer_containing_20_and_add_and_150_and_multiply_with_3_as_currentValue_returns_470()
        {
            Calculator_Controller ops = new Calculator_Controller();
            string result;
            string currentValue = "3";
            List<string> buffer = new List<string>();
            buffer.Add("20");
            buffer.Add("+");
            buffer.Add("150");
            buffer.Add("*");

            result = ops.CalculateExpression();

            Assert.AreEqual("470", result);
        }
        [TestMethod()]
        public void When_given__buffer_with_2_plus_8_in_in_parans_and_multiply_with_3_as_currentValue_returns_30()
        {
            Calculator_Controller ops = new Calculator_Controller();
            string result;
            string currentValue = "3";
            List<string> buffer = new();
            buffer.Add("(");
            buffer.Add("2");
            buffer.Add("+");
            buffer.Add("8");
            buffer.Add(")");
            buffer.Add("*");

            result = ops.CalculateExpression();

            Assert.AreEqual("30", result);

        }
    }
}