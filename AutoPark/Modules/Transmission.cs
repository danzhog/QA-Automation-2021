using AutoPark.Enums;
using System;
namespace AutoPark.Modules
{
    class Transmission
    {
        public string madeBy;
        public byte numberOfGears;
        public TransmissionType type;

        public Transmission(byte numberOfGears, string madeBy, TransmissionType type)
        {
            this.numberOfGears = numberOfGears;
            this.madeBy = madeBy;
            this.type = type;
        }

        public string GetInfo()
        {
            return $"{numberOfGears} gears, type: {type}, " +
                $"is made by {madeBy}";
        }
    }
}