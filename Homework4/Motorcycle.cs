using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class Motorcycle: Vehicle
    {
        public int NumberOfWheels { get; set; } //число колёс

        public Motorcycle(string modelName, double engineCapacity, string transmissionType, int maxSpeed, int numberOfWheels):
            base(modelName, engineCapacity, transmissionType, maxSpeed)
        {
            NumberOfWheels = numberOfWheels;
        }

        public override string GetFullInfo() //вывод всей информации о ТС
        {
            return "Car " + ModelName + " with an Engine Capacity of " + EngineCapacity + " liters, Transmission Type of "
                + TransmissionType + ", Maximum Speed of " + MaxSpeed + "km/h and has "
                + NumberOfWheels + " wheels";
        }
    }
}
