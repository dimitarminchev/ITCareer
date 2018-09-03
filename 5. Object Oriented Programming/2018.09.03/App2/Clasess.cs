using System;

namespace App2
{
    // Интерфейс на атакувания обект
    public interface ITarget
    {
        void TakeAttack(int attackPoints);
        int Health { get; }
        int GiveExperience();
        bool IsDead();
    }

    // Чучело
    public class Dummy : ITarget // Наследяване
    {
        private int health;
        private int experience;

        public Dummy(int health, int experience)
        {
            this.health = health;
            this.experience = experience;
        }

        public int Health
        {
            get { return this.health; }
        }

        public void TakeAttack(int attackPoints)
        {
            if (this.IsDead())
            {
                throw new InvalidOperationException("Dummy is dead.");
            }

            this.health -= attackPoints;
        }

        public int GiveExperience()
        {
            if (!this.IsDead())
            {
                throw new InvalidOperationException("Target is not dead.");
            }

            return this.experience;
        }

        public bool IsDead()
        {
            return this.health <= 0;
        }
    }

    // Интерфейс на оръжието
    public interface IWeapon
    {
        void Attack(ITarget target);
        int AttackPoints { get; }
        int DurabilityPoints { get; }
    }

    // Брадвата
    public class Axe : IWeapon // Наследяване
    {
        private int attackPoints;
        private int durabilityPoints;

        public Axe(int attack, int durability)
        {
            this.attackPoints = attack;
            this.durabilityPoints = durability;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DurabilityPoints
        {
            get { return this.durabilityPoints; }
        }

        public void Attack(ITarget target) // Инжектиране на зависимост
        {
            if (this.durabilityPoints <= 0)
            {
                throw new InvalidOperationException("Axe is broken.");
            }

            target.TakeAttack(this.attackPoints);
            this.durabilityPoints -= 1;
        }
    }

    // Героя
    public class Hero
    {
        private string name;
        private int experience;
        private IWeapon weapon;

        public Hero(string name, IWeapon weapon)
        {
            this.name = name;
            this.experience = 0;
            this.weapon = weapon;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Experience
        {
            get { return this.experience; }
        }

        public IWeapon Weapon
        {
            get { return this.weapon; }
        }

        public void Attack(ITarget target)
        {
            this.weapon.Attack(target);

            if (target.IsDead())
            {
                this.experience += target.GiveExperience();
            }
        }
    }

    // Фалчиво чучело
    public class FakeTarget : ITarget
    {
        public void TakeAttack(int attackPoints) { /* нищо не прави */ }
        public int Health => 0;
        public int GiveExperience() { return 20; }
        public bool IsDead() { return true; }
    }

    // Фалчива брадва
    public class FakeWeapon : IWeapon
    {
        public void Attack(ITarget target) { /* нищо не прави */ }
        public int AttackPoints => 42;
        public int DurabilityPoints => 24;
    }
}
