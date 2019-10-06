using System;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public  class Player : IPlayer
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Player's name cannot be null or a whitespace!");
                }
                this.name = value;
            }
        }

        private int lifePoints;
        public int LifePoints
        {
            get { return this.lifePoints; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }
                this.lifePoints = value;
            }
        }

        private IRepository<IGun> gunRepository;
        public IRepository<IGun> GunRepository
        {
            get { return this.gunRepository; }
            set { this.gunRepository = value; }
        }

        private bool isAlive;
        public bool IsAlive
        {
            get { return this.isAlive; }
            set { this.isAlive = value; }
        }

        public void TakeLifePoints(int points)
        {
            if (this.lifePoints == 0) return;
            else this.lifePoints--;
        }

        public Player(string name, int lifePoints)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
        }
    }
}
