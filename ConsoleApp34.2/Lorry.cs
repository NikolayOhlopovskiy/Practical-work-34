using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._2
{
    class Lorry : Vehicle
    {
        public int MaxCapacity { get; set; }

        public Lorry(int price, int maxspeed, int year, int maxCapacity)
            : base(price, maxspeed, year)
        {
            MaxCapacity = maxCapacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Грузовик: Цена: {Price}  Макс. скорость: {Maxspeed}  Год: {Year}  Грузоподъемность: {MaxCapacity} кг");
        }
    }
}
