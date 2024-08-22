using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    internal class Classroom
    {
        private readonly List<Student> Students;

        public Classroom()
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent()
        {
            Console.WriteLine("Please enter the name of the sutendt to be removed:");
            string name = Console.ReadLine();

            foreach(Student student in Students)
            {
                if(name.Equals(student.Name))
                {
                    Students.Remove(student);
                    return;
                }
            }

            Console.WriteLine("None student was removed.");
        }

        public void ListStudents()
        {
            if (!Students.Any())
            {
                throw new ArgumentNullException();
            }

            foreach (Student student in Students)
            {
                student.ShowInfo();
            }
        }
    }
}
