using System;
using System.Collections.Generic;

namespace Abstraktion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var dog = new Dog
            {
                Color = "Black"
            };

            var shark = new Shark
            {
                Color = "Grey"
            };

            animals.AddRange(new Animal[] { dog, shark });

            foreach (var animal in animals)
            {
                animal.Breathe();
                animal.Eat();
                animal.Rest();
                Console.WriteLine("The animal is " + animal.Color);

                if(animal is Shark tempShark)
                {
                    tempShark.Swim();
                }
            }
        }
    }
}
