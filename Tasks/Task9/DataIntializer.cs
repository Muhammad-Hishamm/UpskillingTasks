using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class DataIntializer
    {
        public List<Course> Courses { get; private set; }
        public List<Department> Departments { get; private set; }
        public List<Student> Students { get; private set; }

        public DataIntializer()
        {
            // Initialize 10 courses
            Courses = new List<Course>
            {
                new Course(1, "Mathematics", "Basic Math Course"),
                new Course(2, "Physics", "Fundamentals of Physics"),
                new Course(3, "Chemistry", "Introduction to Chemistry"),
                new Course(4, "Biology", "Basics of Biology"),
                new Course(5, "Computer Science", "Intro to CS"),
                new Course(6, "English", "English Literature"),
                new Course(7, "History", "World History"),
                new Course(8, "Economics", "Principles of Economics"),
                new Course(9, "Philosophy", "Introduction to Philosophy"),
                new Course(10, "Art", "Art Appreciation")
            };

            // Initialize 10 departments, each with a subset of courses
            Departments = new List<Department>
            {
                new Department(1, "Science", "Science Department", "Academic", new List<Course> { Courses[0], Courses[1], Courses[2], Courses[3] }),
                new Department(2, "Technology", "Technology Department", "Academic", new List<Course> { Courses[4] }),
                new Department(3, "Humanities", "Humanities Department", "Academic", new List<Course> { Courses[5], Courses[6], Courses[8] }),
                new Department(4, "Business", "Business Department", "Academic", new List<Course> { Courses[7] }),
                new Department(5, "Arts", "Arts Department", "Academic", new List<Course> { Courses[9] }),
                new Department(6, "Mathematics", "Mathematics Department", "Academic", new List<Course> { Courses[0] }),
                new Department(7, "Languages", "Languages Department", "Academic", new List<Course> { Courses[5] }),
                new Department(8, "Social Sciences", "Social Sciences Department", "Academic", new List<Course> { Courses[6], Courses[7] }),
                new Department(9, "Philosophy", "Philosophy Department", "Academic", new List<Course> { Courses[8] }),
                new Department(10, "General Studies", "General Studies Department", "Academic", new List<Course> { Courses[0], Courses[5], Courses[9] })
            };

            // Initialize 10 students, each assigned to a department
            Students = new List<Student>
            {
                new Student(1, "Alice", 20) { department = Departments[0] },
                new Student(2, "Bob", 21) { department = Departments[1] },
                new Student(3, "Charlie", 22) { department = Departments[2] },
                new Student(4, "Diana", 23) { department = Departments[3] },
                new Student(5, "Ethan", 24) { department = Departments[4] },
                new Student(6, "Fiona", 25) { department = Departments[5] },
                new Student(7, "George", 26) { department = Departments[6] },
                new Student(8, "Hannah", 27) { department = Departments[7] },
                new Student(9, "Ian", 28) { department = Departments[8] },
                new Student(10, "Julia", 29) { department = Departments[9] },
                 new Student(11, "Alice", 20) { department = Departments[0] },
                new Student(12, "Bob", 21) { department = Departments[1] },
                new Student(33, "Charlie", 22) { department = Departments[2] },
                new Student(14, "Diana", 23) { department = Departments[3] },
                new Student(51, "Ethan", 24) { department = Departments[4] },
                new Student(61, "Fiona", 25) { department = Departments[5] },
                new Student(71, "George", 26) { department = Departments[6] },
                new Student(81, "Hannah", 27) { department = Departments[7] },
                new Student(91, "Ian", 28) { department = Departments[8] },
                new Student(110, "Julia", 29) { department = Departments[9] }
            };
        }
    }
}