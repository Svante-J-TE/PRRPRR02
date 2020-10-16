using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_Labb
{
    class Customer
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        List<Product> _cart = new List<Product>();
        
    }
}
