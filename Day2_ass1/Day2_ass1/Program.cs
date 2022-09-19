using System;

namespace Day2_ass1
{
        enum Category { A, B, C, D, E, F }
        class Product1
        {
            int prodid;
            string prodname;
            double price;
            DateTime dom;
            Category Cat;
            public Product1()
            {
                prodid = 5;
                prodname = "Pen";
                price = 7.50f;
                dom = new DateTime(2022, 9, 1);
                Cat = 0;
            }
            public Product1(int id, string name, double p, DateTime d, Category ca)
            {
                prodid = id;
                prodname = name;
                price = p;
                dom = d;
                Cat = ca;

            }
            public override string ToString()
            {
                return "\n The product details are: \n Product id: " + prodid + "\n" + " Product Name: " + prodname + "\n Price: " + price + "\n Date of Manufacture: " + dom.ToString() + "\n Category: " + Cat;
            }
        }
}

