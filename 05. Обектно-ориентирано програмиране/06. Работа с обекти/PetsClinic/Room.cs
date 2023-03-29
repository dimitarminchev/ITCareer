namespace PetsClinic
{
    public class Room
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private bool isEmpty;

        public bool IsEmpty
        {
            get { return isEmpty; }
            set { isEmpty = value; }
        }

        private Pet pet;

        public Pet Pet
        {
            get { return pet; }
            set { pet = value; }
        }

        public Room(int number, bool isEmpty = true)
        {
            this.number = number;
            this.isEmpty = isEmpty;
        }

        public Room(int number, bool isEmpty, Pet pet) : this(number, isEmpty)
        {
            this.pet = pet;
        }
    }
}