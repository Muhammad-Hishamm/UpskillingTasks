using System.Net.Http.Headers;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SimplPrinter printer = new SimplPrinter();
            //printer.Print("Invoice.pdf");

            //SmartDevice obj = new SmartDevice();
            //obj.Scan("Teka");
            //obj.Fax("Teka", "123");
            //obj.Print("Teka");

            IMaintenance obj = new ServiceMachine();
            obj.PowerOn();
            obj.SelfCheck();
        }
    }
}
