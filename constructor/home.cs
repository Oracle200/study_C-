using System;

namespace constructor
{
    class home
    {
        private byte etaj = 1;
        private int year = 2020;
        private string name = "Norma";

        public home()
        {
            System.Console.WriteLine("Empty constructor!");
        }

        public home(int year, string name)
        {
            this.year = year;
            this.name = name;
        }

        public home(byte etaj, int year, string name)
        {
            this.etaj = etaj;
            this.year = year;
            this.name = name;
        }

        public void Print()
        {
            System.Console.WriteLine(this.name);
            System.Console.WriteLine("Год постройки: " + this.year);
            System.Console.WriteLine("Кол-во этажей: " + this.etaj);
        }

        public int Let(int mainYear)
        {
            if (mainYear > this.year)
            {
                return mainYear - this.year;
            }
            else
            {
                System.Console.WriteLine("веддён не коректный год");
                return 0;
            }
        }
    }
}