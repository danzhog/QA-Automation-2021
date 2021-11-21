using System;
using AutoPark.Modules;
using AutoPark.Enums;
using AutoPark.Entities;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine V8BTurbo = new Engine(800, 200, "ABCD0123", EngineType.Petrol);
            Transmission AudiTransmission123 = new Transmission(7, "Audi Concern", TransmissionType.Automatic);
            Chassis AudiChassis321 = new Chassis(4, 123456789, 2300);

            Bus AudiBus123 = new Bus("Audi", "Bus123", V8BTurbo, AudiTransmission123, AudiChassis321, 29);
            Console.WriteLine(AudiBus123.GetFullInfo() + "\n");

            Car VAZ2108 = new Car("VAZ", "2108", V8BTurbo, AudiTransmission123, AudiChassis321, BodyConfiguration.Hatchback);
            Console.WriteLine(VAZ2108.GetFullInfo() + "\n");

            Truck MercedesBenzSprinter = new Truck("Mercedes-Benz", "Sprinter", V8BTurbo, AudiTransmission123, AudiChassis321, 3400);
            Console.WriteLine(MercedesBenzSprinter.GetFullInfo() + "\n");

            Scooter DucattiMonster = new Scooter("Ducatti", "Monster", V8BTurbo, AudiTransmission123, AudiChassis321, false);
            Console.WriteLine(DucattiMonster.GetFullInfo() + "\n");
        }
    }
}