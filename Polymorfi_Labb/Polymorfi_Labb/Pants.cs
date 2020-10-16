using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_Labb
{
    class Pants : Product
    {
        private int _waistSize;

        public int WaistSize
        {
            get { return _waistSize; }
            set { _waistSize = value; }
        }

        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }



    }
}
