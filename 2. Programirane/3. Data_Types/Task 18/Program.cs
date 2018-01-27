using System;

namespace Task_18
{
/* 18. Низове и обекти
Декларирайте две променливи от тип string  и им задайте стойности "Hello" и "World". 
Декларирайте променлива от тип object и ѝ присвоете слепването на първите две променливи (не забравяйте да добавите интервал между тях). 
Направете трета променлива от тип string и я инициализирайте със стойността от променливата с тип object (трябва да извършите преобразуване).
*/
    class Program
    {
        // Решение: Христо Димитров
        static void Main(string[] args)
        {
            string lineI = Console.ReadLine();
            string lineII = Console.ReadLine();
            object merge = lineI + " " + lineII;
            Console.WriteLine(merge);
        }
    }
}
