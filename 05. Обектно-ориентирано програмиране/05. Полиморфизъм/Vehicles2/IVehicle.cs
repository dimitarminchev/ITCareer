namespace Vehicles2
{
    public interface IVehicle
    {
        double Fuel { get; }

        double FuelCapacity { get; }

        double LitersPerKm { get; }

        double Distance { get; }

        void Drive(double km);

        void Refuel(double litres);
    }
}