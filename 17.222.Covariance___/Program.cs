namespace _17._222.Covariance___
{
    public class ExampleClass { }
    public class DerivedExampleClass : ExampleClass { }

    public class MainClass
    {
        public static void ExampleMethod(ExampleClass ex) { }

        static void Main(string[] args)
        {
            {
                ExampleClass exampleClass = new ExampleClass();
                DerivedExampleClass derivedClass = new DerivedExampleClass();
                ExampleMethod(exampleClass);
                ExampleMethod(derivedClass);
            }
        }
    }
}