using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet3Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            int vowelCount = 0;

            Console.Write("Enter a string: ");
            inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];
                if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'o' || currentChar == 'u' ||
                    currentChar == 'A' || currentChar == 'E' || currentChar == 'I' || currentChar == 'O' || currentChar == 'U')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine("The number of vowels in the string is: " + vowelCount);
            Console.ReadLine();

        }
    }
}
