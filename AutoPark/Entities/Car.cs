using AutoPark.Enums;
using AutoPark.Modules;

namespace AutoPark.Entities
{
    class Car : Vehicle
    {
        public BodyConfiguration bodyConfiguration;
        public Car(string mark, string model, Engine engine, Transmission transmission, Chassis chassis, BodyConfiguration bodyConfiguration)
            : base(mark, model, engine, transmission, chassis)
        {
            this.bodyConfiguration = bodyConfiguration;
        }

        public override string GetFullInfo()
        {
            return "Car " + base.GetFullInfo() + " and car body configuration: " + bodyConfiguration;
        }
    }
}