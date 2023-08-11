using System.Diagnostics;


namespace _10._138.VirtualMethods___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass childClass = new ChildClass();
            childClass.PrintMessage();
        }
    }

    class BaseClass
    {
        public virtual void PrintMessage()
        {
            Debug.WriteLine("Hello World");
        }
    }

    class ChildClass : BaseClass
    {
        public override void PrintMessage()
        {
            Debug.WriteLine("Goodbye World");
            base.PrintMessage();
        }
    }
}