using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Dependencies
{
    public class FakeTarget : ITarget
    {
        public int Health => 0;

        public int GiveExperience() => 20;
    
        public bool IsDead() => true;        

        public void TakeAttack(int attackPoints)
        {
            // nope
        }   
    }
}
