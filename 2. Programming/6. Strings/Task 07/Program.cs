using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
/* 7. Магически променящи се думи
Напишете метод, който приема като вход два низа и връща True или False, ако те са заменяеми, или не. Заменяеми са думи, където символите в първия низ може да бъдат заменени и да се получи втория низ. Пример: "egg" и "add" са заменяеми, но "aabbccbb" и "nnooppzz" не са. (Първото "b" отговаря на “o”, но тогава то също така отговаря на"z"). Двете думи  може да нямат една и съща дължина, ако случаят е такъв, те са заменяеми, само ако по-дългата няма повече от видовете букви на първата ("Clint" и "Eastwaat" са заменяеми защото "a" и “t” вече са заменени като "l" и " n " но "Clint" и "Eastwood" не са заменяеми защото ‘о‘ и ‚‘d‘ не се съдържат в"Clint").
Решение: Митко Недялков
*/
    class Program
    {
        static bool MagicWords(char[] letters1, char[] letters2)
        {
            var matches = new Dictionary<char, char>();
            var smallerArr = letters1.Length == (Math.Min(letters1.Length, letters2.Length)) ? letters1 : letters2;
            var biggerArr = letters1.Length == (Math.Min(letters1.Length, letters2.Length)) ? letters2 : letters1;

            for (int i = 0; i < smallerArr.Length; i++)
            {
                if (!matches.ContainsKey(smallerArr[i]))
                {
                    matches.Add(smallerArr[i], biggerArr[i]);
                }
                else
                {
                    if (matches[smallerArr[i]] == biggerArr[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            for (int i = smallerArr.Length; i < biggerArr.Length; i++)
            {
                if (matches.ContainsValue(biggerArr[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string[] BothWords = Console.ReadLine().Split(' ').ToArray();
            string FirstWord = BothWords[0];
            string SecondWord = BothWords[1];

            char[] LettersFirstWord = FirstWord.ToCharArray();
            char[] LettersSecondWord = SecondWord.ToCharArray();
            var isMagic = MagicWords(LettersFirstWord, LettersSecondWord);
            Console.WriteLine(isMagic.ToString().ToLower());
        }
    }
}
