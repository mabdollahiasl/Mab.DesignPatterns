using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.MethodFactory
{
    public class PrinterFactory
    {
        public static IPrinter Create(OsType type)
        {
            switch (type)
            {
                case OsType.Linux:
                    return new LinuxPrinter();
                case OsType.Windows:
                    return new WindowsPrinter();
                default:
                    throw new ArgumentException("Type Not found!");
            }
        }
    }
    public enum OsType
    {
        Linux,
        Windows
    }
}
