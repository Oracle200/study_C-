using System;

namespace oop
{
    class auto
    {
        private int weight;
        private string mark;
        private char color;
        private double speed;

        public void zap (int w, string m, char c, double s)
        {
            weight = w;
            mark = m;
            color = c;
            speed = s;
        }

        public void print()
        {
            System.Console.WriteLine("марка: " + mark);
            System.Console.WriteLine("цвет: " + color);
            System.Console.WriteLine("вес: " + weight);
            System.Console.WriteLine("скорость: " + speed);
            System.Console.WriteLine("--------------");
        }
    }
}