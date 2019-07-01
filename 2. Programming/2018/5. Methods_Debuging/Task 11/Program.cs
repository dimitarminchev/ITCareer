using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
/* 11. Price Change Alert
Имате за задача да преработите готов код, който работи без грешки, но не е форматиран както трябва. 
Предоставената ви програма следи цените на стоки и дава информация за значимостта на всяка промяна в цената. 
Според това, доколко е съществена, има четири типа промени: без промяна (цената е същата като предишната), малка (разлика под прага на значимост), цената расте и цената намалява. 
Решение:  Божидар Андонов
*/
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double granica = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                double cena = double.Parse(Console.ReadLine());
                double difference = Percentage(last, cena);
                bool isSignificantDifference = IsThereADifference(difference, granica);
                string message = output(cena, last, difference, isSignificantDifference);
                Console.WriteLine(message);
                last = cena;
            }
        }

        private static string output(double cena, double last, double razlika, bool YesOrNo)
        {
            string output = "";
            if (razlika == 0)
            {
                output = string.Format("NO CHANGE: {0}", cena);
            }
            else if (!YesOrNo)
            {
                output = string.Format("MINOR CHANGE: {0} to {1} ({2:f2}%)", last, cena, razlika * 100);
            }
            else if (YesOrNo && (razlika > 0))
            {
                output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, cena, razlika * 100);
            }
            else if (YesOrNo && (razlika < 0))
                output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, cena, razlika * 100);
            return output;
        }

        private static bool IsThereADifference(double granica, double isDiff)
        {
            if (Math.Abs(granica) >= isDiff) return true;
            return false;
        }

        private static double Percentage(double last, double cena)
        {
            double percent = (cena - last) / last;
            return percent;
        }
    }
}
