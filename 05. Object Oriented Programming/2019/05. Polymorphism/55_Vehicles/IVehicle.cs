using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Vehicles
{
    interface IVehicle
    {
        double Fuel { get; }
        double Litersperkm { get;}
        double Distance { get;}
        void Drive(double km);
        void Refuel(double litres);
    }
}
