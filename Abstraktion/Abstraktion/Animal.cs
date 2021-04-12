using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktion
{
    abstract class Animal
    {
        public int NumberOfLimbs { get; set; }

        public string Color { get; set; }

        public abstract void Breathe();

        public abstract void Rest();

        public abstract void Eat();
    }
}
