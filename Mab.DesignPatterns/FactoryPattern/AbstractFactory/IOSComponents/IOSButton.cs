using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.AbstractFactory.IOSComponents
{
    public class IOSButton : IUIComponent
    {
        public string Text { get; set; }

        public void Render()
        {
            this.Text = "IOS Button";
            Console.WriteLine("IOS Button Renderd!");
        }
    }
}
