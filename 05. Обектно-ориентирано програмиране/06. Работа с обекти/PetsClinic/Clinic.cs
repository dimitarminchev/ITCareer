namespace PetsClinic
{
    public class Clinic
    {
        private int busyRooms;

        public int BusyRooms
        {
            get { return busyRooms; }
            set { busyRooms = 0; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int numberOfRooms;

        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine("Invalid operation!");
                }
                else
                {
                    numberOfRooms = value;
                }
            }
        }

        public Room[] rooms;

        List<Pet> pets;

        public Clinic()
        {
            rooms = new Room[numberOfRooms];
            pets = new List<Pet>();
        }

        public Clinic(string name, int numberOfRooms)
        {
            this.name = name;
            NumberOfRooms = numberOfRooms;
            rooms = new Room[numberOfRooms + 1];
            for (int i = 1; i <= numberOfRooms; i++)
            {
                rooms[i] = new Room(i, true);
            }
            pets = new List<Pet>();
        }

        public bool AddPet(Pet pet)
        {
            int i = numberOfRooms / 2 + 1;
            int counter = 0;
            while (counter < numberOfRooms)
            {
                if (busyRooms < numberOfRooms)
                {
                    if (counter % 2 == 0)
                    {
                        if (rooms[i - counter].IsEmpty)
                        {
                            rooms[i - counter] = new Room(i - counter, false, pet);
                            pets.Add(pet);
                            busyRooms++;
                            return true;
                        }
                        else if (rooms[i + counter].IsEmpty)
                        {
                            rooms[i + counter] = new Room(i + counter, false, pet);
                            pets.Add(pet);
                            busyRooms++;
                            return true;
                        }
                    }
                    counter++;
                }
                else return false;
            }
            return true;
        }

        public bool ReleasePet()
        {
            int i = numberOfRooms / 2 + 1;
            int counter = 0;
            while (counter < numberOfRooms)
            {
                if (busyRooms != 0)
                {
                    if (counter % 2 == 0)
                    {
                        if (rooms[i - counter].IsEmpty == false)
                        {
                            rooms[i - counter] = new Room(i - counter, true);
                            pets.Remove(rooms[i - counter].Pet);
                            busyRooms--;
                            return true;
                        }
                        else if (rooms[i + counter].IsEmpty == false)
                        {
                            rooms[i + counter] = new Room(i + counter, true);
                            pets.Remove(rooms[i + counter].Pet);
                            busyRooms--;
                            return true;
                        }
                    }
                    counter++;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}