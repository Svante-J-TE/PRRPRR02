using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OOP_labb
{
    class Program
    {
        private static List<Customers> _customers = new List<Customers>();

        static void Main(string[] args)
        {
            List<Products> BreadList = new List<Products>();
            List<Products> BevrageList = new List<Products>();
            List<Products> CondimentsList = new List<Products>();
            List<Products> SnackList = new List<Products>();
            


            BreadList.Add(new Products("Bread", "Ciabatta", "White", 50, "bread_ciabatta_white"));
            BreadList.Add(new Products("Bread", "Whole Wheat", "Lightbrown", 70, "bread_whole_wheat_lightbrown"));

            BevrageList.Add(new Products("Bevrage", "Milk", "Organic", 20, "bevrage_milk_organic"));
            BevrageList.Add(new Products("Bevrage", "Beer", "Lager", 90, "bevrage_beer_lager"));

            CondimentsList.Add(new Products("Condiment", "Butter", "Whipped", 45, "condiment_butter_whipped"));
            CondimentsList.Add(new Products("Condiment", "Ketchup", "Organic", 12, "condiment_ketchup_organic"));

            SnackList.Add(new Products("Snack", "Chips", "Salted", 33, "snack_chips_salted"));
            SnackList.Add(new Products("Snack", "Corn", "Grilled", 22, "snack_corn_grilled"));

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
            Console.WriteLine("What do you want to start with?\n(1) - Create User\n(2) - Select User\n(3) - Exit Shopping Simulator 2020");
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
                else if(input == 2)
                {
                    selectCustomer();
                }
                else if(input == 3)
                {
                    //exit program
                }
                else
                {
                    Console.WriteLine("Choose one of the three alternatives!");
                }
            }
        }

        private static void selectCustomer()
        {
            int back = _customers.Count;
            Console.WriteLine("Users available: ");
            for (int i = 0; i < _customers.Count; i++)
            {
                Console.WriteLine(i+1 + " " + _customers[0]._UserName); //problem with getting right name
            }
            Console.WriteLine("Type the number corresponding to the user you want to choose: ");
            //if sats om user eller back
            //activate correct users shoppingcart
            createCustomer();
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
            selectCustomer();
        }
    }
}
