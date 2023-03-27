namespace DungeonsAndCodeWizards
{
    class Cleric : IHealable
    {
        private Character cleric;

        public Cleric(string name, Faction faction)
        {
            this.cleric = new Character(name, 50, 25, 40, new Bag(100), faction);
        }

        void IHealable.Heal(Character character)
        {
            if (cleric.IsAlive && character.IsAlive)
            {
                if (cleric.Faction != character.Faction)
                {
                    throw new InvalidOperationException("Cannot heal enemy character!");                    
                }
                character.Health += cleric.AbilityPoints;
            }
        }
    }
}
