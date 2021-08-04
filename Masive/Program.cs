using System;

namespace Masive
{
    class Program
    {
        static void Main()
        {
            /*Задание 1
            int[] array_1 = {1, 2, 3, 5, 7, 9, 10};
            int[] array_2 = {1, 4, 3, 5, 8, 9, 0};
            for (int i = 0; i < array_1.Length; i++)
                for (int j = 0; j < array_2.Length; j++)
                    if (array_1[i] == array_2[j])
                        System.Console.WriteLine(array_1[i]);*/

            /*Задание 2*/
            int [,] a = { { 0, 34, -2 },
                          { 3, -4, 5 } };
            int min = a[0, 0];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    if (min > a[i, j])
                        min = a[i, j];
            System.Console.WriteLine("min = " + min);
        }
    }
}
