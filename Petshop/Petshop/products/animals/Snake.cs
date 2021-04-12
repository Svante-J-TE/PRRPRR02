using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.products.animals
{
    class Snake : Animal
    {
        public Snake()
        {
            numberOfLimbs = 0;
        }

        public override void Play()
        {
            Console.WriteLine("*Sliters around your arm*");
        }

        public override void Eat()
        {
            Console.WriteLine("chomp chomp");
        }

        public override void Rest()
        {
            Console.WriteLine("ZZZzzzZZzzZZzz");
        }
    }
}
