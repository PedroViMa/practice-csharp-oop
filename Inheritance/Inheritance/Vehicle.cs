namespace Inheritance.Vehicles
{
    internal abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public Vehicle(string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n";
        }

        public abstract void StartEngine();
    }
}
