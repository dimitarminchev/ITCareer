public class Attacker : EventArgs
{
    public delegate void RoyalGuardHandler(object sender, EventArgs e);

    public event RoyalGuardHandler WorkPerformed;

    public virtual void DoWork(object sender,EventArgs e)
    {
        WorkPerformed?.Invoke(this, e);
    }
}