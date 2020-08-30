using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you alive? (Answer with a \"yes\" if this is true");
            string alive = Console.ReadLine();
            bool lifeStatus;

            if(alive.ToUpper() == "YES")
            {
                lifeStatus = true;
            }
            else
            {
                lifeStatus = false;
            }

            if(lifeStatus == true)
            {
                alive = "Alive";
            }
            else
            {
                alive = "Deceased (probably)";
            }

            Console.WriteLine('\n' + "Name: " + name + '\n' + "Age: " + age + '\n' + "Life Status: " + alive);

        }
    }
}
