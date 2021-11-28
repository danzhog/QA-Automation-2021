using System;
using System.Collections.Generic;
using System.Text;

namespace FlyingObjects.Entities
{
    public struct Coordinate
    {
        public double x;
        public double y;
        public double z;

        public Coordinate(double x, double y, double z)
        {
            if (x < 0 || y < 0 || z < 0)
            {
                throw new ArgumentOutOfRangeException("x,y,z coordinates must be > 0");
            }

            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double CalculateDistance(Coordinate newCoordinate)
        {
            return Math.Sqrt(Math.Pow(newCoordinate.x - x, 2) +
                             Math.Pow(newCoordinate.y - y, 2) +
                             Math.Pow(newCoordinate.z - z, 2)); 
        }
    }
}
