using System;

namespace Task_21
{
/* 21. Рефакторирайте Обем на пирамида 
Получавате работещ код, който намира обема на пирамида. 
Въпреки това, трябва да вземете предвид неговото качество – дали променливите са именувани разумно, дали се използват най-подходящите типове, 
какъв е техния промеждутък и дали се използват само за едно дейстиве. 
*/
    class Program
    {
        // Решение: Павел Недков
        static void Main(string[] args)
        {
            var Lenght = double.Parse(Console.ReadLine());
            var Width = double.Parse(Console.ReadLine());
            var Height = double.Parse(Console.ReadLine());
            var V = (Lenght + Width + Height) / 3;
            Console.Write("Length: {0} ", Lenght);
            Console.Write("Width: {0} ", Width);
            Console.Write("Heigth: {0} ", Height);
            Console.WriteLine("Pyramid Volume: {0:F2}", V);
        }
    }
}
