using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal abstract class OfficeMachine
    {
        string _modelName;
        public  OfficeMachine(string modelName)
        {
            _modelName = modelName;
        }

        public void ShowModelInfo()
        {
            Console.WriteLine($"Model: {_modelName}");
        }

        public abstract void Start();
    }
}
