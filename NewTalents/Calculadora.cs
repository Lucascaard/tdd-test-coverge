using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
	public class Calculadora
	{
		private static Calculadora instance;
		public static Calculadora GetInstance()
		{
			if (instance == null)
			{
				instance = new Calculadora();
			}
			return instance;
		}

		private List<string> ListaHistorico;
		public Calculadora()
		{
			ListaHistorico = new List<string>();
		}

		public int Somar(int num1, int num2)
		{
			int res = num1 + num2;
			ListaHistorico.Insert(0, "Res: " + res);
			return res;
		}

		public int Dividir(int num1, int num2)
		{
			int res = num1 / num2;
			ListaHistorico.Insert(0, "Res: " + res);
			return res;
		}

		public int Multiplicar(int num1, int num2)
		{
			int res = num1 * num2;
			ListaHistorico.Insert(0, "Res: " + res);
			return res;
		}

		public int Subtrair(int num1, int num2)
		{
			int res = num1 - num2;
			ListaHistorico.Insert(0, "Res: " + res);
			return res;
		}

		public List<string> Hitorico()
		{
			ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
			return ListaHistorico;
		}

		public bool Exemplo(bool value)
		{
			if (value)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
