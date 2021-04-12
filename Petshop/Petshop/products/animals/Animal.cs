using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    abstract class Animal : Products
    {
        //PROPERTIES
        public int numberOfLimbs { get; set; }
        public string species { get; set; }

        //METHODS
        public abstract void Play();

        public abstract void Rest();

        public abstract void Eat();
    }
}
