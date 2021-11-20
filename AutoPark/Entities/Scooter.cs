using AutoPark.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Entities
{
    class Scooter : Vehicle
    {
        public bool hasTrunk;
        public Scooter(Engine engine, Transmission transmission, Chassis chassis, bool hasTrunk)
            : base(engine, transmission, chassis)
        {
            this.hasTrunk = hasTrunk;
        }

        public override string GetFullInfo()
        {
            return "This scooter " + base.GetFullInfo() + ScooterHasTrunk(hasTrunk);
        }

        private static string ScooterHasTrunk(bool hasTrunk)
        {
            if (hasTrunk is true)
                return " and has trunk.";
            else
                return " and has NOT trunk.";
        }

    }
}
