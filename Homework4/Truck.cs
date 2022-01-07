using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class Truck: Vehicle
    {
        public int MaximumLoadedWeight { get; set; } //максимально допустимая масса загруженного грузовика 

        public Truck(string modelName, double engineCapacity, string transmissionType, int maxSpeed, int maximumLoadedWeight):
            base(modelName, engineCapacity, transmissionType, maxSpeed)
        {
            MaximumLoadedWeight = maximumLoadedWeight;
        }

        public override string GetFullInfo() //вывод всей информации о ТС 
        {
            return "Truck " + ModelName + " with an Engine Capacity of " + EngineCapacity + " liters, Transmission Type of "
                + TransmissionType + ", Maximum Speed of " + MaxSpeed + "km/h and MaximumLoadedWeight of up to "
                + MaximumLoadedWeight + " kg";
        }
    }
}
