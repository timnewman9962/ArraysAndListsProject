using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var myIntArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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
            for(int n = 0; n < myIntArray.Length; n++)
            {
                if (myIntArray[n] % 2 == 0)
                    evens.Add(myIntArray[n]);
                else
                    odds.Add(myIntArray[n]);
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Here are the values of my \"evens[]\" and \"odds[]\" arrays");
            Console.WriteLine("First the evens:");
            int i = 0;
            foreach (int n in evens)
                Console.WriteLine($"element {i++}: {n}");
            Console.WriteLine("\nNow the odds:");
            i = 0;
            foreach (int n in odds)
                Console.WriteLine($"element {i++}: {n}");
        }
    }
}
