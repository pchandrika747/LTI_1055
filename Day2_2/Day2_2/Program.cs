using System;

namespace Day2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medi m1 = new Medi();
            Console.WriteLine(m1);
            Medi m2 = new Medi(2, "Dolo-650", "Antibiotic", 8.50f, new DateTime(2022, 11, 11), Category.C);
            Console.WriteLine(m2);
        }
    }
        enum Category { A, B, C, D, E }
        class Medi
        {

            int medId;
            string medName;
            string medUse;
            double price;
            DateTime doe;
            Category cate;
            public Medi()
            {
                medId = 23;
                medName = "Crocin";
                medUse = "Fever";
                price = 25.50f;
                doe = new DateTime(2022, 4, 1);
                cate = Category.A;
            }
            public Medi(int id, string name, string use, double p, DateTime d, Category Ca)
            {
                medId = id;
                medName = name;
                medUse = use;
                price = p;
                doe = d;
                cate = Ca;
            }
            public override string ToString()
            {
            return "\n The Medicine details are: \n Medicine id: " + medId + "\n Medicine name: " + medName + "\n Medicine Use: " + medUse + "\n Price: " + price + "\n Date of Expiry: " + doe.ToString() + "\n Category: " + cate;
            }
        }
}

