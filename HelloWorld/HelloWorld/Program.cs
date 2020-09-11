using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you alive? (Answer with a \"yes\" if this is true)");
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

            Console.WriteLine("Do you want to keep running this program? Answer \"yes\" is so");

            string keepGoing = Console.ReadLine();

            switch (keepGoing.ToUpper())
            {
                case "YES":
                    Console.Write("Loading");
                    for(int i = 0; i < 2; i++)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(" .");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(" .");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(" .");
                    }
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }

            int answer;
            while (true)
            {
                Console.WriteLine("\nQuestion: \nWhat's 9 + 10?");
                answer = Convert.ToInt32(Console.ReadLine());

                if(answer == 21)
                {
                    Console.WriteLine("Congratulations, you won 3 gems");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
                else if(answer == 19)
                {
                    Console.WriteLine("Right, but no... \nGuess again");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("dummy");
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Wrong, guess again dummy");
                    System.Threading.Thread.Sleep(1000);
                }

            }
            

            List<Person> people = new List<Person>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Persons name:");
                string name = Console.ReadLine();
                Console.WriteLine("Persons age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Persons life status: (Answer with \"Alive\" if it applies)");
                string alive = Console.ReadLine();
                if (alive.ToLower() == "alive")
                {
                    alive = "Living";
                }
                else
                {
                    alive = "Dead";
                }

                people.Add(new Person(name, age, alive));
            }

            people.Reverse();
            
            people.ForEach(delegate (Person p)
            { Console.WriteLine(String.Format("{0} {1} {2}", p.name, p.age, p.alive)); }); 

            */


        }

        public class Person
        {
            public string name;
            public int age;
            public string alive;
            public Person(string name, int age, string alive)
            {
                this.name = name;
                this.age = age;
                this.alive = alive;
            }
        }
}
}
