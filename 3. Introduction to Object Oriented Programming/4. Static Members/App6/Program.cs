using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Камиони
            List<Truck> trucks = new List<Truck>();
            var line = Console.ReadLine().Split(';');
            foreach (var item in line)
            if(!String.IsNullOrEmpty(item))
            {
                var parts = item.Split('=');
                trucks.Add( new Truck() { Name = parts[0], Capacity = int.Parse(parts[1]) });
            }

            // Товари
            List<Freight> freights = new List<Freight>();
            line = Console.ReadLine().Split(';');
            foreach (var item in line)
            if (!String.IsNullOrEmpty(item))
            {
                var parts = item.Split('=');
                freights.Add(new Freight() { Name = parts[0], Weight = int.Parse(parts[1]) });
            }

            // Товарене на камионите
            string cmd;
            do
            {
                cmd = Console.ReadLine();
                if (cmd != "END")
                {
                    var parts = cmd.Split(' ');
                    var truck = trucks.Where(x => x.Name == parts[0]).First();
                    var treight = freights.Where(x => x.Name == parts[1]).First();
                    truck.Add(treight);
                }
            }
            while (cmd != "END");

            // Печат
            foreach (var truck in trucks) truck.Print();
        }
    }
}
