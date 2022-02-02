namespace DivisionExample
{
    public class Divider
    {
		/// <summary>
		/// Деление на две числа
		/// </summary>
		/// <param name="x">Числител</param>
		/// <param name="y">Знаменател</param>
		/// <returns>Резултат от деленето</returns>
		public int Divide(int x, int y)
		{
			if (y != 0)
			{
				return x / y;
			}
			return 0;
		}
	}
}
