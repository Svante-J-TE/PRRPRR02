using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Intro
{
    class Animal
    {
        public string _color;
        public string _species;
        public string _name;

        public void Poop()
        {
            Console.WriteLine(_color + " " + _species + " named " + _name + " is pooping");
        }

    }
}
