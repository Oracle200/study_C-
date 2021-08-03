using System;

namespace IF_ELSE
{
    class Program
    {
        static void Main()
        {
            /*Задание 1
            int a =Convert.ToInt32(Console.ReadLine());
            int b =Convert.ToInt32(Console.ReadLine());
            if ( a%2==0 && b%2==0)
                System.Console.WriteLine("Оба числа чётные");
            else if (a%2==0)
                System.Console.WriteLine("чётное только А");
            else if (b%2==0)
                System.Console.WriteLine("чётное только Б");
            else
                System.Console.WriteLine("нету чётных чисел");*/

            
            /*Задание 2
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            if (b==0)
                res = 1;
            else 
                res = a / b;
            System.Console.WriteLine(res); */

            /*Задание 3 */
            int a = Convert.ToInt32(Console.ReadLine());
            if ((a < 50 && a >= 32 && a != 37) || (a == 0 || a == 15))
                System.Console.WriteLine("Working");
            else 
                System.Console.WriteLine("NoWorking");   
        }
    }
}
