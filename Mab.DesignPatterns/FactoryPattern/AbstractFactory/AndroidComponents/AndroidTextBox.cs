using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns.FactoryPattern.AbstractFactory.AndroidComponents
{
    public class AndroidTextBox : IUIComponent
    {
        public string Text { get; set; }

        public void Render()
        {
            this.Text = "Android TextBox";
            Console.WriteLine("Android TextBox Renderd!");
        }
    }
}
