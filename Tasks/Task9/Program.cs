using System.Collections.Generic;
using System.Xml.Linq;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataIntializer dataIntializer = new DataIntializer();

            //IEnumerable<string> studentNames = dataIntializer.Students.Select(e=>e.Name);
            //foreach (string studentName in studentNames)
            //{
            //    Console.WriteLine(studentName);
            //}


            //Find all students who belong to the specific department
            //Department department = dataIntializer.Departments.SingleOrDefault(d=>d.Id == 7);
            //IEnumerable<Student> students = dataIntializer.Students.Where(s => s.department.Id == department.Id);
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.Name);
            //}


            //Find all students whose age is greater than 21.
            //IEnumerable<Student> students = dataIntializer.Students.Where(s=>s.Age>21);
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student.Name);
            //}
            //Console.WriteLine(students.Count());   //16


            //List each student with their department name.
            //var students = dataIntializer.Students.Select(e => new {studentName = e.Name, depName=e.department.Name});
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.studentName}  {student.depName}");
            //}


            //Display all students sorted by Age ascending.
            //var students = dataIntializer.Students.Select(student => new { sname = student.Name, age = student.Age,depname=student.department.Name})
            //                                      .OrderBy(s => s.age)
            //                                      .ThenBy(s=>s.depname)
            //                                      .ThenBy(s=>s.sname);
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.name}, {student.age}");
            //}

            //Display student names with their ages in the format: "Name: Ali, Age: 20".
            //var students = dataIntializer.Students.Select(s => new { name = s.Name, age = s.Age });
            //foreach(var student in students)
            //{
            //    Console.WriteLine($"Name: {student.name}, Age: {student.age}");
            //}

            //Find the average age of all students
            //double studentsAgeAverage = dataIntializer.Students.Average(s => s.Age);
            //Console.WriteLine(studentsAgeAverage);



            //Count how many students are in each department.
            //var departmentsStudentsCounts = dataIntializer.Students.GroupBy(s => s.department.Name)
            //                                                       .Select(g => new
            //                                                       {
            //                                                           Department = g.Key,
            //                                                           studs = g.Select(s=>s.Name),
            //                                                           Count = g.Count()
            //                                                       });
            //foreach (var dep in departmentsStudentsCounts)
            //{
            //    Console.Write(dep.Department);
            //    foreach(var stud in dep.studs)
            //    {
            //        Console.Write($" {stud}, ");
            //    }
            //    Console.WriteLine(dep.Count);
            //}


            //Find the youngest student in each department.
            //var youngestStudinDep = dataIntializer.Students.GroupBy(k => k.department.Name)
            //                                                                     .Select(dep => new
            //                                                                     {
            //                                                                         department = dep.Key,
            //                                                                         student = dep.Min(s => s.Age)
            //                                                                     });
            //foreach(var dep in youngestStudinDep)
            //{
            //    Console.WriteLine(dep);
            //}


            //Find the oldest student overall
            //Student oldestStudent = dataIntializer.Students.OrderByDescending(s=>s.Age)
            //                                               .FirstOrDefault();
            //Console.WriteLine($"{oldestStudent.Name} {oldestStudent.Age}");


            //List all courses offered in the department of each student.
            //var Courses = dataIntializer.Students.Select(stud => new
            //                                     {
            //                                         Name = stud.Name,
            //                                         courses = stud.department.Courses
            //                                     });

            //foreach(var c in Courses)
            //{
            //    Console.Write($"{c.Name}:   ");
            //    foreach (var item in c.courses)
            //    {
            //        Console.Write($"{item.Name}, ");
            //    }
            //    Console.WriteLine();
            //}


            //Create a list that shows:   Student Name  Department Name Number of Courses offered by that department
            //var students = dataIntializer.Students.Select(s => new
            //{
            //    studentName = s.Name,
            //    departmentName = s.department.Name,
            //    noOfDepCourses = s.department.Courses.Count()
            //});

            //foreach(var item in students)
            //{
            //    Console.WriteLine($"{item.studentName}, {item.departmentName}, {item.noOfDepCourses}");
            //}

        }
    }
}
