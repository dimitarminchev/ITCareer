namespace App5
{
    /// <summary>
    /// Човек
    /// </summary>
    class Person
    {
        // Име 
        private string name;
        public string Name { get { return name; } set { name = value;  }}

        // Възраст
        private int age;
        public int Age { get { return age; } set { age = value; } }
    }

}
