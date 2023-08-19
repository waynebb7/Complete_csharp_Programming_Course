using System.Diagnostics;

namespace _22._271.LINQquery
{
    class Person
    {
        public string? Name;
        public int Age;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person(){Name="John", Age=24},
                new Person(){Name="Dave", Age=26},
                new Person(){Name="Bill", Age=54},
                new Person(){Name="Bob" , Age=46}
            };

            int oldestPerson = people.Select(x => x.Age).Max();
            Debug.WriteLine(oldestPerson);
        }
    }
}