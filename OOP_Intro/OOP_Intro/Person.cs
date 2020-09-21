using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Intro
{
    class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        int _age;

        Animal _pet;

        public Person(string name, int age, Animal pet)
        {
            _name = name;
            _age = age;
            _pet = pet;
        }

        public void ActivatePet()
        {
            _pet.Poop();
        }

        public void Eat()
        {
            Console.WriteLine( _name + " äter....." + " han är " + _age);
        }

        public void Sleep()
        {
            Console.WriteLine(_name + " sover.....");
        }
    }
}
