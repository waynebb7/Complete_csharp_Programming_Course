using System.Collections.Specialized;
using System.ComponentModel;

namespace _11._148.Structs___
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }


    struct Example : INotifyPropertyChanged
    {
        string Ex;
        int Ex2;

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}