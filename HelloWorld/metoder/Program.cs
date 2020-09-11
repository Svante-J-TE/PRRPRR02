using System;
using System.Linq;

namespace metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            string[] words = new string[] { "hej", "jag", "du", "är", "tack" };

            Console.WriteLine(Add(numbers));
            ReverseWordsOutPut(words);
            Console.WriteLine(BiggestAndLowest(numbers));

        }

        static int Add(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void ReverseWordsOutPut(string[] words)
        {

            foreach (string i in words.Reverse())
            {
                Console.WriteLine(i);
            }

        }
        static Tuple<int, int> BiggestAndLowest(int[] numbers)
        {
            int biggest = numbers[0];
            int lowest = numbers[0];

            for(int i = 0; i < numbers.Length; i++)
            {

                if (biggest.CompareTo(numbers[i]) == 1)
                {
                    biggest = numbers[i];
                }
                else if(lowest.CompareTo(numbers[i]) == -1)
                {
                    lowest = numbers[i];
                }
            }
            return Tuple.Create(biggest, lowest);
        }
    }

}
