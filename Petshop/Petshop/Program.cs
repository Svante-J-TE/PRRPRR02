using Petshop.products.accessories;
using Petshop.products.animals;
using System;
using System.Collections.Generic;

namespace Petshop
{
    class Program
    {
        static List<Products> productsList = new List<Products>();
        static List<Products> userCart = new List<Products>();
        static void Main(string[] args)
        {
            var dalmatian = new Dog
            {
                name = "Tilde",
                price = 200,
                color = "White and black",
                species = "Dalmatian"

            };
            var cockatoo = new Parrot
            {
                name = "Charlie",
                price = 75,
                color = "Grey",
                species = "Cockatoo"
            };
            var anaconda = new Snake
            {
                name = "Nagini",
                price = 150,
                color = "Green/Brown",
                species = "Anaconda"
            };

            var dogBowl = new FoodBowl
            {
                name = "dogBowl",
                price = 50,
                color = "Metallic Grey"
            };
            var birdBowl = new FoodBowl
            {
                name = "birdBowl",
                price = 25,
                color = "Metallic Grey"
            };
            var snakeBowl = new FoodBowl
            {
                name = "snakeBowl",
                price = 25,
                color = "Metallic Grey"
            };
            productsList.AddRange(new Products[] { dalmatian, cockatoo, anaconda, dogBowl, birdBowl, snakeBowl });

            while (true)
            {
                mainMenu();
            }
        }
        private static void mainMenu()
        {
            string userInput;
            Console.WriteLine("Welcome to the virtual petshop!\nWhat are you looking for?\n(1) - Animals\n(2) - Accessories");
            while (true)
            {
                userInput = Console.ReadLine().ToString();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("You chose animals");
                        showProducts("animal");
                        break;
                    case "2":
                        Console.WriteLine("You chose accessories");
                        showProducts("accessory");
                        break;
                    default:
                        Console.WriteLine("Choose a valid option!");
                        break;
                }
            }
        }

        private static void showProducts(string typeOfProduct)
        {
            //visa produkter beroende på typeOfProduct
        }
    }
}
