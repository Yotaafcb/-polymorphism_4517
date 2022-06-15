using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_21_11_4517
{
    public class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer display dimension: default*default");
        }

        public virtual void Print()
        {
            Console.WriteLine("Default Printer Printing.....");
        }
    }
}
