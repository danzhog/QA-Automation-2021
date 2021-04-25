using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFleet AutoPark = new VehicleFleet(5); //создать автопарк размеров 5 транспортных средств

            AutoPark.AddVehicleToFleet(new Bus("МАЗ-251", 12.0, "hydromechanical", 134, 53));
            AutoPark.AddVehicleToFleet(new Car("Volkswagen Golf", 1.6, "mechanical", 170, "hatchback"));
            AutoPark.AddVehicleToFleet(new Truck("Volvo VNL", 12.8, "robotic", 103, 100));
            AutoPark.AddVehicleToFleet(new Motorcycle("Ducati Scrambler", 0.8, "mechanical", 300, 2));
            AutoPark.PrintInfoAboutAllVehicles();
        }
    }
}
