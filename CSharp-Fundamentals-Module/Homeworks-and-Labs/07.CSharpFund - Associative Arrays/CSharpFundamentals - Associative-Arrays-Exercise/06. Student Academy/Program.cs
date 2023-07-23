namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            int pairOfRows = int.Parse(Console.ReadLine());
            for (int s = 0; s < pairOfRows; s++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                Student student = new Student(studentName);

                if (!students.ContainsKey(student.Name))
                {
                    student.Grade.Add(studentGrade);
                    students.Add(student.Name, student);
                    continue;
                }

                students[student.Name].Grade.Add(studentGrade);
            }

            foreach (Student student in students.Values)
            {
                if (student.Grade.Sum() / student.Grade.Count >= 4.50)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }

    public class Student
    {

        public Student(string name)
        {
            this.Name = name;
            this.Grade = new List<double>();
        }

        public string Name { get; set; }

        public List<double> Grade { get; set; }

        public double AverageGrade
        {
            get
            {
                return this.Grade.Sum() / this.Grade.Count;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} -> {1:F2}", this.Name, this.AverageGrade);
        }
    }
}