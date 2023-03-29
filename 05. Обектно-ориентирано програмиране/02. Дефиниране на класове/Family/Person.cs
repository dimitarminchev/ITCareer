namespace Family
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine("Hello! My name is {0} and I am {1} years old.", name, age);
        }
    }
}