using System.Diagnostics;
using System.Threading.Tasks;

namespace _9._119.AsynchronousFunctions
{
    internal class Example
    {
        static async Task CookMeat()
        {
            Debug.WriteLine("Cook Meat");
        }

        static async Task CookVegetables()
        {
            Debug.WriteLine("Cook Vegetables");
        }

        static async Task MakeBread()
        {
            Debug.WriteLine("Make Bread");
        }

        static async Task MakeSoup()
        {
            Debug.WriteLine("Make Soup");
        }

        static async Task MakeSalad()
        {
            Debug.WriteLine("Make Salad");
        }

        static async Task MakeDrinks()
        {
            Debug.WriteLine("Make Drinks");
        }

        static async void MakeDinner()
        {
            await CookMeat();
            await CookVegetables();
            await MakeBread();
            await MakeSoup();
            await MakeSalad();
            await MakeDrinks();
        }


        static void Main(string[] args)
        {
            MakeDinner();
        }
    }
}