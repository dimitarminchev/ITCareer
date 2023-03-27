using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards
{
    class PoisonPotion
    {
        private int weight;

        void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
            character.Health -= 20;
            if (character.Health == 0)
            {
                character.IsAlive = false;
            }
        }

        public PoisonPotion()
        {
            this.weight = 5;
        }
    }
}
