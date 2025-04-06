using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Выберите нужное Вам действие:");
                Console.WriteLine("1. Добавить в список велосипед;");
                Console.WriteLine("2. Добавить в список машину;");
                Console.WriteLine("3. Добавить в список грузовик;");
                Console.WriteLine("4. Вывести все велосипеды из списка;");
                Console.WriteLine("5. Вывести все машины из списка;");
                Console.WriteLine("6. Вывести все грузовики из списка;");
                Console.WriteLine("7. Выход.");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите цену: ");
                        int bPrice = int.Parse(Console.ReadLine());
                        Console.Write("Введите максимальную скорость: ");
                        int bSpeed = int.Parse(Console.ReadLine());
                        Console.Write("Введите год: ");
                        int bYear = int.Parse(Console.ReadLine());
                        Console.Write("Введите количество пассажиров: ");
                        int bPassengers = int.Parse(Console.ReadLine());
                        garage.AddBicycle(new Bicycle(bPrice, bSpeed, bYear, bPassengers));
                        break;

                    case "2":
                        Console.Write("Введите цену: ");
                        int cPrice = int.Parse(Console.ReadLine());
                        Console.Write("Введите максимальную скорость: ");
                        int cSpeed = int.Parse(Console.ReadLine());
                        Console.Write("Введите год: ");
                        int cYear = int.Parse(Console.ReadLine());
                        Console.Write("Введите мощность: ");
                        int cPower = int.Parse(Console.ReadLine());
                        garage.AddCar(new Car(cPrice, cSpeed, cYear, cPower));
                        break;

                    case "3":
                        Console.Write("Введите цену: ");
                        int lPrice = int.Parse(Console.ReadLine());
                        Console.Write("Введите максимальную скорость: ");
                        int lSpeed = int.Parse(Console.ReadLine());
                        Console.Write("Введите год: ");
                        int lYear = int.Parse(Console.ReadLine());
                        Console.Write("Введите грузоподъемность: ");
                        int lCapacity = int.Parse(Console.ReadLine());
                        garage.AddLorry(new Lorry(lPrice, lSpeed, lYear, lCapacity));
                        break;

                    case "4":
                        garage.GetAllBicycles();
                        break;

                    case "5":
                        garage.GetAllCars();
                        break;

                    case "6":
                        garage.GetAllLorries();
                        break;

                    case "7":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine();
            }
              Console.ReadKey();
        }
}   }
