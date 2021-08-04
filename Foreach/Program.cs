using System;
using System.Collections.Generic;

namespace Foreach
{
    class Program
    {
        static void Main()
        {
            /*Задание 1
            List<string> words = new List<string> ();
            words.Add("Elements");
            words.Add("in array!");
            words.Add("Hi");
            words.Add("It is me");
            foreach (string wor in words)
                if (wor == "Hi")
                    System.Console.WriteLine("Word \"Hi\" is in the array");
            Console.ReadKey ();*/

            /*Задание 2*/
            List<int> a = new List<int> ();
            Random random = new Random();
            for (int i = 0; i<7; i++)
                a.Add(random.Next(1 , 20));
            foreach (int num in a)
                System.Console.WriteLine(num);
            int max = a[0];
            for (int i = 0; i<a.Count; i++)
                if (max < a[i])
                    max = a[i];
            System.Console.WriteLine("Max= " + max);
        }
    }
}
