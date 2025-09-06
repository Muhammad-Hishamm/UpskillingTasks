using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SimplPrinter:IPrinter
    {
        public void Print(string documentName) {

            Console.WriteLine($"Printing Document: {documentName}");
        }
    }
}
