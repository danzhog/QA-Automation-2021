using AutoPark.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Modules
{
    class Transmission
    {
        public string madeBy;
        public byte numberOfGears;
        public TransmissionType transmissionType;

        public Transmission(byte numberOfGears, string madeBy, TransmissionType transmissionType)
        {
            this.numberOfGears = numberOfGears;
            this.madeBy = madeBy;
            this.transmissionType = transmissionType;
        }
    }
}
