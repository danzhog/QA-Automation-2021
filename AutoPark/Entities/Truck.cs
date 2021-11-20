using AutoPark.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Entities
{
    class Truck : Vehicle
    {
        public int loadСapacity;
        public Truck(Engine engine, Transmission transmission, Chassis chassis, int loadСapacity)
            : base(engine, transmission, chassis) 
        {
            this.loadСapacity = loadСapacity;
        }

        public override string GetFullInfo()
        {
            return "This truck " + base.GetFullInfo() + " and load capacity: " + loadСapacity;
        }
    }
}
