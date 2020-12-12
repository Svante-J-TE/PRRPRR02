using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.products.animals
{
    class Parrot : Animal
    {
        public Parrot()
        {
            numberOfLimbs = 4;
        }

        public override void Play()
        {
            Console.WriteLine("You sing a song togheter");
        }

        public override void Eat()
        {
            Console.WriteLine("kwit kwit");
        }

        public override void Rest()
        {
            Console.WriteLine("ZZZzzzZZzzZZzz");
        }
    }
}
