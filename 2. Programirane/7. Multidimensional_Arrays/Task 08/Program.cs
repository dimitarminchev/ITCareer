using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
/* 8. Таблички
Иванчо много обича да си прави таблички в Excel. Понеже Иванчо е Excel Master си прави и Sheet-ове. На Иванчо обаче това не му стига. Затова той ще ви даде данните от един файл с всичките му Sheet-ове, от вас се иска да изведете малко статистика:
- От всеки sheet: Минимален елемент, Максимален елемент и Средноаритметично.
- Средноаритметично на целия документ – получава се като разделим средноаритметичните от всеки sheet на броя на sheet-овете
- Колко елемента от всеки sheet са над средноаритметичното за целия документ.
Решение: Димитър Минчев
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Въвеждане на броя на страниците
            int pages = int.Parse(Console.ReadLine());

            // Документ и статистика
            int[][,] document = new int[pages][,];
            float[] minimum = new float[pages];
            float[] maximum = new float[pages];
            float[] average = new float[pages];

            // Обработка на данните за всяка страница
            for (int page = 0; page < pages; page++)
            {
                float avr = 0, min = 1000, max = -1000;

                // Въвеждане на редове и колони
                string[] dim = Console.ReadLine().Split(' ').ToArray();
                int rows = int.Parse(dim[0]);
                int cols = int.Parse(dim[0]);

                // Създаване на страница
                int[,] sheet = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    string[] temp = Console.ReadLine().Split(' ').ToArray();
                    for (int j = 0; j < cols; j++)
                    {
                        sheet[i, j] = int.Parse(temp[j]);

                        // Статистика: минимално, максимално и средно
                        if (sheet[i, j] < min) min = sheet[i, j];
                        if (sheet[i, j] > max) max = sheet[i, j];
                        avr += sheet[i, j];
                    }
                }

                // Добавяне на страницате към документа
                document[page] = sheet;
                minimum[page] = min;
                maximum[page] = max;
                average[page] = avr / (rows * cols);
            }

            // Извеждане на статистиката
            for (int page = 0; page < pages; page++)
            {
                Console.WriteLine("{0} {1} {2:f2}", minimum[page], maximum[page], average[page]);
            }

            /* TODO: След това извеждате един ред с n на брой елемента, разделени с интервал,
             * съответния брой числа над средноаритметичното за всеки един sheet. */
        }
    }
}
