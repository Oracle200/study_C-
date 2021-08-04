using System;

namespace For_While
{
    class Program
    {
        static void Main()
        {
            /*Задание 1
            for (int i = 25; i<=29; i++)
            {
                if (i == 27)
                    continue;
                System.Console.WriteLine(i);
            }                                    */
            
            /*Задание 2
            const int a = 13;
            int flag = 0;
            while(a != flag)
            {
                System.Console.WriteLine("Ведите число 13: ");
                flag = Convert.ToInt32(Console.ReadLine());
                if (a == flag)
                {
                    System.Console.WriteLine("You win");
                    break;
                }
            }                                                  */

            /*Задание 3
            for (int i = -30; i <= 0; i+=3)
            {
                if (i == -27 || i == -21 || i == -15)
                    continue;
                System.Console.WriteLine(i); 
            }                                  */

            /*Задание 4 */
            int a = 1;
            while (a != 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                    continue;
            }
        }
    }
}
