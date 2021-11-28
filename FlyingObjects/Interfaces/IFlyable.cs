using FlyingObjects.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyingObjects.Interfaces
{
    interface IFlyable
    {
        public double GetFlyTime(Coordinate newPoint);

        public void FlyTo(Coordinate newPoint);
    }
}
