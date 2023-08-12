namespace _05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input
                    .Split(' ');

                string firstName = arguments[0];
                string lastName = arguments[1];
                int age = int.Parse(arguments[2]);
                string homeTown = arguments[3];

                bool exist = DoesItExist(firstName, lastName, students);

                if (exist)
                {
                    Student newStudent = OverWriteStudentInformation(students, firstName, lastName);

                    newStudent.FirstName = firstName;
                    newStudent.LastName = lastName;
                    newStudent.Age = age;
                    newStudent.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                    students.Add(student);
                }
            }

            string nameOfCity = Console.ReadLine();

            List<Student> filterCities = students
                .Where(s => s.HomeTown == nameOfCity)
                .ToList();

            foreach (Student student in filterCities)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        static Student OverWriteStudentInformation(List<Student> students, string firstName, string lastName)
        {
            Student newStudent = new Student();
        
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    newStudent = student;
                }
            }
        
            return newStudent;
        }

        static bool DoesItExist(string firstName, string lastName, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}