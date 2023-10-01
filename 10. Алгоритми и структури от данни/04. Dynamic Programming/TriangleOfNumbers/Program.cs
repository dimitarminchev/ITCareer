namespace TriangleOfNumbers
{
    public class Program
    {
/*
Задача 2. Триъгълник от числа
---
Напишете програма, която пресмята най-голямата възможна сума от числа, 
разположени на някои от пътищата, започващи от най-горната точка на триъгълника и завършващи 
в точка от основата на триъгълника. Изисква се пътищата да са такива, че при всяка от стъпките 
движението да се осъществява надолу — в посока по диагонала наляво или по диагонала надясно.

Вход:
0 7 0 0 0 0
0 3 8 0 0 0
0 8 1 0 0 0
0 2 7 4 4 0
0 4 5 2 6 5
END

Изход:
30
*/

        static void Main(string[] args)
        {
            // Вход
            List<string> inputs = new List<string>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                inputs.Add(input);
                input = Console.ReadLine();
            }

            var board = new int[inputs.Count][];
            for (int i = 0; i < inputs.Count; i++)
            {
                board[i] = inputs[i].Split().Select(int.Parse).ToArray();
            }

            // Решение
            var max = new int[board.Length][];
            for (int i = 0; i < board.Length; i++)
            {
                max[i] = new int[board.Length + 1];
            }
            max[0][1] = board[0][1];

            for (int i = 1; i < board.Length; i++)
            {
                for (int j = 1; j < board.Length + 1; j++)
                {
                    max[i][j] = Math.Max(board[i][j] + max[i - 1][j - 1], board[i][j] + max[i - 1][j]);
                }
            }

            // Изход
            Console.WriteLine(max.Last().Max());
        }
    }
}