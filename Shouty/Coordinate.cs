using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shouty
{
    public class Coordinate
    {
        private readonly int xCoord;
        private readonly int yCoord;

        public Coordinate(int xCoord, int yCoord)
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public int DistanceFrom(Coordinate other)
        {
          // TODO: actually calculate distance beteen the coordinates.
          //       e.g. return Math.Abs(xCoord - other.xCoord);

          return (int)Math.Sqrt(
              Math.Pow(Math.Abs(xCoord - other.xCoord),2)
              +
              Math.Pow(Math.Abs(yCoord - other.yCoord),2)
          );
        }
    }
}
