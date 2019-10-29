using System;

namespace Task_8
{
/* 8. Лице на кръг (с точност 12 знака)
Напишете програма, в която въвеждаме радиус r (реално число) и извеждаме лицето на кръг с точно 12 знака след десетичната запетая. 
Използвайте тип данни с подходяща точност за съхранение на резултатите.
*/
    class Program
    {
        // Решение: Живко Колев   
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine("{0:f12}", area);
        }
    }
}
