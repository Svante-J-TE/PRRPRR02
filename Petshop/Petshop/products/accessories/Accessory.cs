using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    abstract class Accessory : Products
    {
        //PROPERTIES
        public string brandName { get; set; }

        public string animalType { get; set; }

        //METHODS
        public abstract void Use();
        public abstract void Clean();
        public abstract void Fix();
    }
}
