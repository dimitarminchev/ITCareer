using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    // Интефейса изглежда като клас, но не имплементира методите 
    public interface IOddEven
    {
        // Чисто абстрактни методи (без имплементация)
        bool IsOdd(int number);
        bool IsEven(int number);
    }

    // Наследяващ клас
    public class OddEven : IOddEven
    {
        // Имплементации на абстрактните методите от интерфейса
        public bool IsOdd(int number)
        {
            return number % 2 != 0 ? true : false;
        }
        public bool IsEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }
    }
}
