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

        public override void Breathe()
        {
            Console.WriteLine("Inhale....Exhale");
        }

        public override void Eat()
        {
            Console.WriteLine("MMHMHMHMHMM");
        }

        public override void Rest()
        {
            Console.WriteLine("ZZZzzzZZzzZZzz");
        }
    }
}
