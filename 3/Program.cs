using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };
            Console.WriteLine("List of Numbers:");
            foreach (int number in Numbers)
            Console.Write(number);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("List of Sorted Numbers:");
            var sortedNumbers = from p in Numbers where p <= 15 && p >= 5 orderby p select p;
            foreach (int sortedNumber in sortedNumbers)
            Console.Write(sortedNumber);

        }
    }
}
