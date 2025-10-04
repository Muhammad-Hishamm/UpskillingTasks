using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Department
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public List<Course> Courses { get; set; }

        public Department(int id, string name, string description, string type, List<Course> courses)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Courses = courses;
        }
    }
}
