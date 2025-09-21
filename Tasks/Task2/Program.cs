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

            //IMaintenance obj = new ServiceMachine();
            //obj.PowerOn();
            //obj.SelfCheck();


            //IPrinter securePrinter = new SecurePrinter();
            //securePrinter.PrintDocument("Hello Upskilling Team");

            //Copier copier = new Copier("Hp SHI135");
            //copier.Start();
            //copier.ShowModelInfo();

            //OfficeMachine, IPrinter, IScanner, IFax, IMaintenance
            OfficeMachine machine = new SmartCopier("Dell 145ddf");
            machine.Start();
            machine.ShowModelInfo();

            IPrinter copierPrinter = new SmartCopier("Dell 145ddf");
            copierPrinter.PrintDocument("Hello from printDocument Method");

            IScanner copierScanner = new SmartCopier("DEll 145ddf");
            copierScanner.Scan("Hello from the scan method");

            IFax copierFax = new SmartCopier("Dell 145ddf");
            copierFax.Fax("Dell", "145ddf");

            IMaintenance copierMaintainance = new SmartCopier("Dell 145ddf");
            copierMaintainance.PowerOn();
            copierMaintainance.SelfCheck();

        }
    }
}
