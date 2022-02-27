﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.MethodFactory
{
    public class WindowsPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine($"Windows Printed: {text}");
        }
    }
}
