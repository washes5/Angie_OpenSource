using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            for (var i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                    Console.Read();
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Console.Read();
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Console.Read();
                }

                else
                {
                    Console.WriteLine(i);
                    Console.Read();

                }
            }
        }
    }
}
