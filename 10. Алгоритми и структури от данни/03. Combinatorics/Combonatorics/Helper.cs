namespace Combonatorics
{
    public static class Helper
    {
        /// <summary>
        /// Разменяне на елементите в структура от данни
        /// </summary>
        /// <typeparam name="T">Тип на структурата данни</typeparam>
        /// <param name="array">Структура данни</param>
        /// <param name="first">Първи елемент</param>
        /// <param name="second">Втори елемент</param>
        public static void Swap<T>(T[] array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
