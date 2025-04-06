using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._1
{
    class Shareware : Software
    {
        public DateTime InstallDate { get; set; }
        public int TrialDays { get; set; }

        public Shareware(string name, string developer, DateTime installDate, int trialDays)
            : base(name, developer)
        {
            InstallDate = installDate;
            TrialDays = trialDays;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Дата установки: {InstallDate}");
            Console.WriteLine($"Срок бесплатного использования: {TrialDays} дней");
        }

        public override bool IsUsable()
        {
            return (DateTime.Now - InstallDate).TotalDays <= TrialDays;
        }
    }
}
