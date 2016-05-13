using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main (int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("{0} is bigger than {1}!", num1, num2);
            }
            else if (num1 < num2)
                Console.WriteLine("{0} is bigger than {1}!", num2, num1);
            else
                Console.WriteLine("It was a tie.");
            Console.Read();
        }
            }
        }

