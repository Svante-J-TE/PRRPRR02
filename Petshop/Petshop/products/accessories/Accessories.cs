using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    abstract class Accessories : Products
    {
        //PROPERTIES
        public int MyProperty { get; set; }

        //METHODS
        public abstract void use();
    }
}
