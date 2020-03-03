using Teste;
using Xunit;

namespace XUnitTestProject1
{
    public class TestesCalculadora
    {
        [Theory]
        [InlineData(2,5,7)]
        [InlineData(3,9,12)]
        [InlineData(3,-3,0)]
       
        public void TestaSoma(int number1, int number2, int resultado)
        {
            int resultadoSoma = Calculadora.Soma(number1, number2);

            Assert.Equal(resultado, resultadoSoma);
        }
        [Fact]

        public void TestSomaFact()
        {
            int result = Calculadora.Soma(7, 8);
            Assert.Equal(15, result);
        }

        [Theory]
        [InlineData(2, 5, -3)]
        [InlineData(3, 9, -6)]
        [InlineData(3, -3, 6)]
        public void TestaSubtrai(int number1, int number2, int resultado)
        {
            int resultadoSoma = Calculadora.Subtrai(number1, number2);

            Assert.Equal(resultado, resultadoSoma);
        }
        [Fact]
        public void TestSubtraiFact()
        {
            int result = Calculadora.Subtrai(8, 15);

            Assert.Equal(-7, result);
        }
    }
}
