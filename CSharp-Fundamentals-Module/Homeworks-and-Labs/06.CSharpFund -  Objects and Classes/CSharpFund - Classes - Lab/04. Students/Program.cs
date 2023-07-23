namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); // create List from our data type so to have a collection with properties of our data type
            AddStudentToCollectionOfStudents(students);

            string nameOfCity = Console.ReadLine(); // read from the console name of city

            List<Student> filterStudents = students // define a List which will contain filtered cities
                .Where(s => s.HomeTown == nameOfCity) // method with lambda expression which list the student if the expression is True 
                .ToList(); // make the variable a collection

            Student.PrintFinalResult(filterStudents); // invoke a method from our data type
        }

        static void AddStudentToCollectionOfStudents(List<Student> students)
        {
            string input; // define input
            while ((input = Console.ReadLine()) != "end") // read input from the Console and checks if is is different from "end"
            {
                string[] arguments = input // split the input into arguments[commands]
                    .Split(' ');

                string firstName = arguments[0]; // list first element of index[0] which is our first name of the Student
                string lastName = arguments[1]; // list second element of index[1] which is our last name of the Student
                int age = int.Parse(arguments[2]); // list third element of index[2] which is our age of the Student 
                string homeTown = arguments[3]; // list fourth element of index[3] which is our home town of the Student

                Student student = new Student(firstName, lastName, age, homeTown); // create an object[instance] of our data type for accessing our properties 

                students.Add(student); // add to the collection current object[instance] student
            }
        }
    }

    public class Student // define a class with data type Student
    {
        public Student(string firstName, string lastName, int age, string homeTown) // define a constructor with 4 parameter's
        {
            FirstName = firstName; // list variable firstName to prop FirstName
            LastName = lastName; // list variable lastName to prop LastName
            Age = age; // list variable age to prop Age
            HomeTown = homeTown; // list variable homeTown to prop HomeTown
        }
        public string FirstName { get; set; } // define a property of type string 

        public string LastName { get; set; } // define a property of type string

        public int Age { get; set; } // define a property of type ing

        public string HomeTown { get; set; } // define a property of type string

        public static void PrintFinalResult(List<Student> filteredStudents) // create method which will print filtered students
        {
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old."); // print final result
            }
        }
    }
}