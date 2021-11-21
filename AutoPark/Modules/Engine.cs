using AutoPark.Enums;
using System;
namespace AutoPark.Modules
{
    class Engine
    {
        public int power;
        public int volume;
        public string serialNumber;
        public EngineType type;

        public Engine(int power, int volume, string serialNumber, EngineType type) 
        {
            this.power = power;
            this.volume = volume;
            this.serialNumber = serialNumber;
            this.type = type;
        }

        public string GetInfo()
        {
            return $"power: {power} hp, volume: {volume} litres " +
                $"type: {type}, serial number: {serialNumber}";
        }
    }
}