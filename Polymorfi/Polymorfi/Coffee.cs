using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi
{
    class Coffee : Product
    {
        private string _roastLevel;

        public string RoastLevel
        {
            get { return _roastLevel; }
            set { _roastLevel = value; }
        }

    }
}
