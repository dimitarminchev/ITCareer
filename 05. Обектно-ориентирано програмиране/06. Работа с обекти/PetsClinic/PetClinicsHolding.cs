namespace PetsClinic
{
    public class PetClinicsHolding
    {
        List<Clinic> clinics = new List<Clinic>();

        List<Pet> pets = new List<Pet>();

        public void AddClinic(Clinic clinic)
        {
            clinics.Add(clinic);
        }

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }

        public bool AddPetInClinic(string petName, string clinicName)
        {
            if (pets.Select(x => x.Name).Contains(petName) && clinics.Select(x => x.Name).Contains(clinicName))
            {
                Clinic currentClinic = clinics.Where(x => x.Name == clinicName).First();
                return currentClinic.AddPet(pets.Where(x => x.Name == petName).First());
            }
            else return false;
        }
        public bool RemovePetFromClinic(string clinicName)
        {
            if (clinics.Select(x => x.Name).Contains(clinicName))
            {
                Clinic currentClinic = clinics.Where(x => x.Name == clinicName).First();
                return currentClinic.ReleasePet();
            }
            else return false;
        }

        public bool HasEmptyRooms(string clinicName)
        {
            Clinic currentClinic = clinics.Where(x => x.Name == clinicName).First();
            if (currentClinic.BusyRooms < currentClinic.NumberOfRooms)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintClinic(string clinicName)
        {
            Clinic currentClinic = clinics.Where(x => x.Name == clinicName).First();
            for (int i = 1; i <= currentClinic.NumberOfRooms; i++)
            {
                if (currentClinic.rooms[i].IsEmpty)
                {
                    Console.WriteLine("Room Empty");
                }
                else
                {
                    Console.WriteLine(currentClinic.rooms[i].Pet.Name + " " + currentClinic.rooms[i].Pet.Age + " " + currentClinic.rooms[i].Pet.Type);
                }
            }
        }

        public void PrintRoom(string clinicName, int roomNumber)
        {
            Clinic currentClinic = clinics.Where(x => x.Name == clinicName).First();
            Room room = currentClinic.rooms[roomNumber];
            Console.WriteLine(room.Pet.Name + " " + room.Pet.Age + " " + room.Pet.Type);
        }
    }
}