using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i= 0; i<=10; i++)
            {
                Console.Write($"Enter a number - ");
                int no = int.Parse(Console.ReadLine());

                String Result;
                if (IsEven(no))
                {
                    Result = "Even";
                }
                else
                {
                    Result = "Odd";
                }

                Console.WriteLine($"{no} is a {Result} number");

                Console.ReadLine();
            }
        }

        static bool IsEven(int no)
        {
            return no % 2 == 0;
        }
    }
}
