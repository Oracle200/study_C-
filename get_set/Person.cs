using System;

namespace get_set
{
    class Person
    {
        private int age;

        public int Age
        {
            set
            {
                if (value > 145)
                    System.Console.WriteLine("People can not live so much");
                else if (value <= 0)
                    System.Console.WriteLine("Minimal age is 1");
                else 
                    this.age = value;
            }
        }
    }
}