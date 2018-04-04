using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPBasics_Burgasko
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split(' ');
                var carModel = carInfo[0];
                var carEngineSpeed = int.Parse(carInfo[1]);
                var carEnginePower = int.Parse(carInfo[2]);
                var carCargoWeight = int.Parse(carInfo[3]);
                var carCargoType = carInfo[4];
                var carTire1Pressure = double.Parse(carInfo[5]);
                var carTire1Age = int.Parse(carInfo[6]);
                var carTire2Pressure = double.Parse(carInfo[7]);
                var carTire2Age = int.Parse(carInfo[8]);
                var carTire3Pressure = double.Parse(carInfo[9]);
                var carTire3Age = int.Parse(carInfo[10]);
                var carTire4Pressure = double.Parse(carInfo[11]);
                var carTire4Age = int.Parse(carInfo[12]);

                cars.Add(new Car(carModel, carEngineSpeed, carEnginePower, carCargoWeight, carCargoType,
                    carTire1Pressure, carTire1Age, carTire2Pressure, carTire2Age,
                    carTire3Pressure, carTire3Age, carTire4Pressure, carTire4Age));
            }

            var outputRequirement = Console.ReadLine();

            IEnumerable<Car> result;

            if (outputRequirement == "fragile")
            {
                result = cars.Where(c => c.Cargo.Type == outputRequirement)
                    .Where(c => c.Tire1.Pressure < 1 || c.Tire2.Pressure < 1 ||
                                c.Tire3.Pressure < 1 || c.Tire4.Pressure < 1);
            }
            else
            {
                result = cars.Where(c => c.Cargo.Type == outputRequirement)
                    .Where(c => c.Engine.Power > 250);
            }

            Console.WriteLine(String.Join(Environment.NewLine, result.Select(c => c.Model)));
        }
    }
}