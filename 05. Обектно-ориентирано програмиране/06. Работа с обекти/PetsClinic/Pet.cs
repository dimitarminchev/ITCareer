namespace PetsClinic
{
    public class Pet
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

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Pet()
        {
            // nope
        }

        public Pet(string name, int age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }

        public bool Create(Pet pet)
        {
            if (pet.name.Length <= 50 && pet.age <= 100 && pet.type.Length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}