using System;

namespace Homework4
{
    class VehicleFleet
    {
        private int FleetSize;
        private Vehicle[] _vehicles = null;
        private int Counter = 0;

        public VehicleFleet(int size)
        {
            FleetSize = size;
            _vehicles = new Vehicle[size];
        }

        public void AddVehicleToFleet(Vehicle vehicle)
        {
            if (Counter < FleetSize)
            {
                _vehicles[Counter] = vehicle;
                Counter++;
            }
            else
            {
                Console.WriteLine("Fleet is full");
            }
        }

        public void PrintInfoAboutAllVehicles()
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle != null)
                {
                    Console.WriteLine(vehicle.GetFullInfo());
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
