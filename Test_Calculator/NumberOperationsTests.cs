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
            NumberOperations operations = new();

            result = operations.InterpetNumber("2", "2");
            Assert.AreEqual("22", result);
        }
        [TestMethod()]
        public void InterpetNumberTestReturnsNumberInCorrectOrder()
        {
            string result;
            NumberOperations operations = new();

            result = operations.InterpetNumber("2", "4");
            Assert.AreEqual("42", result);
        }
        [TestMethod()]
        public void InterpetNumberTestReturnsNumberWithAlotofDigits()
        {
            string result;
            NumberOperations operations = new();

            result = operations.InterpetNumber("2", "987654321");
            Assert.AreEqual("9876543212", result);
        }
    }
}