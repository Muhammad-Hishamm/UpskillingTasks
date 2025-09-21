using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SecurePrinter:IPrinter
    {
        void IPrinter.PrintDocument(string document)
        {
            Console.WriteLine($"[SecurePrinter] Printing confidential document: {document}");
        }
    }
}
