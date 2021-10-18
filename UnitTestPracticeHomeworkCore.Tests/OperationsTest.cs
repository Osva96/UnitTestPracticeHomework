using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestPracticeHomework;

namespace UnitTestPracticeHomeworkCore.Tests
{
    [TestClass]
    public class OperationsTest
    {
        [TestMethod]
        public void TestSumSum()
        {
            // Arrange
            var sumTwoNumbers = new Operations();
            double[] numbers = { 4, 17 };
            string[] operators = { "+" };
            double expectedResult = 21;

            // Act
            var actualResult = sumTwoNumbers.DoOperation(numbers, operators);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSumSumResult()
        {
            // Arrange
            var sumTwoNumbers = new Operations();
            double[] numbers = { 2, 8, 4 };
            string[] operators = { "+", "*" };
            double expectedResult = 40;

            // Act
            var actualResult = sumTwoNumbers.DoOperation(numbers, operators);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestDivRestSum()
        {
            // Arrange
            var sumTwoNumbers = new Operations();
            double[] numbers = { 15, 3, 25, 50 };
            string[] operators = { "/", "-", "+" };
            double expectedResult = 30;

            // Act
            var actualResult = sumTwoNumbers.DoOperation(numbers, operators);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestRestSumDivResultSum()
        {
            // Arrange
            var sumTwoNumbers = new Operations();
            double[] numbers = { 67, 12, 5, 3, 2, 30 };
            string[] operators = { "-", "+", "/", "*", "+" };
            double expectedResult = 70;

            // Act
            var actualResult = sumTwoNumbers.DoOperation(numbers, operators);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestErrorOperator()
        {
            // Arrange
            var sumTwoNumbers = new Operations();
            double[] numbers = { 67, 12, 5, 3, 2, 30 };
            string[] operators = { "-", "+", "/", "*", "?" };
            double expectedResult = 0;

            // Act
            var actualResult = sumTwoNumbers.DoOperation(numbers, operators);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMissingOperator()
        {
            // Arrange
            var sumTwoNumbers = new Operations();
            double[] numbers = { 67, 12, 5, 4, 2 };
            string[] operators = { "-", "+", "/" };
            double expectedResult = 0;

            // Act
            var actualResult = sumTwoNumbers.DoOperation(numbers, operators);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestExtraOperator()
        {
            // Arrange
            var sumTwoNumbers = new Operations();
            double[] numbers = { 67, 12, 5, 4, 2 };
            string[] operators = { "-", "+", "/", "+", "*" };
            double expectedResult = 0;

            // Act
            var actualResult = sumTwoNumbers.DoOperation(numbers, operators);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
