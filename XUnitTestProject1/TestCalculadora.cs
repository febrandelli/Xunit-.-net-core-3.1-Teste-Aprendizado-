using Moq;
using Teste;
using Xunit;

namespace XUnitTestProject1
{
    public class TestesCalculadora
    {
        [Fact]
        void TestAdd()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Add(2, 2)).Returns(4);
            Assert.Equal(4, calculator.Object.Add(2, 2));
        }

        [Theory]
        [InlineData(2, 5, 8)]
        [InlineData(3, 9, 12)]
        [InlineData(3, -3, 0)]

        void TestAddTheory(int number1, int number2, decimal result)
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Add(number1, number2)).Returns(result);
            Assert.Equal(result, calculator.Object.Add(number1, number2));
        }

        [Fact]
        void TestSubtraction()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Subtraction(7, 2)).Returns(5);
            Assert.Equal(5, calculator.Object.Subtraction(7, 2));
        }

        [Theory]
        [InlineData(25, 5, 20)]
        [InlineData(3, 9, -6)]
        [InlineData(3, -3, 6)]

        void TestSubtractionTheory(int number1, int number2, decimal result)
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Subtraction(number1, number2)).Returns(result);
            Assert.Equal(result, calculator.Object.Subtraction(number1, number2));
        }

        [Fact]
        void TestDivision()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Division(7, 2)).Returns(3.5m);
            Assert.Equal(3.5m, calculator.Object.Division(7, 2));
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(3, 10, 0.3)]
        [InlineData(3, -3, -1)]

        void TestDivisionTheory(int number1, int number2, decimal result)
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Division(number1, number2)).Returns(result);
            Assert.Equal(result, calculator.Object.Division(number1, number2));
        }

        [Fact]
        void TestMultiplication()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Multiplication(7, 2)).Returns(14);
            Assert.Equal(14, calculator.Object.Multiplication(7, 2));
        }

        [Theory]
        [InlineData(25, 5, 125)]
        [InlineData(3, 10, 30)]
        [InlineData(3, -3, -9)]

        void TestMultiplicationTheory(int number1, int number2, decimal result)
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(c => c.Multiplication(number1, number2)).Returns(result);
            Assert.Equal(result, calculator.Object.Multiplication(number1, number2));
        }


    }
}
