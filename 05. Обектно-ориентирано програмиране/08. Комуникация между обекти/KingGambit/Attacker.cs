namespace KingGambit
{
    class Attacker
    {
        public delegate void RoyalGuardHandler(object sender,EventArgs e);

        public event RoyalGuardHandler WorkPerformed;

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
            */
        }

        public void workPerformed(object sender,EventArgs e)
        {
          // if (e is RoyalGuard)
          // Console.WriteLine("Finished after {0} hours", e.Hours);
        }
    }
}
