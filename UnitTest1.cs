using System;
using Xunit;
using Challenge_DIO;

namespace TestCalc
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "14/09/2023";
            Calculadora calc = new Calculadora("14/09/2023");

            return calc;
        }

        [Theory]
        [InlineData (4, 3, 7)]
        [InlineData (2, 3, 5)]
        public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(8, 3, 5)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(5, 3, 15)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Theory]
        [InlineData(12, 3, 4)]
        [InlineData(15, 3, 5)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = construirClasse();

            int resultadoCalc = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalc);
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.somar(2, 3);
            calc.somar(3, 4);
            calc.somar(4, 5);
            calc.somar(5, 6);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
