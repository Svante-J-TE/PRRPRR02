using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace OOP_labb
{
    class Program
    {
        private static List<Customers> _customers = new List<Customers>();
        private static List<Products> _cart = new List<Products>();
        private static List<Products> BreadList = new List<Products>();
        private static List<Products> BevrageList = new List<Products>();
        private static List<Products> CondimentsList = new List<Products>();
        private static List<Products> SnackList = new List<Products>();

        static void Main(string[] args)
        {
            BreadList.Add(new Products("Ciabatta", "White", 23));
            BreadList.Add(new Products("Whole Wheat", "Lightbrown", 24));

            BevrageList.Add(new Products("Milk", "Organic", 25));
            BevrageList.Add(new Products("Beer", "Lager", 26));

            CondimentsList.Add(new Products("Butter", "Whipped", 27));
            CondimentsList.Add(new Products("Ketchup", "Organic", 28));

            SnackList.Add(new Products("Chips", "Salted", 29));
            SnackList.Add(new Products("Corn", "Grilled", 30));

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
                    if(_customers.Count == 0)
                    {
                        Console.WriteLine("You have to create a user first");
                        createCustomer();
                    }
                    else
                    {
                        shopping();
                    }
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
            Console.WriteLine("Type the number corresponding to the user you want to choose: (If you use this menu further, the current cart will be cleared)");
            while (true)
            {
                input = getValidInt();
                if (alternatives.Contains(input - 1))
                {
                    Console.WriteLine("You selected user: " + _customers[input - 1]._UserName);
                    _cart.Clear();
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
                    shopping();
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

        private static void shopping()
        {
            Console.WriteLine("What are you looking for?\n(1) - Bread\n(2) - Bevrages\n(3) - Condiments\n(4) - Snacks\n(5) - Go Back");
            while (true)
            {
                int input = getValidInt();

                if (input == 1)
                {
                    addToCart(1);
                }
                else if (input == 2)
                {
                    addToCart(2);
                }
                else if (input == 3)
                {
                    addToCart(3);
                }
                else if (input == 4)
                {
                    addToCart(4);
                }
                else if(input == 5)
                {
                    userMenu();
                }
                else
                {
                    Console.WriteLine("Please follow the intructions");
                }
            }
        }

        private static void addToCart(int v)
        {
            int type;
            int amount;
            if(v == 1)
            {
                Console.WriteLine("What do you want?\n" + "(1) - " + BreadList[0]._ProductName + " (" + BreadList[0]._ProductColor + "), " + BreadList[0]._ProductPrice + " kr");
                Console.WriteLine("(2) - " + BreadList[1]._ProductName + " (" + BreadList[1]._ProductColor + "), " + BreadList[1]._ProductPrice + " kr");
                while (true)
                {
                    type = getValidInt() -1;
                    if (type != 1 && type != 2)
                    {
                        Console.WriteLine("Please follow instructions");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("What amount?");
                amount = getValidInt();

                for (int i = 0; i < amount; i++)
                {
                    _cart.Add(BreadList[type]);
                }
            }
            if (v == 2)
            {
                Console.WriteLine("What do you want?\n" + "(1) - " + BevrageList[0]._ProductName + " (" + BevrageList[0]._ProductColor + "), " + BevrageList[0]._ProductPrice + " kr");
                Console.WriteLine("(2) - " + BevrageList[1]._ProductName + " (" + BevrageList[1]._ProductColor + "), " + BevrageList[1]._ProductPrice + " kr");
                while (true)
                {
                    type = getValidInt() -1;
                    if (type != 1 && type != 2)
                    {
                        Console.WriteLine("Please follow instructions");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("What amount?");
                amount = getValidInt();

                for (int i = 0; i < amount; i++)
                {
                    _cart.Add(BevrageList[type]);
                }
            }
            if (v == 3)
            {
                Console.WriteLine("What do you want?\n" + "(1) - " + CondimentsList[0]._ProductName + " (" + CondimentsList[0]._ProductColor + "), " + CondimentsList[0]._ProductPrice + " kr");
                Console.WriteLine("(2) - " + CondimentsList[1]._ProductName + " (" + CondimentsList[1]._ProductColor + "), " + CondimentsList[1]._ProductPrice + " kr");
                while (true)
                {
                    type = getValidInt() -1;
                    if (type != 1 && type != 2)
                    {
                        Console.WriteLine("Please follow instructions");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("What amount?");
                amount = getValidInt();

                for (int i = 0; i < amount; i++)
                {
                    _cart.Add(CondimentsList[type]);
                }
            }
            if (v == 4)
            {
                Console.WriteLine("What do you want?\n" + "(1) - " + SnackList[0]._ProductName + " (" + SnackList[0]._ProductColor + "), " + SnackList[0]._ProductPrice + " kr");
                Console.WriteLine("(2) - " + SnackList[1]._ProductName + " (" + SnackList[1]._ProductColor + "), " + SnackList[1]._ProductPrice + " kr");
                while (true)
                {
                    type = getValidInt() -1;
                    if (type != 1 && type != 2)
                    {
                        Console.WriteLine("Please follow instructions");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("What amount?");
                amount = getValidInt();

                for (int i = 0; i < amount; i++)
                {
                    _cart.Add(SnackList[type]);
                }
            }
            shopping();
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
            Console.WriteLine("If an exsisting user already have an active cart, it will be cleared when creating a new user");
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
            _cart.Clear();
            userMenu();
        }
    }
}
