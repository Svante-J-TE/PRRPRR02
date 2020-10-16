using System;
using System.Collections.Generic;

namespace Polymorfi_Labb
{
    class Program
    {
        static List<Product> _productsList = new List<Product>();
        static void Main(string[] args)
        {
            initializeProducts();
            Console.WriteLine("Time to shop!");
            var customer = createCustomer();

            mainMenu(customer);
            
        }

        private static void mainMenu(Customer customer)
        {
            Console.WriteLine("Press (1) to shop\nPress (2) to view cart\nPress (3) to quit");
            switch (Console.ReadLine())
            {
                case "1":
                    shop(customer);
                    break;
                case "2":
                    viewCart(customer);
                    break;
                case "3":
                    //End of program
                    break;
                default:
                    break;
            }
        }

        private static void viewCart(Customer customer)
        {
            int total = 0;
            Console.WriteLine("\nYour cart:\n");
            for (int i = 0; i < customer.Cart.Count; i++)
            {
                Console.WriteLine(customer.Cart[i].Name + "   Price " +  customer.Cart[i].Price + "kr");
                total += customer.Cart[i].Price;
            }
            Console.WriteLine("\nYour total: " + total + "\n");
            mainMenu(customer);
        }

        private static void shop(Customer customer)
        {
            int input;
            Console.WriteLine("\nWhat do you want?\n");
            for (int i = 0; i < _productsList.Count; i++)
            {
                Console.WriteLine("(" + (i+1) + ") - " + _productsList[i].Name + "\n");
            }

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(_productsList[0].Name + "\nPrice: " + _productsList[0].Price + "\nWaist size: " + ((Pants)_productsList[0]).WaistSize + "\nLength: " + ((Pants)_productsList[0]).WaistSize + "\n");
                    input = amountOfProduct();
                    for (int i = 0; i < input; i++)
                    {
                        customer.Cart.Add(_productsList[0]);
                    }
                    break;
                case "2":
                    Console.WriteLine(_productsList[1].Name + "\nPrice: " + _productsList[1].Price + "\nSize: " + ((Shirt)_productsList[1]).Size + "\nColor: " + ((Shirt)_productsList[1]).Color + "\n");
                    input = amountOfProduct();
                    for (int i = 0; i < input; i++)
                    {
                        customer.Cart.Add(_productsList[1]);
                    }
                    break;
                case "3":
                    Console.WriteLine(_productsList[2].Name + "\nPrice: " + _productsList[2].Price + "\nSize: " + ((Socks)_productsList[2]).Size + "\nColor: " + ((Socks)_productsList[2]).Color + "\n");
                    input = amountOfProduct();
                    for (int i = 0; i < input; i++)
                    {
                        customer.Cart.Add(_productsList[2]);
                    }
                    break;
                default:

                    break;
            }
            Console.WriteLine("\nContinue?\n(1) - Yes\n(2) - No, return to main menu");
            switch (Console.ReadLine())
            {
                case "1":
                    shop(customer);
                    break;
                case "2":
                    mainMenu(customer);
                    break;
                default:
                    break;
            }
        }

        private static int amountOfProduct()
        {
            Console.WriteLine("How many would you like?");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
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

            _productsList.Add(pants);
            _productsList.Add(shirt);
            _productsList.Add(socks);
        }

        private static Customer createCustomer()
        {
            var customer= new Customer();
            Console.WriteLine("What is your name?");
            customer.Name = Console.ReadLine();
            return customer;
        }
    }
}
