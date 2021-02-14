using System;
using System.Collections.Generic;
using System.Text;

namespace DividerExample
{
    public static class Divider
    {
		/// <summary>
		/// Метод за делене на две цели числа
		/// </summary>
		/// <param name="x">Числител</param>
		/// <param name="y">Знаменател</param>
		/// <returns>Резултат от делене като цяло число</returns>
		public static int Divide(int x, int y)
		{
			if (y != 0)
			{
				return x / y;
			}
			return 0;
		}
	}
}
