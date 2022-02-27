using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.AbstractFactory
{
    public class GenericUIFactory
    {
        public static IUIComponent Create(OSUIType os,ComponentType component)
        {
            IUIFactory uiFactory;
            switch (os)
            {
                case OSUIType.Android:
                    uiFactory=new AndroidFactory();
                    break;
                case OSUIType.IOS:
                    uiFactory=new IOSFactory();
                    break;
                default:
                    throw new ArgumentException("Os Not Found!");
                    
            }
            return uiFactory.Create(component);
        }
    }
    public enum OSUIType
    {
        Android,
        IOS
    }
}
