using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    abstract class Vehicle
    {
        protected Exception OutOfMaxBorder = new Exception("Исключение, превышена Maкс. граница");
        protected Exception NonBellowZero = new Exception("Исключение, введенное значение не может быть отрицательным!");
        protected int price, maxspeed, year;
        public int Price
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }
        public int Maxspeed
        {
            get { return maxspeed; }
            set { if (value > 0) maxspeed = value; }
        }
        public int Year
        {
            get { return year; }
            set { if (value <= DateTime.Today.Year) year = value; }
        }
        public Vehicle() { }
        public Vehicle(int price, int maxspeed, int year)
        {
            this.Price = price;
            this.Maxspeed = maxspeed;
            this.Year = year;
        }
    }
}
