namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int countOfStudents = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentInformation = Console
                    .ReadLine()
                    .Split(' ');

                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                float grade = float.Parse(studentInformation[2]);

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public float Grade { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}: {2:F2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}