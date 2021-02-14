namespace SumExample
{
    public static class Sumator
    {
        /// <summary>
        /// Метод за намиране на сумата на елементите на масив
        /// </summary>
        /// <param name="array">Целочислен масив</param>
        /// <returns>Сума на елементите като цало число</returns>
        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
