using AutoPark.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Entities
{
    class Bus : Vehicle
    {
        public int passengerСapacity;
        public Bus(Engine engine, Transmission transmission, Chassis chassis, int passengerСapacity)
            : base(engine, transmission, chassis)
        {
            this.passengerСapacity = passengerСapacity;
        }

        public override string GetFullInfo()
        {
            return "This bus " + base.GetFullInfo() + " and passenger capcity: " + passengerСapacity + " people.";
        }
    }
}
