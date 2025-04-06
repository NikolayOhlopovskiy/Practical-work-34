using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._2
{
    class Bicycle : Vehicle
    {
        public int MaxPassengers { get; set; }

        public Bicycle(int price, int maxspeed, int year, int maxPassengers)
            : base(price, maxspeed, year)
        {
            MaxPassengers = maxPassengers;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Велосипед: Цена: {Price}  Макс. скорость: {Maxspeed}  Год: {Year}  Макс. пассажиров: {MaxPassengers}");
        }
    }


}
