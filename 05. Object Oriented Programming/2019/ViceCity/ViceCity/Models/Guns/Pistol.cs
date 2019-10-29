namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        public Pistol(string name) : base(name, 10, 100)
        {
            ;;
        }

        public override int Fire()
        {
            // Reload
            if (base.BulletsPerBarrel <= 0)
            {
                base.BulletsPerBarrel = 9;
                base.TotalBullets -= 10;
                return 1;
            }
            // Can Fire
            if (base.TotalBullets <= 0)
            {
                base.CanFire = false;
                return 0;
            }

            // Fire
            base.BulletsPerBarrel--;
            return 1;
        }
    }
}
