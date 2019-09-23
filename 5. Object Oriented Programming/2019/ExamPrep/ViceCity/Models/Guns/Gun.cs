using System;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Gun : IGun
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or a white space!");
                }
                this.name = value;
            }
        }

        private int bulletsPerBarrel;
        public int BulletsPerBarrel
        {
            get { return this.bulletsPerBarrel; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullets cannot be below zero!");
                }
                this.bulletsPerBarrel = value;
            }
        }

        private int totalBullets;
        public int TotalBullets
        {
            get { return this.totalBullets; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total bullets cannot be below zero!");
                }
                this.totalBullets = value;
            }
        }

        public bool CanFire
        {
            get { return this.CanFire; }
            set { this.CanFire = value; }
        }

        public virtual int Fire()
        {
            return 0;
        }

        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
        }
    }
}
