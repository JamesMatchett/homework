using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApplication1
{
    public class prime
    {
        public static void Generate()
        {
            int i = 0;
            while (true)
            {

                if (!hasFactor(i))
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }

        public static bool hasFactor(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if (i % x == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            prime.Generate();

            Console.WriteLine("Enter a number to be added up to");
            int number = 0;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Iteration gives {0}", SumOfNumbers.SumIteration(number));
                Console.WriteLine("Recursion gives {0}", SumOfNumbers.sumRecursion(number));
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }

            Console.WriteLine("");
            Console.WriteLine("Enter a word to check if it is a palindrome");
            if (Palindrome.IsPalindromeRecursion(Console.ReadLine()))
            {
                Console.WriteLine("{0} is a palindrome",Console.ReadLine());
            }
            else
            {
                Console.WriteLine("{0} isn't a palindrome",Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("Enter number for pyramid count");
            number = 0;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Pyramid Number is {0}",PyramidCount.Count(number));
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

            Console.WriteLine("");
            Console.WriteLine("Enter a string to check if it's a real number");
            string input = Console.ReadLine();
            if (RealNumber.Isreal(input))
            {
                Console.WriteLine("{0} is a real number",Console.ReadLine());
            }
            else
            {
                Console.WriteLine("{0} is not a real number",Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
