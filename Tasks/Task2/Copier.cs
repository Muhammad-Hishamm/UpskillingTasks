using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Copier:OfficeMachine
    {
        public Copier(string name) : base(name) { }
        public override void Start()
        {
            Console.WriteLine($"Copier is starting up...");
        }
    }
}
