using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet2Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            string[] results = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] % 2 == 0)
                {
                    results[i] = "even";
                }
                else
                {
                    results[i] = "odd";
                }
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Results:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i] + " is " + results[i]);
            }
            Console.ReadLine();
        }
    }
}
