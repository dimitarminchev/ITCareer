namespace HeroFight.Entities.Weapons
{
    using Contracts;
    using System;
    using System.Text;

    public abstract class Weapon
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
                    throw new ArgumentException("Weapon name cannot be null, empty or whitespace.");
                }
                name = value; 
            }
        }

        // Strength 
        private int strength;

        public int Strength
        {
            get { return strength; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Strength cannot be less than 0!");
                }
                strength = value; 
            }
        }

        // Agility 
        private int agility;

        public int Agility
        {
            get { return agility; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Agility cannot be less than 0!");
                }
                agility = value; 
            }
        }

        // Intelligence 
        private int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Intelligence cannot be less than 0!");
                }
                intelligence = value; 
            }
        }

        // Constructor
        protected Weapon(string name, int strength, int agility, int intelligence)
        {
            this.Name = name;
            this.Strength = strength;
            this.Agility = agility;
            this.Intelligence = intelligence;
        }
    }
}