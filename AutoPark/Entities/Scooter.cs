using AutoPark.Modules;

namespace AutoPark.Entities
{
    class Scooter : Vehicle
    {
        public bool hasTrunk;
        public Scooter(string mark, string model, Engine engine, Transmission transmission, Chassis chassis, bool hasTrunk)
            : base(mark, model, engine, transmission, chassis)
        {
            this.hasTrunk = hasTrunk;
        }

        public override string GetFullInfo()
        {
            return "Scooter " + base.GetFullInfo() + ScooterHasTrunk(hasTrunk);
        }

        private string ScooterHasTrunk(bool hasTrunk)
        {
            if (hasTrunk is true)
                return " and has trunk.";
            else
                return " and has NOT trunk.";
        }

    }
}