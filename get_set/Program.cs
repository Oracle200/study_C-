using System;

namespace get_set
{
    class Program
    {
        static void Main(string[] args)
        {
            Person one = new Person();
            one.Age = 150;
            one.Age = 54;
            one.Age = -100;

            amount car = new amount();
            System.Console.WriteLine(car.Wheels);
        }
    }
}
