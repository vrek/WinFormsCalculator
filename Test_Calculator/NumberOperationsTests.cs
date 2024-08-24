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
    public class NumberOperationsTests
    {
        [TestMethod()]
        public void InterpetNumberTest()
        {
            string result;
            Calculator_Controller operations = new();
            operations.InterpetNumber("2");
            operations.InterpetNumber("2");
            result = operations.CurrentNumber;
            Assert.AreEqual("22", result);
        }
        [TestMethod()]
        public void InterpetNumberTestReturnsNumberInCorrectOrder()
        {
            string result;
            Calculator_Controller operations = new();
            operations.InterpetNumber("2");
            operations.InterpetNumber("4");
            result = operations.CurrentNumber;
            Assert.AreEqual("24", result);
        }
        [TestMethod()]
        public void InterpetNumberTestReturnsNumberWithAlotofDigits()
        {
            string result;
            Calculator_Controller operations = new();
            operations.InterpetNumber("9");
            operations.InterpetNumber("8");
            operations.InterpetNumber("7");
            operations.InterpetNumber("6");
            operations.InterpetNumber("5");
            operations.InterpetNumber("4");
            operations.InterpetNumber("3");
            operations.InterpetNumber("2");
            operations.InterpetNumber("1");
            result = operations.CurrentNumber;
            Assert.AreEqual("987654321", result);
        }
        [TestMethod()]
        public void InterpetNumberTestReturnsString()
        {
            string result;
            Calculator_Controller operations = new();
            operations.InterpetNumber("2");
            operations.InterpetNumber("2");
            result = operations.CurrentNumber;
            Assert.IsInstanceOfType(result,typeof(string));
        }
    }
}