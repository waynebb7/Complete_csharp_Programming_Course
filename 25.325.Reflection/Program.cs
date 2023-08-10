using System.Diagnostics;
using System.Reflection;


namespace _25._325.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Member Info
            Type t = typeof(int);

            MemberInfo[] typeMembers = t.GetMembers();
            foreach (MemberInfo memberInfo in typeMembers)
            {
                Debug.WriteLine("Member = " + memberInfo);
            }


            // Field Info
            Type f = typeof(int);

            FieldInfo[] typeFields = f.GetFields();
            foreach (FieldInfo fieldInfo in typeFields)
            {
                Debug.WriteLine("Field = " + fieldInfo);
            }


            // Method Info
            Type m = typeof(int);

            MethodInfo[] typeMethods = m.GetMethods();
            foreach (MethodInfo methodInfo in typeMethods)
            {
                Debug.WriteLine("Method = " + methodInfo);
            }

            // Generic Types
            System.Diagnostics.Debug.WriteLine("Is String a generic type: " + typeof(string).IsGenericType);
            System.Diagnostics.Debug.WriteLine("Is List a generic type: " + typeof(List<>).IsGenericType);

            // Example of generic types
            Type t1 = typeof(Dictionary<,>);
            if (t1.IsGenericType)
            {
                Type[] typeParameters = t1.GetGenericArguments();
                Debug.WriteLine("Number of type parameters = {0}", typeParameters.Length);
                foreach (Type tParam in typeParameters)
                {
                    if (tParam.IsGenericParameter)
                    {
                        Debug.WriteLine("Generic Type = {0}", tParam);
                    }
                    else
                    {
                        Debug.WriteLine("Type = {0}", tParam);
                    }
                }
            }
        }
    }
}