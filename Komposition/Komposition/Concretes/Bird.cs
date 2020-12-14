using Komposition.Abstracts;
using Komposition.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Komposition.Concretes
{
    class Bird : Animal, IBird
    {
        public void Move()
        {
            Console.WriteLine("Bird is moving");
        }
        public void Eat()
        {
            Console.WriteLine("Bird is eating");
        }
        public void Rest()
        {
            Console.WriteLine("Bird is resting");
        }
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
}