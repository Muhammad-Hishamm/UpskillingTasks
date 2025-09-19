using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    internal class MyStringCollection
    {
        private List<string> list;

        public MyStringCollection()
        {
            list = new List<string>();
        }

        public string this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public void  Add(string item)
        {
            list.Add(item);
        }

        public void Remove(string item)
        {
            list.Remove(item);
        }

        public bool Contains(string item)
        {
            return list.Contains(item);
        }

        public void PrintAll()
        {
            foreach(string it in list)
            {
               Console.Write(it);
            }
        }
    }
}
