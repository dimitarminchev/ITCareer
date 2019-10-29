using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards
{
    class ArmorRepairKit
    {
        private int weight;

        void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
            character.Armor = character.BaseArmor;            
        }

        public ArmorRepairKit()
        {
            this.weight = 10;
        }
    }
}
