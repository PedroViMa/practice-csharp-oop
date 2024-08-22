using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    internal class Student
    {
        public string RollNumber { get; }
        public string Name { get; }
        public string Grade { get; }
        private  readonly List<double> marks;

        public Student(string rollNumber, string name, string grade)
        {
            RollNumber = rollNumber;
            Name = name;
            Grade = grade;
            marks = new List<double>();
        }

        public void ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------------------")
                .AppendLine($"Student: {Name}")
                .AppendLine($"Roll Number: {RollNumber}")
                .AppendLine($"Grade: {Grade}");
            Console.Write(sb.ToString());
        }

        public double AverageGrade()
        {
            if (!marks.Any())
            {
                throw new ArgumentNullException();
            }

            return marks.Average();
        }

        public void AddGrades()
        {
            // TODO: method to ask user to insert the student grades.
        }
    }
}
