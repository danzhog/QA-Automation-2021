using AutoPark.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Modules
{
    class Engine
    {
        public int power;
        public int volume;
        public string serialNumber;
        public EngineType engineType;

        public Engine(int power, int volume, string serialNumber, EngineType engineType) 
        {
            this.power = power;
            this.volume = volume;
            this.serialNumber = serialNumber;
            this.engineType = engineType;
        }
    }
}
