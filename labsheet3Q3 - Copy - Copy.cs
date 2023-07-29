using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, digitSum = 0;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i /= 10)
            {
                digitSum += i % 10;
            }
            Console.WriteLine("The sum of the digits of the number is: " + digitSum);
            Console.ReadLine();
        }
    }
}
