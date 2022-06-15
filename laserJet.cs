﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_21_11_4517
{
    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension: 12*12 ");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet Printer Printing.....");
        }
    }
}
