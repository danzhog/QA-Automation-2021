using AutoPark.Modules;

namespace AutoPark.Entities
{
    class Truck : Vehicle
    {
        public int loadСapacity;
        public Truck(string mark, string model, Engine engine, Transmission transmission, Chassis chassis, int loadСapacity)
            : base(mark, model, engine, transmission, chassis) 
        {
            this.loadСapacity = loadСapacity;
        }

        public override string GetFullInfo()
        {
            return "Truck " + base.GetFullInfo() + " and load capacity: " + loadСapacity;
        }
    }
}