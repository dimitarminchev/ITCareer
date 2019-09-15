using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_KingGambit
{
    class Attacker
    {
        public delegate void RoyalGuardHandler(object sender,EventArgs e);

        // Event
        public event RoyalGuardHandler WorkPerformed;

        // Job Start
        public virtual void DoWork(object sender,EventArgs e)
        {
            WorkPerformed?.Invoke(sender,e);
           /* workPerformed(e);
            if (e is RoyalGuard)
            {
                RoyalGuard rg = ;
                WorkPerformed?.Invoke((RoyalGuard)e);
            }
            else if(e is Footman)
            {
            }
            // Event Invocation*/
            
        }

        // On Job Finished
        public void workPerformed(object sender,EventArgs e)
        {
          // if (e is RoyalGuard)
        //    Console.WriteLine("Finished after {0} hours", e.Hours);
        }
    }
}
