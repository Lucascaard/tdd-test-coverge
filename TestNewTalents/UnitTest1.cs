using NewTalents;
using System;
using Xunit;

namespace TestNewTalents
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(2, 4, 6)]
		[InlineData(3, 5, 8)]
		[InlineData(50, 62, 112)]
		public void TestSomar(int val1, int val2, int result)
		{
			Calculadora calc = Calculadora.GetInstance();

			int resultadoCalc = calc.Somar(val1, val2);

			Assert.Equal(result, resultadoCalc);
		}

		[Theory]
		[InlineData(8, 4, 2)]
		[InlineData(50, 5, 10)]
		[InlineData(50, 10, 5)]
		public void TestDividir(int val1, int val2, int result)
		{
			Calculadora calc = Calculadora.GetInstance();

			int resultadoCalc = calc.Dividir(val1, val2);

			Assert.Equal(result, resultadoCalc);
		}

		[Theory]
		[InlineData(6, 4, 2)]
		[InlineData(16, 5, 11)]
		[InlineData(500, 62, 438)]
		public void TestSubtrair(int val1, int val2, int result)
		{
			Calculadora calc = Calculadora.GetInstance();

			int resultadoCalc = calc.Subtrair(val1, val2);

			Assert.Equal(result, resultadoCalc);
		}

		[Theory]
		[InlineData(2, 4, 8)]
		[InlineData(3, 5, 15)]
		[InlineData(50, 5, 250)]
		public void TestMultiplicar(int val1, int val2, int result)
		{
			Calculadora calc = Calculadora.GetInstance();

			int resultadoCalc = calc.Multiplicar(val1, val2);

			Assert.Equal(result, resultadoCalc);
		}

		[Fact]
		public void TestarDivisaoPorZero()
		{
			Calculadora calc = Calculadora.GetInstance();

			Assert.Throws<DivideByZeroException>( () => calc.Dividir(3, 0) );
		}

		[Fact]
		public void TestarHistorico()
		{
			Calculadora calc = Calculadora.GetInstance();

			calc.Somar(2, 4);
			calc.Somar(2, 4);
			calc.Somar(2, 4);
			calc.Somar(2, 4);

			Assert.NotEmpty(calc.Hitorico());
		}

		[Fact]
		public void TestExemplo()
		{
			Calculadora calc = Calculadora.GetInstance();
			bool value = true;

			bool resp = calc.Exemplo(value);
			bool resp2 = calc.Exemplo(!value);
			Assert.True(resp);
			Assert.False(resp2);

		}
	}
}
