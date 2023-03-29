namespace Vehicles
{
    public interface IVehicle
    {
        double Fuel { get; }

        double LitersPerKm { get; }

        double Distance { get; }

        void Drive(double km);

        void Refuel(double litres);
    }
}