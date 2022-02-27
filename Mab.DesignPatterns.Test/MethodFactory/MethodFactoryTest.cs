using Mab.DesignPatterns.FactoryPattern.MethodFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mab.DesignPatterns.Test.MethodFactory
{
    public class MethodFactoryTest
    {
        [Fact]
        public void CreateFactoryTest()
        {
            var linuxPrinter = PrinterFactory.Create(OsType.Linux);
            Assert.IsType<LinuxPrinter>(linuxPrinter);

            var windowsPrinter = PrinterFactory.Create(OsType.Windows);
            Assert.IsType<WindowsPrinter>(windowsPrinter);

        }
    }
}
