using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
/* 11. Разклащане на Мелрах
Даден е низ от случайни символи, както и шаблон от случайни символи. Вие трябва да "отърсите" (премахнете) всички граничните случаи на този шаблон, с други думи, първото съвпадение (срещане) и последното съвпадение на шаблона в низа.
Когато успешно премахнете дадено съвпадение , премахнете от шаблона символа, който съответства на индекса, равен на дължината на шаблона / 2. След това продължавате да премахвате от краищата на низа съвпаденията с новия шаблон, докато шаблона стане празен или докато основния низ стане по-къс от шаблона.
В случай, че сте намерили най-малко две съвпадения, успешно сте ги премахнали , извеждате "Shaked it" на конзолата. В противен случай извеждате “No shake.”, остатъкът от основния низ, и завършвате програмата. Вижте примерите за повече информация.
Решение: Божидар Андонов и Митко Недялков
*/
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var shaken = true;
            string trimming = Console.ReadLine();
            string finalword = "";
            while (shaken)
            {
                var temp = finalword;
                var parts = finalword.Split(new string[] { trimming }, StringSplitOptions.RemoveEmptyEntries);
                finalword = String.Join("", parts);
                if (temp == finalword) shaken = false;
                if (shaken == true)
                {
                    if (parts.Length > 2)
                        Console.WriteLine("Shaked it.");
                    else
                        Console.WriteLine("No Shake.");
                    trimming = trimming.Remove((int)Math.Truncate(trimming.Length / 2d), 1);
                }
            }
            Console.WriteLine("No Shake.\n" + finalword);
        }
    }
}
