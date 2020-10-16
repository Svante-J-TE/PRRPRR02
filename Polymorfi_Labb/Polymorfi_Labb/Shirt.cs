using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_Labb
{
    class Shirt : Product
    {
        private string _size;

        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }


    }
}
