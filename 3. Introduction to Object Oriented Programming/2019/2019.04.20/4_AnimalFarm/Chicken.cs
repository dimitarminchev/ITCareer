using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_AnimalFarm
{
    class Chicken
    {
        // Име
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Възраст
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Конструктор
        public Chicken(string name, int age)
        {
            // Валидиране на името
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            this.name = name;
            this.age = age;
        }

        // Калкулираме възможното производство на яйца за едни ден
        public string CalculateProductPerDay()
        {
            if (this.age < 0 || this.age > 15)
            {
                throw new ArgumentException("Age should be between 0 and 15.");
            }

            return $"Chicken {this.name}(age {this.age}) can produce 1 eggs per day.";
        }
    }
}
