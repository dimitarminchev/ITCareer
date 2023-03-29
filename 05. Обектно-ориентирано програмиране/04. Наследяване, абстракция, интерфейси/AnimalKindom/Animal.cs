namespace AnimalKingdom
{
    abstract class Animal : IMakeNoise, IMakeTrick
    {
        protected string name;
        protected int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("My name is " + name + ". I am " + age + " years old.");
        }

        public virtual void MakeTrick()
        {
            Console.WriteLine("Look at my trick!");
        }
    }
}
