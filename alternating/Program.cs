using System;

namespace alternating
{
    class Program
    {
        static void Main()
        {
            /* 1 задание
            byte num_byte = -34;
            string word = "Hello";
            char letter = 'R';
            float num_float = 23.093433222;
            int num_int2 = 30000;
            bool angel = true;
            int num_int = 0;*/

            /* 2 задание
            string name;
            int age;
            bool hasCar;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Do you have a car?");
            hasCar = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Hi " + name + ".");
            Console.WriteLine("You are " + age.ToString () + " years old.");
            Console.WriteLine("Have you a car? Answer: " + hasCar);
            Console.ReadKey();*/

            /*3 задание*/
            string word;
            short a = Convert.ToInt16(Console.ReadLine(word));
            ulong b = Convert.ToUInt64(Console.ReadLine(word));
            char c = Convert.ToChar(Console.ReadLine(word));
            double d = Convert.ToDouble(Console.ReadLine(word));
        }
    }
}
