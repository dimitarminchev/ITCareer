﻿namespace BarracksWars.CommandsStrikeBack
{
    public class Gunner : Unit
    {
        private const int DefaultHealth = 20;

        private const int DefaultDamage = 20;

        public Gunner() : base(DefaultHealth, DefaultDamage)
        {
            // nope
        }
    }
}