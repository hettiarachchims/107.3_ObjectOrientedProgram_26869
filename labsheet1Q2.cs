using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.Write("Enter the radius of the circle: ");
            radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);
            Console.ReadLine();
        }
    }
}
