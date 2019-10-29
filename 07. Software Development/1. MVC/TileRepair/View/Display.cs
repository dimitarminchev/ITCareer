using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileRepair.View
{
    class Display
    {
        public double GroundSide { get; set; }
        public double TileWidth { get; set; }
        public double TileLength { get; set; }
        public double BenchWidth { get; set; }
        public double BenchLength { get; set; }
        public double NumberOfTiles { get; set; }
        public double NeededTime { get; set; }

        public Display()
        {
            this.GroundSide = 0;
            this.TileWidth = 0;
            this.TileLength = 0;
            this.BenchWidth = 0;
            this.BenchLength = 0;
            this.NumberOfTiles = 0;
            this.NeededTime = 0;
            GetValues();
        }

        private void GetValues()
        {
            this.GroundSide = double.Parse(Console.ReadLine());
            this.TileWidth = double.Parse(Console.ReadLine());
            this.TileLength = double.Parse(Console.ReadLine());
            this.BenchWidth = double.Parse(Console.ReadLine());
            this.BenchLength = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("{0}", this.NumberOfTiles);
            Console.WriteLine("{0}", this.NeededTime);
        }
    }
}
