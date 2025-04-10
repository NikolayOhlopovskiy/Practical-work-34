using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Car : Vehicle
    {
        private int power;
        public int Power { get; set; }
        public Car(int prise, int maxspeed, int year, int power)
           : base(prise, maxspeed, year)
        {
            this.Power = power;
        }
    }
}
