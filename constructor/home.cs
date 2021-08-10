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

        public home(int ye, string na)
        {
            year = ye;
            name = na;
        }

        public home(byte _e, int _y, string _n)
        {
            etaj = _e;
            year = _y;
            name = _n;
        }

        public void Print()
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine("Год постройки: " + year);
            System.Console.WriteLine("Кол-во этажей: " + etaj);
        }

        public int Let(int mainYear)
        {
            if (mainYear > year)
            {
                return mainYear - year;
            }
            else
            {
                System.Console.WriteLine("веддён не коректный год");
                return 0;
            }
        }
    }
}