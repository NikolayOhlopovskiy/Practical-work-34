using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._2
{
    class Garage
    {
        private List<Bicycle> bicycles = new List<Bicycle>();
        private List<Car> cars = new List<Car>();
        private List<Lorry> lorries = new List<Lorry>();

        public void AddBicycle(Bicycle b)
        {
            bicycles.Add(b);
        }

        public void AddCar(Car c)
        {
            cars.Add(c);
        }

        public void AddLorry(Lorry l)
        {
            lorries.Add(l);
        }

        public void GetAllBicycles()
        {
            foreach (var b in bicycles)
            {
                b.ShowInfo();
            }
        }

        public void GetAllCars()
        {
            foreach (var c in cars)
            {
                c.ShowInfo();
            }
        }

        public void GetAllLorries()
        {
            foreach (var l in lorries)
            {
                l.ShowInfo();
            }
        }
}   }
