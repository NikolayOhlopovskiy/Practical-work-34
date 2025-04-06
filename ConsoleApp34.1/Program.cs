using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Software> database = new List<Software>
        {
            new FreeSoftware("Notepad++", "Notepad++ Team"),
            new Shareware("Adobe Photoshop", "Adobe", new DateTime(2024, 2, 14, 18, 0, 16), 30),
            new Commercial("Microsoft Office", "Microsoft", 1000, new DateTime(2023, 12, 26, 18, 0, 16), 365)
        };

            Console.WriteLine("Полная информация из базы:");
            foreach (var software in database)
            {
                software.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Программное обеспечение, которое допустимо использовать на текущую дату:");
            foreach (var software in database)
            {
                if (software.IsUsable())
                    Console.WriteLine(software.Name);
            }
            Console.ReadKey();
        }
    }
}
