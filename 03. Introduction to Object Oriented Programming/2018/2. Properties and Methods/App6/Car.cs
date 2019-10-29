using System;
using System.Collections.Generic;
using System.Text;


class Car
{
    public string Model { get; set; }

    public CarEngine Engine { get; set; }

    public Cargo Cargo { get; set; }

    public Tire Tire1 { get; set; }

    public Tire Tire2 { get; set; }

    public Tire Tire3 { get; set; }

    public Tire Tire4 { get; set; }

    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
        double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age,
        double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
    {
        this.Model = model;
        this.Engine = new CarEngine(engineSpeed, enginePower);
        this.Cargo = new Cargo(cargoWeight, cargoType);
        this.Tire1 = new Tire(tire1Pressure, tire1Age);
        this.Tire2 = new Tire(tire2Pressure, tire2Age);
        this.Tire3 = new Tire(tire3Pressure, tire3Age);
        this.Tire4 = new Tire(tire4Pressure, tire4Age);
    }

}