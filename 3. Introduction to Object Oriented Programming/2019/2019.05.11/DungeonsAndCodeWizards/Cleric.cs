using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards
{
    class Cleric : IHealable
    {
        private Character cleric;

        // Конструктор
        public Cleric(string name, Faction faction)
        {
            this.cleric = new Character(name, 50, 25, 40, new Bag(100), faction);
        }

        // Лечение
        void IHealable.Heal(Character character)
        {
            if (cleric.IsAlive && character.IsAlive)
            {
                if (cleric.Faction != character.Faction)
                {
                    throw new InvalidOperationException("Cannot heal enemy character!");                    
                }
                character.Health += cleric.AbilityPoints;
            }
        }
    }
}
