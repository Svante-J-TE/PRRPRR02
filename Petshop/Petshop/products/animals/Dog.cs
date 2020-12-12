using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.products.animals
{
    class Dog : Animal
    {
        public Dog()
        {
            numberOfLimbs = 4;
        }

        public override void Play()
        {
            Console.WriteLine("You play fetch for hours");
        }

        public override void Eat()
        {
            Console.WriteLine("NOMNOMNOM");
        }

        public override void Rest()
        {
            Console.WriteLine("ZZZzzzZZzzZZzz");
        }
    }
}
