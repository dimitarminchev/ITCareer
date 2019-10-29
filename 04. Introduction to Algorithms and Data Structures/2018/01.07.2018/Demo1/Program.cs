using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        /* Разтеглив Масив */
        static void Main(string[] args)
        {
            // Създаваме разтеглив масив
            ArrayList<string> list = new ArrayList<string>();

            // Отпечатваме броя елементи и капацитета
            Console.WriteLine("Lenght = {0}", list.Length);
            Console.WriteLine("Capacity = {0}", list.Capacity);

            // Зареждаме съдържание
            list.Add("Иванчо");
            list.Add("Марийка");
            list.Add("Петкан");

            // Отпечатваме съдържанието
            for (int i = 0; i < list.Length; i++) Console.WriteLine(list.Get(i));

            // Отпечатваме броя елементи и капацитета
            Console.WriteLine("Length = {0}", list.Length);
            Console.WriteLine("Capacity = {0}", list.Capacity);

            // Премахваме елемент на позиция 1
            Console.WriteLine("Remove = {0}",list.RemoveAt(1));

            // Отпечатваме съдържанието
            for (int i = 0; i < list.Length; i++) Console.WriteLine(list.Get(i));

            // Отпечатваме броя елементи и капацитета
            Console.WriteLine("Length = {0}", list.Length);    
            Console.WriteLine("Capacity = {0}", list.Capacity); 
        }
    }
}
