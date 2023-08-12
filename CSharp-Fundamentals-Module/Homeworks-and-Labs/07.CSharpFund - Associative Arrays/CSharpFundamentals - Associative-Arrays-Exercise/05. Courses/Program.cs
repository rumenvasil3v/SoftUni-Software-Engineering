namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input
                    .Split(" : ");

                string courseName = arguments[0];
                string studentName = arguments[1];

                Course course = new Course(courseName);

                if (!courses.ContainsKey(course.Name))
                {
                    course.Student.Add(studentName);
                    courses[course.Name] = course;
                    continue;
                }

                //courses[course.Name].Student.Add(studentName);
                courses[course.Name].Student.Add(studentName);
            }

            foreach (Course course in courses.Values)
            {
                Console.WriteLine(course.ToString().Trim());
            }
        }
    }

    public class Course
    {

        public Course(string name)
        {
            this.Name = name;
            this.Student = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Student { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            result += $"{this.Name}: {this.Student.Count}\n";

            foreach (string student in Student)
            {
                result += $"-- {student}\n";
            }

            return result;
        }
    }
}