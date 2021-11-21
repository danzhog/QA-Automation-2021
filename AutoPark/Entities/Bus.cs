using AutoPark.Modules;

namespace AutoPark.Entities
{
    class Bus : Vehicle
    {
        public int passengerСapacity;
        public Bus(string mark, string model, Engine engine, Transmission transmission, Chassis chassis, int passengerСapacity)
            : base(mark, model, engine, transmission, chassis)
        {
            this.passengerСapacity = passengerСapacity;
        }

        public override string GetFullInfo()
        {
            return "Bus " + base.GetFullInfo() + " and passenger capcity: " + passengerСapacity + " people.";
        }
    }
}