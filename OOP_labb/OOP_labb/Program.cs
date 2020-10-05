using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OOP_labb
{
    class Program
    {
        private static List<Customers> _customers = new List<Customers>();
        private static List<Products> _cart = new List<Products>();

        static void Main(string[] args)
        {
            List<Products> BreadList = new List<Products>();
            List<Products> BevrageList = new List<Products>();
            List<Products> CondimentsList = new List<Products>();
            List<Products> SnackList = new List<Products>();
            
            


            BreadList.Add(new Products("Bread", "Ciabatta", "White", 50, 23));
            BreadList.Add(new Products("Bread", "Whole Wheat", "Lightbrown", 70, 24));

            BevrageList.Add(new Products("Bevrage", "Milk", "Organic", 20, 25));
            BevrageList.Add(new Products("Bevrage", "Beer", "Lager", 90, 26));

            CondimentsList.Add(new Products("Condiment", "Butter", "Whipped", 45, 27));
            CondimentsList.Add(new Products("Condiment", "Ketchup", "Organic", 12, 28));

            SnackList.Add(new Products("Snack", "Chips", "Salted", 33, 29));
            SnackList.Add(new Products("Snack", "Corn", "Grilled", 22, 30));

            _cart.Add(SnackList[0]);

            mainMenu();
            
        }

        private static int getValidInt()
        {
            int input = int.TryParse(Console.ReadLine(), out input) ? input : -1;

            return input;
        }

        private static void mainMenu()
        {
            Console.WriteLine("Welcome to the 2020 shopping simulator, get your hand sanitizer and face masks ready!");
            Console.WriteLine("What do you want to start with?\n(1) - Create User\n(2) - Select User\n(3) - Begin/Continue Shopping\n(4) - Exit Shopping Simulator 2020");
            while (true)
            {
                int input = getValidInt();

                if (input == -1)
                {
                    Console.WriteLine("Write a valid integer: ");
                }
                else if (input == 1)
                {
                    createCustomer();
                }
                else if (input == 2)
                {
                    selectCustomer();
                }
                else if (input == 3)
                {
                    //shoppning method
                }
                else if (input == 4)
                {
                    //exit program
                }
                else
                {
                    Console.WriteLine("Choose one of the four alternatives!");
                }
            }
        }

        private static void selectCustomer()
        {
            int back = _customers.Count+1;
            int input;
            List<int> alternatives = new List<int>();
            Console.WriteLine("Users available: ");
            for (int i = 0; i < _customers.Count; i++)
            {
                Console.WriteLine(i+1 + " " + _customers[i]._UserName);
				alternatives.Add(i);
            }
			Console.WriteLine("\n" + (_customers.Count+1) + " Go Back");
            Console.WriteLine("Type the number corresponding to the user you want to choose: (When switching users the current cart will be cleared)");
            while (true)
            {
                input = getValidInt();
                if (alternatives.Contains(input - 1))
                {
                    Console.WriteLine("You selected user: " + _customers[input - 1]._UserName);
                    userMenu();
                }
                else if (input == back)
                {
                    mainMenu();
                }
                else
                {
                    Console.WriteLine("Input a valid integer");
                }
            }
        }

		private static void userMenu()
		{
			Console.WriteLine("What do you want to do?\n(1) - View cart\n(2) - Begin/Continue Shopping\n(3) - Return to main menu");
            while (true)
            {
                int input = getValidInt();
                if (input == -1)
                {
                    Console.WriteLine("Write a valid integer: ");
                }
                else if (input == 1)
                {
                    Console.WriteLine("view cart");
                    viewCart();
                }
                else if (input == 2)
                {
                    Console.WriteLine("*shopping*");
                    //shopping method
                }
                else if (input == 3)
                {
                    mainMenu();
                }
                else
                {
                    Console.WriteLine("Choose one of the alternatives!");
                }
            }
            
        }

		private static void viewCart()
		{
			for (int i = 0; i < _cart.Count; i++)
			{
				Console.WriteLine(_cart[i]._ProductName + ", " + _cart[i]._ProductColor + ", Price: " + _cart[i]._ProductPrice + " kr");
			}

			Console.WriteLine("\nTo return, press 1");
            while (true)
            {
                int input = getValidInt();
                if (input == 1)
                {
                    userMenu();
                }
                else
                {
					Console.WriteLine("Press \"1\" to return");
                }
            }
		}

		static void createCustomer()
        {
            string name;
            int age;
            while (true)
            {
                Console.WriteLine("Write your name:");
                name = Console.ReadLine();
                if(name != null && name != "")
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Write your age:");
                age = getValidInt();
                if(age == -1)
                {
                    Console.WriteLine("Write a valid integer: ");
                }
                else if(age <= 12)
                {
                    Console.WriteLine("You have to be 13 years or older to have an account!");
                }
                else
                {
                    break;
                }
            }
            
            _customers.Add(new Customers(name, age));
            Console.WriteLine("Created Customer: " + _customers[_customers.Count-1]._UserName + "\nAge: " +  _customers[_customers.Count - 1]._UserAge);
            userMenu();
        }
    }
}
