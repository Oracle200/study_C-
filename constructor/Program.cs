using System;

namespace constructor
{
    class Program
    {
        static void Main()
        {
			home school = new home(4, 2015, "School");
			home kidgarden = new home(2019, "kindergarten");
			home shop = new home();
            
            school.Print();       
            System.Console.WriteLine("_______________");
            kidgarden.Print();
            System.Console.WriteLine("_______________");
            shop.Print();
        }
    }
}
