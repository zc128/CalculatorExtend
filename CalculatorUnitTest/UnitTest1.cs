using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethodWithTwoPositiveNumbers()
        {
            Calculator cal = new Calculator();
            string z = "a";
            double x = 2.0;
            double y = 3.0;
            double answer = x + y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestAddMethodWithTwoNegativeNumbers()
        {
            Calculator cal = new Calculator();
            string z = "a";
            double x = -2.0;
            double y = -3.0;
            double answer = x + y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestSubtractMethodWithTwoPositiveNumbers()
        {
            Calculator cal = new Calculator();
            string z = "s";
            double x = 2.0;
            double y = 3.0;
            double answer = x - y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestSubtractMethodWithTwoNegativeNumbers()
        {
            Calculator cal = new Calculator();
            string z = "s";
            double x = -2.0;
            double y = -3.0;
            double answer = x - y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestMultiplyMethodWithTwoPositiveNumbers()
        {
            Calculator cal = new Calculator();
            string z = "m";
            double x = 2.0;
            double y = 3.0;
            double answer = x * y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestMultiplyMethodWithTwoNegativeNumbers()
        {
            Calculator cal = new Calculator();
            string z = "m";
            double x = -2.0;
            double y = -3.0;
            double answer = x * y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestDivideMethodWithTwoPositiveNumbers()
        {
            Calculator cal = new Calculator();
            string z = "d";
            double x = 2.0;
            double y = 3.0;
            double answer = x / y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestDivideMethodWithTwoNegativeNumbers()
        {
            Calculator cal = new Calculator();
            string z = "d";
            double x = -2.0;
            double y = -3.0;
            double answer = x / y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestMultiplyMethodWithPositiveNumberAndZero()
        {
            Calculator cal = new Calculator();
            string z = "m";
            double x = 2.0;
            double y = 0.0;
            double answer = x * y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void TestDivideMethodWithZeroAsDividendAndPositiveNumber()
        {
            Calculator cal = new Calculator();
            string z = "d";
            double x = 0.0;
            double y = 3.0;
            double answer = x / y;
            double methodReturn = cal.DoOperation(x, y, z);
            Assert.AreEqual(answer, methodReturn);
        }
    }
}
