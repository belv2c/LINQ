﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Restriction/Filtering options
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>()
            {
                "Lemon",
                "Apple",
                "Orange",
                "Lime",
                "Watermelon",
                "Loganberry"
            };

            var LFruits = from fruit in fruits
                          where fruit.StartsWith("L")
                          select fruit;

            foreach (var item in LFruits)
            {
                Console.WriteLine(item);
            }

        // Which of the following numbers are multiples of 4 or 6
        List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };
 
            var fourSixMultiples = numbers.Where(n => n % 2 == 0 || n % 6 == 0);

            foreach (var n in fourSixMultiples)
            {
                Console.WriteLine(n);
                Console.ReadLine();
            }
        }
    }
}
