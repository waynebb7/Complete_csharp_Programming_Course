namespace interfaceTest
{

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    class AudioPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing audio...");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing audio...");
        }

        //public void Stop()
        //{
        //    Console.WriteLine("Stopping audio...");
        //}
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}