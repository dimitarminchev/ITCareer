using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _541
{
    public class Trainer
    {
        private IAnimal entity;

        public Trainer(IAnimal entity)
        {
            this.entity = entity;
        }

        public void Make()
        {
            entity.Perform();
        }
    }

    
}
