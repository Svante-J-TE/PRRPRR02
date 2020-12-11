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
            Console.WriteLine("Welcome to the virtual petshop!\nWhat are you looking for?\n(1) - Animals\n(2) - Accessories\n(3) - Leave the store");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("\nYou chose animals\n");
                        showProducts("Animal");
                        break;
                    case "2":
                        Console.WriteLine("\nYou chose accessories\n");
                        showProducts("Accessory");
                        break;
                    case "3":
                        Console.WriteLine("\nYou chose to leave the store\n");
                        outDoorMenu();
                        break;
                    default:
                        Console.WriteLine("\nChoose a valid option!\n");
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

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        addProductToCart(typeOfProduct);
                        break;
                    case "2":
                        mainMenu();
                        break;
                    default:
                        Console.WriteLine("Choose a valid option!");
                        break;
                }
            }
        }
        private static void addProductToCart(string typeOfProduct)
        {
            Console.WriteLine($"Please type the name of the {typeOfProduct} you would like to buy! If you changed your mind just press (0)");
            while (true)
            {
                string userInput = Console.ReadLine();
                foreach (var product in productsList)
                {
                    if (product.name.ToLower() == userInput.ToLower())
                    {
                        userCart.Add(product);
                        Console.WriteLine($"{product.name} is now yours!");
                    }
                }
                if(userInput == "0")
                {
                    mainMenu();
                }
                Console.WriteLine($"If you would like to buy another {typeOfProduct} just write its name, otherwise just press (0) return to the main menu");
            }
        }
        private static void outDoorMenu()
        {
            if (userCart.Count == 0)
            {
                Console.WriteLine("Since you left the store without any products you carried on with your life as usual");
            }
            else
            {
                Console.WriteLine("What animal or accessory would you like to play with/use?");
                foreach (var product in userCart)
                {
                    
                    if (product is Animal tempAnimal)
                    {
                        Console.WriteLine($"{product.name} ({tempAnimal.species})");
                    }
                    else
                    {
                        Console.WriteLine($"{product.name}");
                    }
                }
            }
        }
    }
}
