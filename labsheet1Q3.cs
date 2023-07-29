using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, sum;
            Console.Write("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }
    }
}
