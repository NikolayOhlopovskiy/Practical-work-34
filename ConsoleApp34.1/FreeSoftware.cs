using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._1
{
    class FreeSoftware : Software
    {
        public FreeSoftware(string name, string developer)
            : base(name, developer) { }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }

        public override bool IsUsable()
        {
            return true; // Всегда доступно
        }
    }
}
