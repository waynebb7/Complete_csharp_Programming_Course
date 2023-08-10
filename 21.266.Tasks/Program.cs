
using System.Threading.Tasks;


namespace _21._266.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> exampleTask = Task.Run(() => 1);
            Console.WriteLine(exampleTask.Result);
        }
    }
}