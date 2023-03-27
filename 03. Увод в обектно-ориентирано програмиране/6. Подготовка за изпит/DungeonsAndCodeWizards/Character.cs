namespace DungeonsAndCodeWizards
{
    enum Faction { CSharp, Java };

    class Character
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }

        private double BaseHealth = 0.0F;

        private double health;

        public double Health
        {
            get { return health; }
            set
            {
                if (value < 0) health = 0;
                else if(value > BaseHealth) health = BaseHealth;
                else health = value;
            }
        }

        private double baseArmor;

        public double BaseArmor
        {
            get { return baseArmor; }
            set { baseArmor = value; }
        }

        private double armor;

        public double Armor
        {
            get { return armor; }
            set
            {
                if (value < 0) armor = 0;
                else if (value > BaseArmor) armor = BaseArmor;
                else armor = value;
            }
        }

        private double abilityPoints ;

        public double AbilityPoints
        {
            get { return abilityPoints; }
            set { abilityPoints = value; }
        }

        private Bag Bag;
     
        public Faction Faction { get; set; }

        private bool isalive = true;

        public bool IsAlive
        {
            get { return isalive; }
            set { isalive = value; }
        }

        private double RestHealMultiplier = 0.2F;

        public void TakeDamage(double hitPoints)
        {
            if (IsAlive)
            {
                var tempArmor = Armor;
                Armor -= hitPoints;
                if (Armor == 0)
                {
                    Health -= (hitPoints - tempArmor);
                    if (Health == 0) IsAlive = false;
                }
            }
        }

        public void Rest()
        {
            if (IsAlive)
            {
                Health += (BaseHealth * RestHealMultiplier);
            }
        }

        public void UseItem(Item item)
        {
            if (IsAlive) { ;; }
            // The item affects the character with the item effect.
        }
        public void UseItemOn(Item item, Character character)
        {
            if (IsAlive) { ;; }
            // The item affects the targeted character with the item effect.
        }
        public void GiveCharacterItem(Item item, Character character)
        {
            if (IsAlive) { ;; }
            // The targeted character receives the item.
        }

        public void ReceiveItem(Item item)
        {
            if (IsAlive)
            {
                this.Bag.AddItem(item);
            }
        }

        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
        }
    }
}
