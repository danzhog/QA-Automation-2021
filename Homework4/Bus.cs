namespace Homework4
{
    class Bus: Vehicle
    {
        public int PassengerCapacity { get; set; } //пассажировместимость

        public Bus(string modelName, double engineCapacity, string transmissionType, int maxSpeed, int passengerCapacity):
            base(modelName, engineCapacity, transmissionType, maxSpeed)
        {
            PassengerCapacity = passengerCapacity;
        }

        public override string GetFullInfo() //вывод всей информации о ТС
        {
            return "Bus " + ModelName + " with an Engine Capacity of " + EngineCapacity + " liters, Transmission Type of "
                + TransmissionType + ", Maximum Speed of " + MaxSpeed + "km/h and Passenger Capacity of up to "
                + PassengerCapacity + " people";
        }
    }
}
