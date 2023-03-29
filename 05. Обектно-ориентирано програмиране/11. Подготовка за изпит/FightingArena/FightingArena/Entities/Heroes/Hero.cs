namespace HeroFight.Entities.Heroes
{
    using HeroFight.Entities.Weapons;
    using Contracts;
    using System;
    using System.Text;

    // Hero
    public abstract class Hero
    {
        // Name
        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Hero name cannot be null, empty or whitespace.");
                }
                name = value; 
            }
        }

        // Level
        private int level;

        public int Level
        {
            get { return level; }
            private set 
            { 
                level = value; 
            }
        }


        // Weapon
        private Weapon weapon;

        public Weapon Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        // Power
        private double power;

        public double Power
        {
            get 
            {
                if (this.Weapon != null)
                {
                    return power * ((this.Weapon.Strength + this.Weapon.Agility + this.Weapon.Intelligence) / 3.0);
                }
                else return 0;
            }
            set
            {
                power = value;
            }
        }

        // Experience
        private int experience;

        public int Experience
        {
            get { return experience; }
            set 
            {
                experience = value;
                if (experience >= 100)
                {
                    level += 1; // Level Up
                    experience -= 100;
                }
            }
        }

        // Constructor
        protected Hero(string name)
        {
            this.Name = name;
        }

        // String
        public override string ToString()
        {
            var sb = new StringBuilder();

            var heroClassType = this.GetType().Name;
            sb.AppendLine($"{heroClassType}: {this.Name} - Level: {this.Level}");
            sb.AppendLine($"Experience: {this.Experience}");

            if (this.Weapon != null)
            {
                var weaponClassType = this.Weapon.GetType().Name;
                sb.AppendLine($"{weaponClassType}: {this.Weapon.Name}");
                sb.AppendLine($"  *Strength: {this.Weapon.Strength}");
                sb.AppendLine($"  *Agility: {this.Weapon.Agility}");
                sb.AppendLine($"  *Intelligence: {this.Weapon.Intelligence}");
            }
            sb.Append($"Power: {this.Power:f2}");

            return sb.ToString();
        }
    }
}