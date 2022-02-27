using Mab.DesignPatterns.FactoryPattern.AbstractFactory.AndroidComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.AbstractFactory
{
    public class AndroidFactory : IUIFactory
    {
        public IUIComponent Create(ComponentType type)
        {
            switch (type)
            {
                case ComponentType.Button:
                    return new AndroidButton();
                case ComponentType.TextBox:
                    return new AndroidTextBox();
                default:
                    throw new ArgumentException("Not Implemented!");
            }
        }
    }
}
