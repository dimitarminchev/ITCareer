using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Chicken
    {
        public const int MinAge = 0;
        public const int MaxAge = 15;

        // Име
        protected string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Възраст
        internal int age;
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        // Конструктор
        public Chicken(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Продукция дневно
        public double ProductPerDay
        {
            get {  return this.CalculateProductPerDay(); }
        }
        public double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3: return 1.5;
                case 4:
                case 5:
                case 6:
                case 7: return 2;
                case 8:
                case 9:
                case 10:
                case 11: return 1;
                default: return 0.75;
            }
        }
    }
}
