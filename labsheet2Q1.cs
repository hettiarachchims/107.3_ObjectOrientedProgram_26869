﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int ans;
            Console.Write("enter number");
            num = int.Parse(Console.ReadLine());
            ans = num % 2;

            if (ans > 0)
            {
                Console.Write("odd");
            }
            else
            {
                Console.Write("even");
            }
            Console.Read();

        }
    }
}
