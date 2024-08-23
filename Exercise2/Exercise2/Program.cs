using System;
using System.Collections.Generic;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Developer("001", "Pedro", 10000, ".Net"),
                new Manager("002", "Jesus", 30000, "Portfolio Manager")
            };



            foreach (Employee employee in employees)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine(employee.ToString());
                (employee as IWorkable).Work();
            }
            Console.WriteLine();
        }
    }
}
