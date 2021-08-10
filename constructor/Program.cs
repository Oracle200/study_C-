using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            home scoll = new home();
            home panel = new home();
            scoll.Zap(4, 1950, "Школа");
            panel.Zap(9, 1900, "Панелька");
            scoll.Print();
            System.Console.WriteLine(scoll.Let(2021));
            System.Console.WriteLine("_______________");
            panel.Print();
            System.Console.WriteLine(panel.Let(2021));
        }
    }
}
