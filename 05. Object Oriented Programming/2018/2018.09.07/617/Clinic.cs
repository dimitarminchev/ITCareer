using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _617
{
    public class Clinic : Pet
    {
        private string name;
        private int[] rooms;

        private List<Pet> pets;

        public void Create(string name, int rooms)
        {
            this.name = name;
            this.rooms = new int[rooms];
        }

        public bool Add(Pet pet)
        {
            if (this.pets.Contains(pet)) return false;
            this.pets.Add(pet);
            return true;
        }

        public bool Release()
        {
            return true;
        }
        // public bool HasEmptyRooms ()
        // public void Print()
        // public void Print(int room)
    }
}
