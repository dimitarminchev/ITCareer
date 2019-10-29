using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards
{
    interface IAttackable
    {
        void Attack(Character character);
    }

    interface IHealable
    {
        void Heal(Character character);
    }
}
