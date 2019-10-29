using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Vehicles2
{
    interface IVehicle
    {
        double Fuel { get; }
        double FuelCapacity { get; }
        double Litersperkm { get;}
        double Distance { get;}
        void Drive(double km);
        void Refuel(double litres);
    }
}
