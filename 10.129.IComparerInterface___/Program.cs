using System.Collections;

namespace _10._129.IComparerInterface___
{
    class Employee
    {
        public int id;
    }

    internal class Program : IComparer
    {
        static void Main(string[] args)
        {
            // I added this code myself in order to output to console
            Employee employee1 = new Employee { id = 3 };
            Employee employee2 = new Employee { id = 2 };

            ArrayList employees = new ArrayList();
            employees.Add(employee1);
            employees.Add(employee2);

            employees.Sort(new Program());

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Employee ID: " + employee.id);
            }
            ///////////////////////////////////////////////////
        }

        public int Compare(object? x, object? y)
        {
            Employee employee1 = (Employee)x;
            Employee employee2 = (Employee)y;
            return employee1.id.CompareTo(employee2.id);
        }
    }
}