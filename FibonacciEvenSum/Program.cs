using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up the first few numbers of the sequence and the formula
            int a = 0, b = 1, c = (a+b);
            //Adding it into a typed list so that the list can be expanded
            List<int> FibValues = new List<int>() { a, b, c, };

            //Checking to see if the value is less than 4million and if so keep adding the next number in the sequence(inclusive)
            do
            {
                a = b;
                b = c;
                c = a + b;
                FibValues.Add(c);
            } while (c <= 4000000);

            //Created a new list named Jeff to only hold the even numbers
            List<int> Jeff = new List<int>();
            foreach (var i in FibValues)
            {
                //modulus 2 == 0 to see if the number is even
                if (i % 2 == 0)
                {
                    Jeff.Add(i);
                }
            }

            //Test the values being added to Jeff
            //foreach (var i in Jeff)
            //{
            //    Console.WriteLine(i);
            //}

            //print the answer in the console
            Console.WriteLine($"The total off the even Fibonacci (Yes I had to look up the spelling of Fibonacci) values that are less than 4,000,000 is:\n{Jeff.Sum():n0}");
        }
    }
}
