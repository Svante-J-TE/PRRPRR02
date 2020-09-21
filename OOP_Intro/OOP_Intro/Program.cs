using System;

namespace OOP_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal leMonk = new Animal();
            leMonk._name = "Le Monk";
            leMonk._species = "Monkey";
            leMonk._color = "Blue";

            Person niklas = new Person("Niklas", 33, leMonk);

            niklas.Name = "Niklas2";

            niklas.Eat();
            niklas.Sleep();

            niklas.ActivatePet();
        }
    }
}
