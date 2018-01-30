using System;
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
            }

        // Ordering Operations

        // Order these student names alphabetically, in descending order (Z to A)
        List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

            List<string> descend = names.OrderByDescending(i => i).ToList();
                foreach(string name in descend)
                {
                    Console.WriteLine(name);
                }


        // Build a collection of these numbers sorted in ascending order
        List<int> numbers2 = new List<int>()
        {
             15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

            List<int> ascendingList = numbers2.OrderBy(n => n).ToList();
                foreach(int n in ascendingList)
            {
                Console.WriteLine(n);
            }


            // Aggregate Operations

            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            int amountOfNumbers = numbers3.Count();
            Console.WriteLine($"This list of numbers has {amountOfNumbers} numbers.");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double total = purchases.Sum();
            Console.WriteLine($"We have made a total of ${total}.");
 

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double mostExpensive = prices.Max();
            Console.WriteLine($"Our most expensive product costs ${mostExpensive}.");
            Console.ReadLine();
            
        }
    }
}
