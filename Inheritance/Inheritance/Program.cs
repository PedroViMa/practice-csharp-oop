using System;
using System.Collections.Generic;
using Inheritance.Vehicles;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>()
            {
                new Car("Make", "Model", "year"),
                new Motorcycle("Make1", "Model2", "year1")
            };

            foreach (var vehicle in list)
            {
                Console.WriteLine("--------------------");
                Console.Write(vehicle.ToString());
                vehicle.StartEngine();
            }
        }
    }
}
