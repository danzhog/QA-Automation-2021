namespace AutoPark.Modules
{
    class Chassis
    {
        public byte numberOfWheels;
        public int serialNumber;
        public int loadCapacity;

        public Chassis(byte numberOfWheels, int serialNumber, int loadCapacity)
        {
            this.numberOfWheels = numberOfWheels;
            this.serialNumber = serialNumber;
            this.loadCapacity = loadCapacity;
        }

        public string GetInfo()
        {
            return $"{numberOfWheels} wheels, load capaity: {loadCapacity} kg, " +
                $"serial number: {serialNumber}";
        }
    }
}