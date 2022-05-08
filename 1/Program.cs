using System;
using System.Collections.Generic;

namespace ConsoleApp1
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
            foreach (var number in Numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter value of 'X'");
            int x = Convert.ToInt32(Console.ReadLine());
           
           Numbers.Reverse(0, x-1);
           Numbers.Reverse(x, 9 - x);

            Console.WriteLine();
            Console.WriteLine("Sorted List of Numbers:");
            foreach (var number in Numbers)
            {
                Console.Write($"{number} ");
            }

        }
    }
}
