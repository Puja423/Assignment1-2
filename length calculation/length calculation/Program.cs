﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace length_calculation
{
    class line
    {
        public int X1 { get; set; }
        public int X2 { get; set;}
        public int Y1 { get; set; }
        public int Y2 { get; set; }
        public double Length()
        {
            return Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to line comparison");
        }
    }
}
