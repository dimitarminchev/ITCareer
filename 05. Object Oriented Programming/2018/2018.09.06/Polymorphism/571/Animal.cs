using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _571
{
    public abstract class Animal
    {
        public string animalName { get; protected set; }
        public string animalType { get; protected set; }
        public double animalWeight { get; protected set; }
        public int foodEaten { get; private set; }

        public Animal(string animalName, string animalType, double animalWeight)
        {
            this.animalName = animalName;
            this.animalType = animalType;
            this.animalWeight = animalWeight;
        }
        public abstract void makeSound();
        public virtual void eatFood(Food food)
        {
            this.foodEaten += food.quantity;
        }
    }

    public abstract class Mammal : Animal
    {
        public string livingRegion { get; protected set; }
        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight)
        {
            this.livingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }

    public class Mouse : Mammal
    {

        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion) { }
        public override void makeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void eatFood(Food food)
        {
            if (food is Vegetable)
                base.eatFood(food);
            else
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
        }
    }

    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion) { }
        public override void makeSound()
        {
            Console.WriteLine("Zs");
        }

        public override void eatFood(Food food)
        {
            if (food is Vegetable)
                base.eatFood(food);
            else
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
        }
    }

    public abstract class Felime : Mammal
    {
        public Felime(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }
    }
    public class Cat : Felime
    {
        public string breed { get; private set; }
        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.breed = breed;
        }

        public override void makeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void eatFood(Food food)
        {
            base.eatFood(food);
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {breed}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
    public class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void eatFood(Food food)
        {
            if (food is Meat)
                base.eatFood(food);
            else
                Console.WriteLine($"{this.GetType().Name}s are not eating that type of food!");
        }
        public override void makeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
    }

}
