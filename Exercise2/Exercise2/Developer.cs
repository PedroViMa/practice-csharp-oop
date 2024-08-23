using System;

namespace Exercise2
{
    internal class Developer : Employee, IWorkable
    {
        public string Techology { get; set; }

        public Developer(string id, string name, double salary, string tech)
            : base(id, name, salary)
        {
            Techology = tech;
        }
        
        public override string ToString()
        {
            return base.ToString() + 
                $"Expertise: {Techology}\n";
        }

        public void Work()
        {
            Console.WriteLine($"Developing with {Techology}.");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Goinf for a coffee...");
        }
    }
}
