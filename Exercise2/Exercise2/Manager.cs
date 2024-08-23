using System;

namespace Exercise2
{
    internal class Manager : Employee, IWorkable
    {
        public string ManagmentType { get; set; }

        public Manager(string id, string name, double salary, string type) 
            : base(id, name, salary)
        {
            ManagmentType = type;
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"Role: {ManagmentType}\n";
        }

        public void Work()
        {
            Console.WriteLine("Managing the team.");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Going for a break...");
        }
    }
}
