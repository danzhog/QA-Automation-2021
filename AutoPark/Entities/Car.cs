using AutoPark.Enums;
using AutoPark.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoPark.Entities
{
    class Car : Vehicle
    {
        public BodyConfiguration bodyConfiguration;
        public Car(Engine engine, Transmission transmission, Chassis chassis, BodyConfiguration bodyConfiguration)
            : base(engine, transmission, chassis)
        {
            this.bodyConfiguration = bodyConfiguration;
        }

        public override string GetFullInfo()
        {
            return "This car " + base.GetFullInfo() + " and car body configuration: " + bodyConfiguration;
        }
    }
}
