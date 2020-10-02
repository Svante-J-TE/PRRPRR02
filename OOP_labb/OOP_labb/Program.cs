using System;
using System.Collections.Generic;

namespace OOP_labb
{
    class Program
    {
        private static List<Customers> _customers = new List<Customers>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
                age = 3;
                if (age != null)
                {
                    break;
                }
            }
            
            _customers.Add(new Customers(name, age));
            Console.WriteLine("Created Customer: " + _customers[0]._UserName + "\nAge: " +  _customers[0]._UserAge);
        }
    }
}
