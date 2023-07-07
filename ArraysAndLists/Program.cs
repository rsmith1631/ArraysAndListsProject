using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(myNumbers.Length);

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            var numbersList = new List<int>();
            var oddList = new List<int>();
            
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    numbersList.Add(i);
                }
            }
            
            for (int b = 1; b < 20; b++)
            {    
                if (b % 2 != 0) 
                {
                    oddList.Add(b);
                }
            }
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Even Numbers below:");
            Console.WriteLine("----------------------------------------------------------");
            foreach (var evenNumbers in numbersList)
            {
                Console.WriteLine(evenNumbers);
            }

            Console.WriteLine("Odd Numbers below:");
            Console.WriteLine("----------------------------------------------------------");
            foreach (var oddNumber in oddList)
            {
                Console.WriteLine(oddNumber);
            }
        }
    }
}
