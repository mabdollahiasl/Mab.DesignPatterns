using Mab.DesignPatterns.FactoryPattern.AbstractFactory;
using Mab.DesignPatterns.FactoryPattern.AbstractFactory.AndroidComponents;
using Mab.DesignPatterns.FactoryPattern.AbstractFactory.IOSComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mab.DesignPatterns.Test.AbstractFactory
{


    public class AbstractFactoryTest
    {
        [Fact]
        public void CreateFactoryTest()
        {
            var androidButton = GenericUIFactory.Create(OSUIType.Android, ComponentType.Button);
            Assert.IsType<AndroidButton>(androidButton);

            var androidTextBox = GenericUIFactory.Create(OSUIType.Android, ComponentType.TextBox);
            Assert.IsType<AndroidTextBox>(androidTextBox);


            var IOSButton = GenericUIFactory.Create(OSUIType.IOS, ComponentType.Button);
            Assert.IsType<IOSButton>(IOSButton);


            var IOSTextBox = GenericUIFactory.Create(OSUIType.IOS, ComponentType.TextBox);
            Assert.IsType<IOSTextBox>(IOSTextBox);

        }
    }
}
