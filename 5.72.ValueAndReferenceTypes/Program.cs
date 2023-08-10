using System;

namespace _4._72.ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 200;
            System.Diagnostics.Debug.WriteLine(i);
            ChangeValue(i);
            System.Diagnostics.Debug.WriteLine(i);

            Person p = new Person();
            p.name = "Old Name";
            ChangeReferenceType(p);
            System.Diagnostics.Debug.WriteLine(p.name);


        }

        static void ChangeValue(int num)
        {
            num = 500;
            System.Diagnostics.Debug.WriteLine(num);
        }

        public class Person
        {
            public string name;
        }

        static void ChangeReferenceType(Person person)
        {
            person.name = "New Name";
        }
    }
}