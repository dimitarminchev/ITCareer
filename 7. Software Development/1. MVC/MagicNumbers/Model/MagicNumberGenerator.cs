using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MagicNumbers.Model
{
    class MagicNumberGenerator
    {
        private int product;

        public int Product
        {
            get { return product; }
            set { product = value; }
        }

        public MagicNumberGenerator(int product)
        {
            this.Product = product;
        }

        public List<string> GenerateAllMagicNumbers()
        {
            var AllMagicNumbers = new List<string>();
            for(int a = 1; a<=Math.Min(Product, 9); a++)
            {
                for (int b = 1; b <= Math.Min(Product, 9); b++)
                {
                    for (int c = 1; c <= Math.Min(Product, 9); c++)
                    {
                        for (int d = 1; d <= Math.Min(Product, 9); d++)
                        {
                            for (int e = 1; e <= Math.Min(Product, 9); e++)
                            {
                                for (int f = 1; f <= Math.Min(Product, 9); f++)
                                {
                                    if(a*b*c*d*e*f == this.Product)
                                    {
                                        AllMagicNumbers.Add($"{a}{b}{c}{d}{e}{f}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return AllMagicNumbers;
        }
    }
}
