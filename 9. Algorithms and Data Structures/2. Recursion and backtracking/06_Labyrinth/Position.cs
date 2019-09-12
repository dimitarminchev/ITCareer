using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Labyrinth
{
    public class Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static bool operator ==(Position left, Position right)
        {
            if (left.X == right.X && left.Y == right.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Position left, Position right)
        {
            if (left.X == right.X && left.Y == right.Y)
            {
                return false;
            }
            return true;
        }
    }
}
