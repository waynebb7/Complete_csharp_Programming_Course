using System.Diagnostics;

namespace _17._217.ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car(); This line is not needed when the class is static
            Car.Start();
            Car.Drive();
            Car.Stop();
        }

        public static class Car
        {
            static int speed;
            static string color;
            static float price;

            public static void Start()
            {
                Debug.WriteLine("Car started");
            }

            public static void Drive()
            {
                Debug.WriteLine("Car is driving");
            }

            public static void Stop()
            {
                Debug.WriteLine("Car stopped");
            }
        }
    }

    //// Instantiated format ie not using the static key word so it must be instantiated to be used.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Car car = new Car();
    //        car.Start();
    //        car.Drive();
    //        car.Stop();
    //    }

    //    public class Car
    //    {
    //        int speed;
    //        string color;
    //        float price;

    //        public void Start()
    //        {
    //            Debug.WriteLine("Car started");
    //        }

    //        public void Drive()
    //        {
    //            Debug.WriteLine("Car is driving");
    //        }

    //        public void Stop()
    //        {
    //            Debug.WriteLine("Car stopped");
    //        }
    //    }
    //}

}