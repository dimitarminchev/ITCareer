using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileRepair.Model
{
    class RepairCalculation
    {
        private double groundSide;
        private double tileWidth;
        private double tileLength;
        private double benchWidth;
        private double benchLength;

        public double GroundSide
        {
            get { return groundSide; }
            set { groundSide = value; }
        }

        public double TileWidth
        {
            get { return tileWidth; }
            set { tileWidth = value; }
        }

        public double TileLength
        {
            get { return tileLength; }
            set { tileLength = value; }
        }

        public double BenchWidth
        {
            get { return benchWidth; }
            set { benchWidth = value; }
        }

        public double BenchLength
        {
            get { return benchLength; }
            set { benchLength = value; }
        }

        public RepairCalculation(double groundSide, double tileWidth, double tileLength, double benchWidth, double benchLength)
        {
            this.groundSide = groundSide;
            this.tileWidth = tileWidth;
            this.tileLength = tileLength;
            this.benchWidth = benchWidth;
            this.benchLength = benchLength;
        }

        public double[] Calculations()
        {
            double[] toReturn = new double[2];
            double groundArea = this.groundSide * this.groundSide;
            double benchArea = this.benchLength * this.benchWidth;
            double areaToCover = groundArea - benchArea;
            double tileArea = this.tileLength * this.tileWidth;
            double tilesNeeded = areaToCover / tileArea;
            double timeNeeded = tilesNeeded * 0.2;
            toReturn[0] = tilesNeeded;
            toReturn[1] = timeNeeded;
            return toReturn;
        }
    }
}
