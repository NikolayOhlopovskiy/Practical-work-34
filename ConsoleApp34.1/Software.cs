using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34._1
{
    abstract class Software
    {
        public string Name { get; set; }
        public string Developer { get; set; }

        public Software(string name, string developer)
        {
            Name = name;
            Developer = developer;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Производитель: {Developer}");
        }

        public abstract bool IsUsable();
    }
}
