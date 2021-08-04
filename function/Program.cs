using System;

namespace function
{
    class Program
    {
        /*Задание 1
        static void Main()
        {
            int time = Convert.ToInt32(Console.ReadLine());
            int speed = Convert.ToInt32(Console.ReadLine());
            int res = km(time, speed);
            print(res);
        }
        public static int km(int a, int b)
        {
            return a * b;
        }
        public static void print(int result)
        {
            if (result == 1)
                System.Console.WriteLine("Вы проедете: 1 километр");
            else 
                System.Console.WriteLine("Вы проедете: {0} километров", result);
        }
        */


        /*Задание 2*/
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            sravn(a, b);
        }

        public static void sravn(int num_1, int num_2)
        {
            if (num_1 > num_2)
            {
                System.Console.WriteLine(">");
            }
            else if (num_1 < num_2)
            {
                System.Console.WriteLine("<");
            }
            else
            {
                System.Console.WriteLine("=");
            }
        }

    }
}
