namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classroom classroom = new Classroom();

            classroom.AddStudent(new Student("00410049", 
                "Pedro", "9th"));
            classroom.AddStudent(new Student("00414549",
                "Juan", "8th"));
            classroom.AddStudent(new Student("00511249",
                "Raul", "7th"));

            classroom.ListStudents();

            classroom.RemoveStudent();

            classroom.ListStudents();
        }
    }
}
