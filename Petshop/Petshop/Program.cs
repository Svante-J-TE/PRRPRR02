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
                name = "Food bowl for dogs",
                price = 50,
                color = "Metallic Grey",
                brandName = "AnimalsBFF",
                animalType = "Dogs"
            };
            var birdBowl = new FoodBowl
            {
                name = "Food bowl for birds",
                price = 25,
                color = "Metallic Grey",
                brandName = "AnimalsBFF",
                animalType = "Birds"
            };
            var snakeBowl = new FoodBowl
            {
                name = "Food bowl for snakes",
                price = 25,
                color = "Metallic Grey",
                brandName = "AnimalsBFF",
                animalType = "Snakes"
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
                        showProducts("Animal");
                        break;
                    case "2":
                        Console.WriteLine("You chose accessories");
                        showProducts("Accessory");
                        break;
                    default:
                        Console.WriteLine("Choose a valid option!");
                        break;
                }
            }
        }

        private static void showProducts(string typeOfProduct)
        {
            switch (typeOfProduct)
            {
                case "Animal":
                    foreach (var product in productsList)
                    {
                        if (product is Animal productToShow)
                        {
                            Console.WriteLine($"Name: {productToShow.name}\nSpecies: {productToShow.species}\nColor: {productToShow.color}\nNumber of limbs: {productToShow.numberOfLimbs}\nPrice: {productToShow.price}kr\n");
                        }
                    }
                    break;
                case "Accessory":
                    foreach (var product in productsList)
                    {
                        if (product is Accessory productToShow)
                        {
                            Console.WriteLine($"Name: {productToShow.name}\nBrand: {productToShow.brandName}\nColor: {productToShow.color}\nSpecifically for: {productToShow.animalType}\nPrice: {productToShow.price}kr\n");
                        }
                    }
                    break;
            }
            Console.WriteLine($"Would you like to buy a/an {typeOfProduct}?\n(1) - Yes\n(2) - No");
        }
    }
}
