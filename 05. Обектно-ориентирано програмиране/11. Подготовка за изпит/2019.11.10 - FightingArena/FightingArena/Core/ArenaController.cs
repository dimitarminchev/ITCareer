namespace HeroFight.Core
{
    using HeroFight.Entities.Heroes;
    using HeroFight.Entities.Weapons;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArenaController : IArenaController
    {
        private Dictionary<string, Hero> heroes;

        public ArenaController()
        {
            this.heroes = new Dictionary<string, Hero>();
        }

        // CreateHero type name
        public string CreateHero(List<string> args)
        {
            string type = args[0];
            string heroName = args[1];

            if (heroes.ContainsKey(heroName))
            {
                return $"Hero with name: {heroName} already exists!";
            }

            Hero hero = null;

            if (type == "Assassin")
            {
                hero = new Assassin(heroName);
            }
            else if (type == "Priest")
            {
                hero = new Priest(heroName);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(heroName);
            }

            if (hero == null)
            {
                return $"Invalid type hero: {type}.";
            }

            this.heroes.Add(heroName, hero);

            return $"{type}: {heroName} joined the Arena!";
        }

        // CreateWeapon heroName, weaponType, weaponName, strength, agility, intelligence
        public string CreateWeapon(List<string> args)
        {
            string heroName = args[0];
            string weaponType = args[1];
            string weaponName = args[2];
            int strength = int.Parse(args[3]);
            int agility = int.Parse(args[4]);
            int intelligence = int.Parse(args[5]);

            if (!this.heroes.ContainsKey(heroName))
            {
                return $"Hero with name: {heroName} does not exist!";
            }

            Hero hero = this.heroes[heroName];

            Weapon weapon = null;

            if (weaponType == "Bow")
            {
                weapon = new Bow(weaponName, strength, agility, intelligence);
            }
            else if (weaponType == "Sword")
            {
                weapon = new Sword(weaponName, strength, agility, intelligence);
            }
            else if (weaponType == "MagicWand")
            {
                weapon = new MagicWand(weaponName, strength, agility, intelligence);
            }

            if (weapon == null)
            {
                return $"Invalid type weapon: {weaponType}.";
            }

            hero.Weapon = weapon;

            return $"Successfully armed hero {heroName} with weapon {weaponType}!";
        }

        // Fight firstHeroName, secondHeroName
        public string Fight(List<string> args)
        {
            string firstHeroName = args[0];
            string secondHeroName = args[1];

            if (!this.heroes.ContainsKey(firstHeroName))
            {
                return $"Hero with name: {firstHeroName} does not exist!";
            }

            if (!this.heroes.ContainsKey(secondHeroName))
            {
                return $"Hero with name: {secondHeroName} does not exist!";
            }

            Hero firstHero = this.heroes[firstHeroName];
            Hero secondHero = this.heroes[secondHeroName];

            double difference = Math.Abs(firstHero.Power - secondHero.Power);

            if (firstHero.Power > secondHero.Power)
            {
                firstHero.Experience += 30;
                return $"Winner in the battle between {firstHeroName} and {secondHeroName} is {firstHeroName} with {difference:F2}.";
            }
            else if (secondHero.Power > firstHero.Power)
            {
                secondHero.Experience += 30;
                return $"Winner in the battle between {firstHeroName} and {secondHeroName} is {secondHeroName} with {difference:F2}.";
            }

            firstHero.Experience += 15;
            secondHero.Experience += 15;

            return $"No winner in battle between {firstHeroName} and {secondHeroName}!";
        }

        // HeroInfo heroName
        public string HeroInfo(List<string> args)
        {
            string heroName = args[0];

            if (!this.heroes.ContainsKey(heroName))
            {
                return $"Hero with name: {heroName} does not exist!";
            }

            Hero hero = this.heroes[heroName];

            return hero.ToString();
        }

        // CloseArena
        public string CloseArena()
        {
            List<Hero> sortedHeroes = this.heroes
                .OrderByDescending(x => x.Value.Level)
                .ThenByDescending(x => x.Value.Power)
                .ThenBy(x => x.Value.Name)
                .Select(x => x.Value)
                .ToList();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Heroes: {this.heroes.Count}");

            sortedHeroes
                .ForEach(x => sb.AppendLine(x.ToString()));

            return sb.ToString().Trim();
        }
    }
}