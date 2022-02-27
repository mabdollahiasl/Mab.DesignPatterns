using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.AbstractFactory.AndroidComponents
{
    public class AndroidButton:IUIComponent
    {
        public string Text { get; set; }

        public void Render()
        {
            this.Text = "Android Button";
            Console.WriteLine("Android Button Renderd!");
        }
    }
}
