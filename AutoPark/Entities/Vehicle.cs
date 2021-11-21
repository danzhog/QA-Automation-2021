using AutoPark.Modules;

namespace AutoPark
{
    abstract class Vehicle
    {
        public string mark;
        public string model;
        public Engine engine;
        public Transmission transmission;
        public Chassis chassis;

        public Vehicle(string mark, string model, Engine engine, Transmission transmission, Chassis chassis)
        {
            this.mark = mark;
            this.model = model;
            this.engine = engine;
            this.transmission = transmission;
            this.chassis = chassis;
        }

        public virtual string GetFullInfo()
        {
            return mark + " " + model + "\nEngine characteristics: " + engine.GetInfo() 
                + "\nTransmission characteristics: " + transmission.GetInfo()
                + "\nChassis characteristics: " + chassis.GetInfo();
        }
    }
}