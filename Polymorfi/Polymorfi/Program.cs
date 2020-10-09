using System;
using System.Collections.Generic;

namespace Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> cart = new List<Product>();

            Milk milk = new Milk();
            milk.FatContent = 1;
            milk.ProductNumber = 123;
            milk.StockStatus = 10;

            cart.Add(milk);

            EnergyDrink nocco = new EnergyDrink();
            nocco.Flavor = "Cola";
            nocco.ProductNumber = 456;
            nocco.StockStatus = 14;

            cart.Add(nocco);

            Coffee coffee = new Coffee();
            coffee.RoastLevel = "Vienna";
            coffee.ProductNumber = 789;
            coffee.StockStatus = 12;

            cart.Add(coffee);

            foreach (var product in cart)
            {
                if (product.GetType() == typeof(Milk))
                {
                    Console.WriteLine(((Milk)product).FatContent);
                }
                else if (product.GetType() == typeof(EnergyDrink))
                {
                    Console.WriteLine(((EnergyDrink)product).Flavor);
                }
                else if (product.GetType() == typeof(Coffee))
                {
                    Console.WriteLine(((Coffee)product).RoastLevel);
                }
            }
        }
    }
}
