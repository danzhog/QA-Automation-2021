﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    class Car: Vehicle
    {
        public string CarBodyStyle { get; set; } //тип автомобильного кузова

        public Car(string modelName, double engineCapacity, string transmissionType, int maxSpeed, string carBodyStyle):
            base(modelName, engineCapacity, transmissionType, maxSpeed)
        {
            CarBodyStyle = carBodyStyle;
        }

        public override string GetFullInfo() //вывод всей информации о ТС
        {
            return "Bus " + ModelName + " with an Engine Capacity of " + EngineCapacity + " liters, Transmission Type of "
                + TransmissionType + ", Maximum Speed of " + MaxSpeed + "km/h and Car Body Style of "
                + CarBodyStyle;
        }
    }
}
