using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns.Contracts
{
    public interface IGun
    {
        string Name { get; }

        int BulletsPerBarrel { get; }

        int TotalBullets { get; }

        bool CanFire { get; }

        int Fire();
    }
}
