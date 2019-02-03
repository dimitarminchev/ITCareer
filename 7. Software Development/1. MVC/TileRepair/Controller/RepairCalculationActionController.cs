using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileRepair.Model;
using TileRepair.View;

namespace TileRepair.Controller
{
    class RepairCalculationActionController
    {
        RepairCalculation repair;
        Display display;

        public RepairCalculationActionController()
        {
            this.display = new Display();
            this.repair = new RepairCalculation(this.display.GroundSide, this.display.TileWidth,
                this.display.TileLength, this.display.BenchWidth, this.display.BenchLength);
            double[] result = new double[2];
            result = repair.Calculations();
            this.display.NumberOfTiles = result[0];
            this.display.NeededTime = result[1];
            this.display.Print();
        }
    }
}
