using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen.Model
{
    class Generator
    {
        private int firstNumber;
        private int secondNumber;

        public int FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }

        public int SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }

        public Generator(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public List<string> GeneratorPasswords()
        {
            List<string> passwords = new List<string>();
            for (int a = 1; a <= this.firstNumber; a++)
            {
                for (int b = 1; b <= this.firstNumber; b++)
                {
                    for (char c = 'a'; c < 'a' + secondNumber; c++)
                    {
                        for (char d = 'a'; d < 'a' + secondNumber; d++)
                        {
                            for (int e = 0; e <= firstNumber; e++)
                            {
                                if (a < e && b < e)
                                {
                                    passwords.Add($"{a}{b}{c}{d}{e}");
                                }
                            }
                        }
                    }
                }
            }
            return passwords;
        }

    }
}
