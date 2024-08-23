using System;

namespace Inheritance.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string make, string model, string year) 
            : base(make, model, year)
        {
        }

        public override void StartEngine()
        {
            Console.WriteLine("rumrum!");
        }

        public override string ToString()
        {
            return "This is a motorcycle\n" +
                base.ToString();
        }
    }
}
