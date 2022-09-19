using System;

namespace Console_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P = new Point(10, 20);
            Console.WriteLine("X co ordinate : " + P.X);
            Console.WriteLine(" Y co ordinate : " + P.Y);
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.Month);
        }
    }
    public struct Point

    {

        int x, y;

        public Point(int x, int y)

        {

            this.x = x;

            this.y = y;

        }

        public int X

        {

            get { return x; }

            set { x = value; }

        }

        public int Y

        {

            get { return y; }

            set { y = value; }

        }

    }
}
