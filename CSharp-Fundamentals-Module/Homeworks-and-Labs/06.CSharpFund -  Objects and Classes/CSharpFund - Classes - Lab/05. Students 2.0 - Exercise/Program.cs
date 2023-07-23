namespace _05._Students_2._0___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); // define a collection of our students which will keep all students

            AddStudentToCollection(students); // invoke our method for adding student to our collection
            Student.PrintFinalResult(students); // invoke our method in our class to print final result
        }

        static void AddStudentToCollection(List<Student> students)
        {
            string input; // define input
            while ((input = Console.ReadLine()) != "end") // until input != "end"
            {
                string[] arguments = input.Split(' '); // split our input into array of elements

                string firstName = arguments[0]; // first element of index[0] is firstName
                string lastName = arguments[1]; // second element of index[1] is lastName
                int age = int.Parse(arguments[2]); // third element of index[2] is age of student
                string homeTown = arguments[3]; // fourth element of index[3] is home town of student

                if (DoesExistSameStudent(students, firstName, lastName)) // check if it is exist the same student
                {
                    Student existStudent = OverWriteStudentInformation(students, firstName, lastName); // find the existing stundent and overwrite the information

                    existStudent.FirstName = firstName; // overwriting firstName
                    existStudent.LastName = lastName; // overwriting lastName
                    existStudent.Age = age; // overwriting age
                    existStudent.HomeTown = homeTown; // overwriting home town
                }
                else // doesn't exist same student so we add him to the collection
                {
                    Student student = new Student() // define an object[instance] of our data type
                    {
                        FirstName = firstName, // list firstName for our prop
                        LastName = lastName, // list lastName for our prop
                        Age = age, // list age for our prop
                        HomeTown = homeTown // list home town for our prop
                    };

                    students.Add(student); // add the object to our collection
                }
            }
        }

        static bool DoesExistSameStudent(List<Student> students, string firstName, string lastName) // define method
        {
            Student existSameStudent = new Student(); // define an object of our data type

            existSameStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName); // method for first same occurrence

            if (existSameStudent != null) // if it finds an occurrence return true and overwrite the student information
            {
                return true;
            }

            return false; // if it doesn't find an occurrence return false and add the student to our collection
        }

        static Student OverWriteStudentInformation(List<Student> students, string firstName, string lastName) // define method
        {
            Student existStudent = new Student(); // define an instance of our data type

            existStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName); // method for finding the same student

            return existStudent; // return the found student and overwrite the information about him
        }
    }

    public class Student // define a class Student
    {
        public string FirstName { get; set; } // prop of type string

        public string LastName { get; set; } // prop of type string

        public int Age { get; set; } // prop of type int

        public string HomeTown { get; set; } // prop of type string

        public static void PrintFinalResult(List<Student> students) // define method
        {
            string nameOfCity = Console.ReadLine(); // read the city name from the console

            List<Student> filterStudents = students // define List of type Student
                .Where(s => s.HomeTown == nameOfCity) // add students which are equal to the given city 
                .ToList(); // make the variable a collection

            foreach (Student student in filterStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old."); // print information about students
            }
        }
    }
}