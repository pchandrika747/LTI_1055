﻿using System;
using System.Collections.Generic;
using System.Text;

namespace day3_class
{
    internal class manager
    {
        class Manager : Employee
        {
            int SlsQty;
            decimal Commision;

            public Manager(int sls, decimal c, string n, decimal s) : base(n, s)
            {
                SlsQty = sls;
                Commision = c;
            }
            public new void GrossSalary()
            {

                Console.WriteLine("Gross Sale: " + SlsQty);
                Console.WriteLine("Commision: " + Commision);
            }


        }
    }
}
