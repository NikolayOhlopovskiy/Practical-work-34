using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._2
{
    class Car : Vehicle
    {
        public int Power { get; set; }

        public Car(int price, int maxspeed, int year, int power)
            : base(price, maxspeed, year)
        {
            Power = power;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Машина: Цена: {Price}  Макс. скорость: {Maxspeed}  Год: {Year}  Мощность: {Power} л.с.");
        }
    }

}
