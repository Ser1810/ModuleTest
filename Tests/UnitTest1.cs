using ModuleTest;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test3()
        {
            // Arrange
            double a = 1;
            double b = 0;
            double c = 1;
            var expected = Array.Empty<double>();
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act
            var actual = quadraticEquation.Solve(a, b, c);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5()
        {
            // Arrange
            double a = 1;
            double b = 0;
            double c = -1;
            var expected = new double[] { 1, -1};
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act
            var actual = quadraticEquation.Solve(a, b, c);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test7()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 1;
            var expected = new double[] { -1 };
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act
            var actual = quadraticEquation.Solve(a, b, c);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test9()
        {
            // Arrange
            double a = double.Epsilon;
            double b = 2;
            double c = 1;
            var expected = new Exception("Коэффициент a не может быть равен 0");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test11()
        {
            // Arrange
            double a = -0.000000000001;
            double b = 0.000000000002;
            double c = 0.24;
            var expected = new double[] { -4.8989694855765623E-19 };
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act
            var actual = quadraticEquation.Solve(a, b, c);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test13_a_NegativeInfinity()
        {
            // Arrange
            double a = double.NegativeInfinity;
            double b = 1;
            double c = 1;
            var expected = new Exception("Коэффициенты не могут быть NegativeInfinity");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test13_b_NegativeInfinity()
        {
            // Arrange
            double a = 1;
            double b = double.NegativeInfinity;
            double c = 1;
            var expected = new Exception("Коэффициенты не могут быть NegativeInfinity");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test13_c_NegativeInfinity()
        {
            // Arrange
            double a = 1;
            double b = 1;
            double c = double.NegativeInfinity;
            var expected = new Exception("Коэффициенты не могут быть NegativeInfinity");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test13_a_PositiveInfinity()
        {
            // Arrange
            double a = double.PositiveInfinity;
            double b = 1;
            double c = 1;
            var expected = new Exception("Коэффициенты не могут быть PositiveInfinity");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test13_b_PositiveInfinity()
        {
            // Arrange
            double a = 1;
            double b = double.PositiveInfinity;
            double c = 1;
            var expected = new Exception("Коэффициенты не могут быть PositiveInfinity");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test13_c_PositiveInfinity()
        {
            // Arrange
            double a = 1;
            double b = 1;
            double c = double.PositiveInfinity;
            var expected = new Exception("Коэффициенты не могут быть PositiveInfinity");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test13_a_NaN()
        {
            // Arrange
            double a = double.NaN;
            double b = 1;
            double c = 1;
            var expected = new Exception("Коэффициенты не могут быть NaN");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test13_b_NaN()
        {
            // Arrange
            double a = 1;
            double b = double.NaN;
            double c = 1;
            var expected = new Exception("Коэффициенты не могут быть NaN");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void Test13_c_NaN()
        {
            // Arrange
            double a = 1;
            double b = 1;
            double c = double.NaN;
            var expected = new Exception("Коэффициенты не могут быть NaN");
            QuadraticEquation quadraticEquation = new QuadraticEquation();

            // Act && Assert
            var actual = Assert.ThrowsException<Exception>(() => quadraticEquation.Solve(a, b, c));

            Assert.AreEqual(expected.Message, actual.Message);
        }

        [TestMethod]
        public void MainTest()
        {
            QuadraticEquation.Main();
        }
    }
}