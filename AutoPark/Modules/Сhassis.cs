using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Modules
{
    class Chassis
    {
        public byte numberOfWheels;
        public int serialNumber;
        public int loadCapacity;

        public Chassis(byte numberOfWheels, int serialNumber, int loadCapacity)
        {
            this.numberOfWheels = numberOfWheels;
            this.serialNumber = serialNumber;
            this.loadCapacity = loadCapacity;
        }
    }
}
