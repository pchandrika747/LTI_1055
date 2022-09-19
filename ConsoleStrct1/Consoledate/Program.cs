using Console_class_object;
using System;

namespace Console_class_object
{
    internal class Class1
    {
        static void main(string[] args)
        {
            Class1 cc = new Class1();
            Class1 birthdate = new Class1(12, 12, 2012);
            Console.WriteLine(cc);
            Console.WriteLine(birthdate);

        }
        private int day, month, year;
        public Class1()
        {
            day = 15;
            month = 8;
            year = 1947;
        }

        public Class1(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }


        public override string ToString()
        {
            return day + "-" + month + "-" + year;
        }
        

    }
}
