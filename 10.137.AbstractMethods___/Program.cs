namespace _10._137.AbstractMethods___
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    abstract class Animal
    {
        public abstract void Run(int speed);
    }

    class dog : Animal
    {
        public override void Run(int speed)
        {
            System.Diagnostics.Debug.WriteLine("Dog is running at speed: " + speed);
        }
    }
}