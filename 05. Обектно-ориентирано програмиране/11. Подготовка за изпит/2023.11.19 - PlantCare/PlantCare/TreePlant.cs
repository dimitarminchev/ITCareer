using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Drawing;

public class TreePlant : Plant
{
    private int height;

    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height should be positive!");
            }
            height = value;
        }
    }

    public TreePlant(int id, string name, double humidityLevel, double fertilityLevel, int height)
        : base(id, name, "tree", humidityLevel, fertilityLevel)
    {
        Height = height;
    }

    public override string ToString()
    {
        return $"Id: {Id}\n"
            + $"Name: {Name}\n"
            + $"Type: {Type}\n"
            + $"Humidity Level: {HumidityLevel:f2} %\n"
            + $"Fertility Level: {FertilityLevel:f2} %\n"
            + $"Height: {Height}";
    }
}

