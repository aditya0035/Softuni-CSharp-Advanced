﻿using System;
using System.Linq;

namespace AverageOfDoubles
{
    public class AverageOfDoubles
    {
        public static void Main()
        {
            double avg = Console.ReadLine().Split().Select(double.Parse).Average();
            Console.WriteLine($"{avg:F2}");
        }
    }
}
