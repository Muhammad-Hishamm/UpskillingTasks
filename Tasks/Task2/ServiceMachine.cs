using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ServiceMachine:IMaintenance
    {
        public void SelfCheck()
        {
            Console.WriteLine("Running diagnostics...");
        }
        public void PowerOn()
        {
            Console.WriteLine("Device is now powered on.");
        }
    }
}
