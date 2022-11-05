using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using Xunit;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RightAddwithintegers()
        {
            int x = 4;
            int y = 3;
            double expected = 7;
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightAddwithdoubles()
        {
            double x = 2.5;
            double y = 3.5;
            double expected = 6;
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Maxvalueadddouble()
        {
            double x = double.MaxValue;
            double y = 3;
            double expected = double.MaxValue;
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Addintegerswithminus()
        {
            double x = -5;
            double y = -8;
            double expected = -13;
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddWithError()
        {
            double x = 5;
            double y = 8;
            double expected = 12;
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RightSubtractwithintegers()
        {
            int x = 4;
            int y = 3;
            double expected = 1;
            //Act
            double actual = Calculator.Subtract(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightSubtractwithdoubles()
        {
            double x = 2;
            double y = 3;
            double expected = -1;
            //Act
            double actual = Calculator.Subtract(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxvalueSubtractdouble()
        {
            double x = double.MaxValue;
            double y = 3;
            double expected = double.MaxValue;
            //Act
            double actual = Calculator.Subtract(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtractintegerswithminus()
        {
            double x = -5;
            double y = -8;
            double expected = 3;
            //Act
            double actual = Calculator.Subtract(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractWithError()
        {
            double x = 5;
            double y = 8;
            double expected = 12;
            //Act
            double actual = Calculator.Subtract(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RightMultiplywithintegers()
        {
            int x = 4;
            int y = 4;
            double expected = 16;
            //Act
            double actual = Calculator.Multiply(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightMultiplywithdoubles()
        {
            double x = 17.7;
            double y = 0;
            double expected = 0;
            //Act
            double actual = Calculator.Multiply(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxvalueMultiplydouble()
        {
            double x = double.MaxValue;
            double y = 3;
            double expected = double.MaxValue;
            //Act
            double actual = Calculator.Subtract(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplyintegerswithminus()
        {
            double x = -5;
            double y = -5;
            double expected = 25;
            //Act
            double actual = Calculator.Multiply(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyWithError()
        {
            double x = 5;
            double y = 8;
            double expected = 12;
            //Act
            double actual = Calculator.Multiply(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightDividewithintegers()
        {
            int x = 4;
            int y = 4;
            double expected = 1;
            //Act
            double actual = Calculator.Divide(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RightDividewithdoubles()
        {
            double x = 17.7;
            double y = 0;
            double expected = 0;
            //Act
            double actual = Calculator.Divide(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MaxvalueDividedouble()
        {
            double x = double.MaxValue;
            double y = 3;
            double expected = double.MaxValue;
            //Act
            double actual = Calculator.Divide(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Divideintegerswithminus()
        {
            double x = -500;
            double y = -500;
            double expected = 1;
            //Act
            double actual = Calculator.Divide(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideWithError()
        {
            double x = 5;
            double y = 8;
            double expected = 12;
            //Act
            double actual = Calculator.Divide(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
