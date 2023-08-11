// Conditional Attribute that determines whether or not the compiler will include the method call.
#define CONDITION1

using System.Diagnostics;

namespace _9._111.Attributes
{
    internal class Program
    {
        [Obsolete("OldMethod is obsolete. Please use NewMethod instead")]
        static void OldMethod() { }

        [Conditional("CONDITION1")]
        static void NewMethod() { }

        static void Main(string[] args)
        {
            // When OldMethod is hovered over the Obsolete message shows up as a tool tip.
            OldMethod();

            NewMethod();

        }
        [AttributeUsage(AttributeTargets.All)]
        class ExampleAttribute : Attribute { }

        class Example
        {
            [ExampleAttribute]
            private object exampleObj;
        }
    }
}