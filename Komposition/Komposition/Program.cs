using Komposition.Abstracts;
using Komposition.Concretes;
using Komposition.Interface;
using System;
using System.Collections.Generic;

namespace Komposition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            List<IDog> dogs = new List<IDog>();
            List<IBird> birds = new List<IBird>();

            var dog = new Dog();
            dog.Color = "Red";
            dog.NumberOfLimbs = 4;
            var bird = new Bird();
            bird.Color = "Green";
            bird.NumberOfLimbs = 4;

            animals.AddRange(new Animal[] { dog, bird });

            foreach (var animal in animals)
            {
                Console.WriteLine($"This animal is {animal.Color}");
                Console.WriteLine($"This animal has {animal.NumberOfLimbs} limbs");
                if (animal is Dog tempDog)
                {
                    dogs.Add(tempDog);
                }
                else if (animal is Bird tempBird)
                {
                    birds.Add(tempBird);
                }
            }
            foreach (var animal in dogs)
            {
                animal.Eat();
                animal.Rest();
                animal.Move();
            }
            foreach (var animal in birds)
            {
                animal.Eat();
                animal.Rest();
                animal.Move();
                animal.Fly();
            }
        }
    }
}