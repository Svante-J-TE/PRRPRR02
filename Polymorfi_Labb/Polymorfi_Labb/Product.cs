using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_Labb
{
    class Product
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
