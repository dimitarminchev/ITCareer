namespace DivisionExample
{
    public class Divider
    {
        /// <summary>
        /// Метод за целочислено деление
        /// </summary>
        /// <param name="x">Числител</param>
        /// <param name="y">Знаменател</param>
        /// <returns>Резултат от делението</returns>
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
