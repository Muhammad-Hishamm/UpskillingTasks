using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SmartCopier : OfficeMachine, IPrinter, IScanner, IFax, IMaintenance
    {
        public SmartCopier(string modelName) : base(modelName){ }

        void IFax.Fax(string doc, string number)
        {
            Console.WriteLine($"SmartCopier faxing: {doc} to {number}");
        }

        public void Scan(string doc)
        {
           Console.WriteLine($"SmartCopier scanning: {doc}");
        }

        public override void Start()
        {
            Console.WriteLine("SmartCopier is initializing...");
        }

        void IDevice.PowerOn()
        {
            Console.WriteLine("SmartCopier is powered on.");
        }

        void IPrinter.PrintDocument(string document)
        {
            Console.WriteLine($"SmartCopier printing: {document}");
        }

        void IMaintenance.SelfCheck()
        {
            Console.WriteLine($"SmartCopier self-check in progress...");
        }
    }
}
