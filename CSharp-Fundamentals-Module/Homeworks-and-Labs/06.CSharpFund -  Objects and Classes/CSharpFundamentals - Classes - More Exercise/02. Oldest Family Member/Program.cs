namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfPeople; n++)
            {
                string[] dataForOnePerson = Console.ReadLine().Split();
                string personName = dataForOnePerson[0];
                int personAge = int.Parse(dataForOnePerson[1]);

                Person person = new Person(personName, personAge);
                family.AddMember(person);
            }

            if (family.People.Count > 0)
            {
                Person oldestMember = family.GetOldestMember();
                Console.WriteLine("{0} {1}", oldestMember.Name, oldestMember.Age);
            }
        }
    }

    public class Family
    {

        public Family()
        {
            this.People = new List<Person>();
        }

        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            string oldestPersonName = string.Empty;
            int oldestPersonAge = 0;
            int bestAge = int.MinValue;

            foreach (Person value in this.People)
            {
                int currentAge = value.Age;
                if (currentAge > bestAge)
                {
                    bestAge = currentAge;
                    oldestPersonName = value.Name;
                    oldestPersonAge = bestAge;
                }
            }

            Person oldestPerson = new Person(oldestPersonName, oldestPersonAge);

            return oldestPerson;
        }
    }

    public class Person
    {

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}