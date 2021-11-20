using AutoPark.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark
{
    abstract class Vehicle
    {
        public Engine engine;
        public Transmission transmission;
        public Chassis chassis;

        public Vehicle(Engine engine, Transmission transmission, Chassis chassis)
        {
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
        }

        public virtual string GetFullInfo()
        {
            return "This vehicle has " + engine.power + " engine, " 
                + transmission.madeBy + " transmission, " + chassis.loadCapacity + " chassis capacity";
        }
    }
}
