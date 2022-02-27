// See https://aka.ms/new-console-template for more information
using Mab.DesignPatterns.FactoryPattern.AbstractFactory;
using Mab.DesignPatterns.FactoryPattern.MethodFactory;

var printer = PrinterFactory.Create(OsType.Windows);

printer.Print("This printer test");

var Button=GenericUIFactory.Create(OSUIType.IOS,ComponentType.Button);
Button.Render();
