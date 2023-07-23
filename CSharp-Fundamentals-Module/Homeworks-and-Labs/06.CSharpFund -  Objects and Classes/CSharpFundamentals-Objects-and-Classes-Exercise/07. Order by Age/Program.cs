/*
Lewis 123456 20
Tesla 123456 34
James 78911 15
Robert 523444 11
Jennifer 345244 13
Mary 52424678 22
Patricia 567343 54
End
*/

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                 args = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string personName = args[0];
                string personID = args[1];
                int personAge = int.Parse(args[2]);

                Person person = people.FirstOrDefault(p => p.ID == personID);
                if (person != null)
                {
                    person.Name = personName;
                    person.Age = personAge;
                }
                else
                {
                    person = new Person(personName, personID, personAge);
                    people.Add(person);
                }
            }

            foreach (Person person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("{0} with ID: {1} is {2} years old.", this.Name, this.ID, this.Age);
        }
    }
}