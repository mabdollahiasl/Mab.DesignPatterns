using Mab.DesignPatterns.FactoryPattern.AbstractFactory.IOSComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.AbstractFactory
{
    public class IOSFactory : IUIFactory
    {
        public IUIComponent Create(ComponentType type)
        {
            switch (type)
            {
                case ComponentType.Button:
                    return new IOSButton();
                case ComponentType.TextBox:
                    return new IOSTextBox();
                default:
                    throw new ArgumentException("Not Implemented!");
            }
        }
    }
}
