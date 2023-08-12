// Simplified real-world example that models a basic online shopping cart
// In this example:

// The Product class represents a product with a name and a price.
// The ShoppingCart class models a shopping cart that can store a list of products
// and perform operations on them.
// The Program class contains the Main method, which demonstrates how to create products,
// add them to the shopping cart, and display the contents of the cart.
// When you run this program, it will simulate adding products to a shopping cart and then
// displaying the items in the cart along with their prices.

// Please note that this example is simplified and lacks many features of a real-world
// application, but it illustrates the basic concepts of object-oriented programming,
// class interactions, and method usage in C#.

using System.Diagnostics;

namespace _11._144._1.Arrays_RealWorldExample
{
    class Product
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }

    class ShoppingCart
    {
        private List<Product> items = new List<Product>();

        public void AddItem(Product product)
        {
            items.Add(product);
            Debug.WriteLine($"Added {product.Name} to the cart.");
        }

        public void DisplayCart()
        {
            Debug.WriteLine("Items in the cart:");
            foreach (var item in items)
            {
                Debug.WriteLine($"{item.Name} - ${item.Price}");
            }
        }
    }

    internal class Sales
    {

        static void Main(string[] args)
        {
            Product product1 = new Product { Name = "Laptop", Price = 999.99m };
            Product product2 = new Product { Name = "Phone", Price = 699.99m };
            Product product3 = new Product { Name = "Headphones", Price = 149.99m };

            ShoppingCart cart = new ShoppingCart();
            cart.AddItem(product1);
            cart.AddItem(product2);
            cart.AddItem(product3);

            cart.DisplayCart();
        }
    }
}