namespace _17._219.Abstraction___
{

    // This is the same example but having Class1 inherit from AbstractClass to then be instantiated. This works.
    public abstract class AbstractClass { }

    public class Class1 : AbstractClass
    {
        static void Main(string[] args)
        {
            Class1 example = new Class1();
        }
    }

    // This is an example of an Abstract Class that cannot be instantiated directly. 

    //public abstract class AbstractClass { }

    //public class Class1
    //{
    //    static void Main(string[] args)
    //    {
    //        AbstractClass example = new AbstractClass();
    //    }
    //}
}