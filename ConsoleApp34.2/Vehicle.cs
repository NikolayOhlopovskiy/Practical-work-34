using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._2
{
    abstract class Vehicle
    {
        public int Price { get; set; }
        public int Maxspeed { get; set; }
        public int Year { get; set; }

        public Vehicle(int price, int maxspeed, int year)
        {
            Price = price;
            Maxspeed = maxspeed;
            Year = year;
        }

        public abstract void ShowInfo();
    }
}
