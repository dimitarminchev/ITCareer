using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards
{
    class Item
    {
        // Име
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Must not be empty!");
                }
                name = value;
            }
        }

        // Тегло
        private int weight;

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Must be not zero");
                }
                weight = value;
            }
        }

        public void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }

        public Item(int weight)
        {
            this.Weight = weight;
        }
    }
}
