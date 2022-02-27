## Design Patterns:

In this project, I try to implement common design pattern with some understandable examples:

## Factory Design Pattern:

**Method Factory:**
we use this pattern when we need to **manage creating objects** and we **don't care about child class(or subclass) type**.
Imagine we need a cross platform printer class which writes a text to console.
So we have interface like: 

    public interface IPrinter
    {
       void Print(string text);
    }

For Windows and Linux we implement class like this:

    public class LinuxPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine($"Linux Printed: {text}");
        }
    }
    public class WindowsPrinter : IPrinter
    {
            public void Print(string text)
            {
                Console.WriteLine($"Windows Printed: {text}");
            }
    }
In the client class we don't care about of type of the class that is LinuxPrinter or WindowsPrinter and we just want to print. So it's a good idea to use Method Factory Design Pattern and we create the following class:
 

    public class PrinterFactory
    {
        public static IPrinter Create(OsType type)
        {
           switch (type)
           {
              case OsType.Linux:
                   return new LinuxPrinter();
              case OsType.Windows:
                   return new WindowsPrinter();
              default:
                   throw new ArgumentException("Type Not found!");
          }
       }
    }
    public enum OsType
    {
       Linux,
       Windows
    } 

As you see the create method just return an IPrinter interface:

    var printer = PrinterFactory.Create(OsType.Windows);
    
    printer.Print("This printer test");

**Abstract Factory:**
This design pattern extend method factory in the other word it's a factory of factories.
**Sample Code:**

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

In the code above at first we create a factory class based the selected OS after that we create a IUIComponent by the factory that we've created before.

    var Button=GenericUIFactory.Create(OSUIType.IOS,ComponentType.Button);
    Button.Render();
