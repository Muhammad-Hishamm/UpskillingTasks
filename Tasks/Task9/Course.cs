using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Course
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Course(int id , string name, string description) {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
