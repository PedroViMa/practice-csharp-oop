namespace Exercise2
{
    internal class Employee
    {
        protected string Id { get; set; }
        protected string Name { get; set; }
        protected double Salary { get; set; }

        public Employee(string id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void ChangeSalary(double salary)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee ID: {Id}\n" +
                $"Name: {Name}\n" +
                $"Salary: {Salary.ToString("C")} \n";
        }

    }
}
