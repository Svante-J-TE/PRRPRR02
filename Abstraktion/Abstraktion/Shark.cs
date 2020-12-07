using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    class Shark : Animal
    {
        public Shark()
        {
            NumberOfLimbs = 4;
        }
        public override void Breathe()
        {
            Console.WriteLine("Shark breathes using its gills!");
        }

        public override void Eat()
        {
            Console.WriteLine("Shark is chomping!");
        }

        public override void Rest()
        {
            Console.WriteLine("Shark is in an restful state");
        }

        //
        public void Swim()
        {
            Console.WriteLine("Shark is swimming!");
        }
    }
}
