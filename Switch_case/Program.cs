using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1
            int num = 11;
            switch(num)
            {
                case 10:
                    System.Console.WriteLine("Number is 10");
                    break;
                case 15:
                    System.Console.WriteLine("Number is 15");
                    break;
                default:
                    System.Console.WriteLine("Something else");
                    break;                                           
            }                                                       */
            
            // Задание 2
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            char simvol = Convert.ToChar(Console.ReadLine());
            switch(simvol)
            {
                case '+' :
                    res = a+b;
                    System.Console.WriteLine(res);
                    break;
                case '-' :
                    res = a-b;
                    System.Console.WriteLine(res);                
                    break;
                case '*' :
                    res = a*b;
                    System.Console.WriteLine(res);                
                    break;
                case '/' :
                    res = a/b;
                    System.Console.WriteLine(res);                
                    break;                    
            }
        }
    }
}
