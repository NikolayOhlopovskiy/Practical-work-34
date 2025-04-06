using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._1
{
    class Commercial : Software
    {
        public double Price { get; set; }
        public DateTime InstallDate { get; set; }
        public int UsageDays { get; set; }

        public Commercial(string name, string developer, double price, DateTime installDate, int usageDays)
            : base(name, developer)
        {
            Price = price;
            InstallDate = installDate;
            UsageDays = usageDays;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Дата установки: {InstallDate}");
            Console.WriteLine($"Срок использования: {UsageDays} дней");
        }

        public override bool IsUsable()
        {
            return (DateTime.Now - InstallDate).TotalDays <= UsageDays;
        }
    }
}
