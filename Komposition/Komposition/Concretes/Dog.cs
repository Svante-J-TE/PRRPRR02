using Komposition.Abstracts;
using Komposition.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Komposition.Concretes
{
    class Dog : Animal, IDog
    {
        public void Move()
        {
            Console.WriteLine("Dog is moving");
        }
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        public void Rest()
        {
            Console.WriteLine("Dog is resting");
        }
    }
}