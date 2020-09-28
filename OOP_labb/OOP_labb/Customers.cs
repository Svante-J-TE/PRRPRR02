using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_labb
{
    class Customers
    {
        private string _userName;
        private int _userAge;
        private string _adress;
        private string _county;
        private string _zipCode;
        private string _email;
        private string _phoneNumber;
        private int[] _cart;

        public Customers(string name, int age, string adress, string county, string zipCode, string email, string phoneNumber)
        {
            this._userName = name;
            this._userAge = age;
            this._adress = adress;
            this._county = county;
            this._zipCode = zipCode;
            this._email = email;
            this._phoneNumber = phoneNumber;
        }

        /*
        public int[] cart
        {
            get { return _cart; }
            set { _cart.add(value); }
        }
        */
    }
}
