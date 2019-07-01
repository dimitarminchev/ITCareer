using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
/* 4. Лотариен Билет
Прасчо си купил лотариен билет. Тъй като Прасчо не разбирал много-много, но пък имал голям късмет, 
отишъл при Мечо Пух да му помогне с „разшифрирането“ на лотарийния билет. 
Лотарийния билет след изтъркване представлява табличка от числа с n реда и m колони.  

Решение: Димитър Минчев
*/
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            // Входни данни
            for (int r = 0; r < rows; r++)
            {
                var line = Console.ReadLine().Split(' ');
                int c = 0;
                foreach (var item in line)
                    matrix[r, c++] = int.Parse(item);
            }

            // Суми по диагоналите
            double d1 = 0, d2 = 0;
            for (int k = 0; k < rows; k++) d1 += matrix[k,k];
            for (int k = 0; k < rows; k++) d2 += matrix[k,rows-k-1];

            // Сумите над и под главния диагонал
            double s1 = 0, s2 = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(col > row) s1 += matrix[row,col];
                    if(col < row) s2 += matrix[row, col];
                }
            }

            // YES or NO
            if (d1 == d2 && s1 % 2 == 0 && s2 % 2 != 0) Console.WriteLine("YES");
            else
            {
                Console.WriteLine("NO");
                return;
            }

            // Сума на четните по главния диагонал
            double sd = 0;
            for (int k = 0; k < rows; k++)
            if (matrix[k, k] % 2 == 0) sd += matrix[k, k];

            // Сума на четните числа по външните редове
            double sr = 0;
            for (int k = 0; k < cols; k++)
            {
               if (matrix[0, k] % 2 == 0) sr += matrix[0, k];
               if (matrix[rows-1, k] % 2 == 0) sr += matrix[rows - 1, k];
            }

            // Сума на нечетни числа по външните колони
            double sc = 0;
            for (int k = 0; k < rows; k++)
            {
                if (matrix[k, 0] % 2 != 0) sc += matrix[k,0];
                if (matrix[k, cols - 1] % 2 != 0) sc += matrix[k,cols - 1];
            }

            // Средно на всички суми
            double avr = (s2 + sd + sr + sc) / 4.0; 
            Console.WriteLine("The amount of money won is: {0:f2}", avr);
        }
    }
}
