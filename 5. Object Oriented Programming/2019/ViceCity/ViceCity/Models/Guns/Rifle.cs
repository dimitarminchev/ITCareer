namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        public Rifle(string name) : base(name, 50, 500)
        {
            ;;
        }

        public override int Fire()
        {
            // Reload
            if (base.BulletsPerBarrel <= 0)
            {
                base.BulletsPerBarrel = 45;
                base.TotalBullets -= 50;
                return 5;
            }
            // Can Fire
            if (base.TotalBullets <= 0)
            {
                base.CanFire = false;
                return 0;
            }

            // Fire
            base.BulletsPerBarrel-=5;
            return 5;
        }
    }
}
