using System;

namespace Inheritance.Vehicles
{
    internal class Car : Vehicle
    {
        public Car(string make, string model, string year) 
            : base(make, model, year)
        {
        }

        public override void StartEngine()
        {
            Console.WriteLine("ruuuum!");
        }

        public override string ToString()
        {
            return "This is a car\n" +
                base.ToString();
        }
    }
}
