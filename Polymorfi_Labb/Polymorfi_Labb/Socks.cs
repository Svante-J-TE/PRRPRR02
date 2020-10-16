using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_Labb
{
    class Socks : Product
    {
        private int _size;

        public int Size
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
