using System;

namespace Polymorfi_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            initializeProducts();
            Console.WriteLine("Time to shop!");
            createCustomer();

            mainMenu();
            
        }

        private static void mainMenu()
        {
            Console.WriteLine("Press (1) to shop\nPress (2) to view cart\nPress (3) to quit");

        }

        private static void initializeProducts()
        {
            var pants = new Pants();
            pants.Name = "Pants";
            pants.Price = 299;
            pants.WaistSize = 32;
            pants.Length = 32;

            var shirt = new Shirt();
            shirt.Name = "Shirt";
            shirt.Price = 149;
            shirt.Size = "M";
            shirt.Color = "Aqua";

            var socks = new Socks();
            socks.Name = "Socks";
            socks.Price = 10;
            socks.Size = 42;
            socks.Color = "Hot Pink";
        }

        private static void createCustomer()
        {
            var customer= new Customer();
            Console.WriteLine("What is your name?");
            customer.Name = Console.ReadLine();
        }
    }
}
