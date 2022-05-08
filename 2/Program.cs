using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var People = new Dictionary<int, string>()
           {
               {1,"Fedor" },
               {2,"Varvara" },
               {3,"Alexandr" },
               {4,"Anzhela" },
               {5,"Viktor" },
                {6,"Ilya" }
            };

            File.WriteAllText("Ditionary.json", JsonConvert.SerializeObject(People));

            Console.WriteLine("Dictionary:");
            foreach (var person in People)
            {
                Console.WriteLine($"key: {person.Key} value: {person.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Введіть ключ словника для пошуку найменшого ключа, який більший або дорівнює введеному ключу :");
            int x = Convert.ToInt32(Console.ReadLine());
            
            int a = People.Count;

            if (x > a || x <= 0)
            {
                Console.WriteLine("null");
            } 

            if ( x > 0 && x <= a )
            {
                Console.Write($"Отриманий ключ: {x}");
            }
        }
    }
}
