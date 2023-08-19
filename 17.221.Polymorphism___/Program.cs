using System.Diagnostics;

namespace _17._221.Polymorphism___
{
    public class Class1
    {
        public virtual void Example()
        {
            Debug.WriteLine("Class 1's Example method");
        }
    }

    public class Class2 : Class1
    {
        public override void Example()
        {
            Debug.WriteLine("Class 2's Example method");
        }
    }

    public class Class3
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class2();
            obj.Example();
        }
    }
}