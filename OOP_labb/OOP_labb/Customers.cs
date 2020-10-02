using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_labb
{
    class Customers
    {
        private string _userName;

        public string _UserName
        {
            get { return _userName; }   
            set { _userName = value; }  
        }

        private int _userAge;

        public int _UserAge
        {
            get { return _userAge; }
            set { _userAge = value; }
        }

        public Customers(string name, int age)
        {
            _userName = name;
            _userAge = age;
        }

        

    }
}
