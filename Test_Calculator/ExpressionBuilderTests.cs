using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator_Controller.Tests
{
    [TestClass()]
    public class ExpressionBuilderTests
    {
        [TestMethod()]
        public void WithA2andPlusAnd5ruturns2plus5Test()
        {
            ExpressionBuilder<string> expression = new();
            Node<string> value = new("2");
            expression.AddNode(value);
            value = new("+");
            expression.AddNode(value);
            value = new("5");
            expression.AddNode(value);

            Assert.AreEqual("2+5", expression.Walk());
        }

        [TestMethod()]
        public void Add1NodeResultsIn1NodeTest()
        {
            ExpressionBuilder<string> expression = new();
            Node<string> value = new("5");
            expression.AddNode(value);

            Assert.AreEqual(1, expression.Count);
        }
        [TestMethod()]
        public void Add2NodesResultsIn2NodeTest()
        {
            ExpressionBuilder<string> expression = new();
            Node<string> value = new("5");
            expression.AddNode(value);
            value = new("3");
            expression.AddNode(value);

            Assert.AreEqual(2, expression.Count);
        }

        [TestMethod()]
        public void ConvertToRPNTest()
        {
            ExpressionBuilder<string> expression = new();
            Queue<string> expected = [];
            expected.Enqueue("2");
            expected.Enqueue("5");
            expected.Enqueue("+");

            Node<string> value = new("2");
            expression.AddNode(value);
            value = new("+");
            expression.AddNode(value);
            value = new("5");
            expression.AddNode(value);
            
            Assert.AreEqual(expected, expression.ConvertToRPN());
        }
        //[TestMethod()]
        //public void ConvertToRPNShouldFailTest()
        //{
        //    ExpressionBuilder<string> expression = new();
        //    Queue<string> expected = [];
        //    expected.Enqueue("2");
        //    expected.Enqueue("5");
        //    expected.Enqueue("add");

        //    Node<string> value = new("2");
        //    expression.AddNode(value);
        //    value = new("+");
        //    expression.AddNode(value);
        //    value = new("5");
        //    expression.AddNode(value);

        //    Assert.IsFalse(expected == expression);
        //}
    }
}