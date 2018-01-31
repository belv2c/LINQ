using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {

        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

        public class Bank
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
        }

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
            foreach (string name in descend)
            {
                Console.WriteLine(name);
            }


            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> ascendingList = numbers2.OrderBy(n => n).ToList();
            foreach (int n in ascendingList)
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

            // Partitioning Operations

            //Store each number in the following List until a perfect square is detected.

            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            int findTheSquare = wheresSquaredo.Find(n => Math.Sqrt(n) % 1 == 0);
            Console.WriteLine($"A square has been detected at {findTheSquare}.");


            // Using Custom Types
            // Build a collection of customers who are millionaires

            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            List<Customer> millionaires = customers.Where(c => c.Balance <= 1000000).ToList();

            var joinedList = from customer in millionaires
                             group customer by customer.Bank into joinedMillionaires
                             select new
                             {
                                 Bank = joinedMillionaires.Key,
                                 AmountOfMillionaires = joinedMillionaires.Count()
                             };
            foreach (var richPerson in joinedList)
            {
                Console.WriteLine($"{richPerson.Bank} {richPerson.AmountOfMillionaires}");
            }


            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            var millionaireReport = from customer in customers
                                    join bank in banks on customer.Bank equals bank.Symbol
                                    where (customer.Balance >= 1000000)
                                    select new { CustomerName = customer.Name, CustomerBank = bank.Name };

            foreach (var customer in millionaireReport)
            {
                Console.WriteLine($"{customer.CustomerName} at {customer.CustomerBank}");
                Console.ReadLine();
            }
        }
    }
}

