namespace DungeonsAndCodeWizards
{
    class Warrior : IAttackable
    {
        private Character warior;

        public Warrior(string name, Faction faction)
        {
            this.warior = new Character( name, 100, 50, 40, new Bag(20), faction);
        }

        void IAttackable.Attack(Character character)
        {
            if (warior.IsAlive && character.IsAlive)
            {
                if (warior.Name == character.Name)
                {
                    throw new InvalidOperationException("Cannot attack self!");
                }
                if (warior.Faction == character.Faction)
                {
                    throw new ArgumentException("Friendly fire!Both characters are from {0} faction!",warior.Faction.ToString());
                }
                character.TakeDamage(warior.AbilityPoints);
            }
        }    
    }
}
