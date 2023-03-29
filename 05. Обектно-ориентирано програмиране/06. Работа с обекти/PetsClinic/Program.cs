namespace PetsClinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Pet pet;
            Clinic clinic;
            PetClinicsHolding clinics = new PetClinicsHolding();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToArray();
                switch (line[0])
                {
                    case "Create":
                        {
                            switch (line[1])
                            {
                                case "Pet":
                                    {
                                        pet = new Pet(line[2], int.Parse(line[3]), line[4]);
                                        Console.WriteLine(pet.Create(pet));
                                        clinics.AddPet(pet);
                                        break;
                                    }
                                case "Clinic":
                                    {
                                        clinic = new Clinic(line[2], int.Parse(line[3]));
                                        clinics.AddClinic(clinic);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "Add":
                        {
                            Console.WriteLine(clinics.AddPetInClinic(line[1], line[2]));
                            break;
                        }
                    case "Release":
                        {
                            Console.WriteLine(clinics.RemovePetFromClinic(line[1]));
                            break;
                        }
                    case "HasEmptyRooms":
                        {
                            Console.WriteLine(clinics.HasEmptyRooms(line[1]));
                            break;
                        }
                    case "Print":
                        {
                            if (line.Length == 3)
                            {
                                clinics.PrintRoom(line[1], int.Parse(line[2]));
                            }
                            else
                            {
                                clinics.PrintClinic(line[1]);
                            }
                            break;
                        }
                }
            }
        }
    }
}