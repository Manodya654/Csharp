﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculate Area of the Rectangle");

            Console.WriteLine("Enter the length = ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width = ");
            double width = double.Parse(Console.ReadLine());

            double Area = CalculateArea(length, width);

            Console.WriteLine($"Area of the Rectangle is {Area}");

            Console.ReadLine();
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }
}
