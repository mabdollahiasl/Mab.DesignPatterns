using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.AbstractFactory
{
    public interface IUIFactory
    {
        IUIComponent Create(ComponentType type);
    }
    public enum ComponentType
    {
        Button,
        TextBox
    }
}
