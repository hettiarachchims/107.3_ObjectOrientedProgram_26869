using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, oddSum = 0;
            Console.Write("Enter a positive integer: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i += 2)
            {
                oddSum += i;
            }
            Console.WriteLine("The sum of all the odd numbers from 1 to " + number + " is: " + oddSum);
            Console.ReadLine();
        }
    }
}
