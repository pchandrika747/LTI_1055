using System;
using System.Collections.Generic;
using System.Text;

namespace day_4._2
{
    internal class vehical
    {
        public string color { get; set; }

        public int speed { get; set; }

        public vehical (string color, int speed)
        {
            this.color = color;
            this.speed = speed;
        }   

        public void showSpeed()
    }
}
