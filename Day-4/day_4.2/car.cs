using System;
using System.Collections.Generic;
using System.Text;

namespace day_4._2
{
    internal class car:vehical

    {
        public string Brand { get; set; }
        public string model { get; set; }

        public car(string brand, string model,string color, int speed):base(color,speed)
        {
            Brand = brand;
            this.model = model;
        }
    }

}
