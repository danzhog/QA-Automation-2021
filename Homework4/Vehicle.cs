

namespace Homework4
{
    abstract class Vehicle
    {
        public string ModelName { get; set; } //модель ТС
        public double EngineCapacity { get; set; } //объем двигателя
        public string TransmissionType { get; set; } //тип трансмиссии 
        public int MaxSpeed { get; set; } //максимальная скорость

        public Vehicle(string modelName, double engineCapacity, string transmissionType, int maxSpeed)
        {
            ModelName = modelName;
            EngineCapacity = engineCapacity;
            TransmissionType = transmissionType;
            MaxSpeed = maxSpeed;
        }

        public virtual string GetFullInfo() //вывод всей информации о ТС 
        {
            return "Engine capacity = " + EngineCapacity + " Transmission Type = " + TransmissionType
                + " Maximum Speed = " + MaxSpeed;
        }
    }
}
