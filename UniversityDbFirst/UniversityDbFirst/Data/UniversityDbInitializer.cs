using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UniversityDbFirst.Data
{
    public static class UniversityDbInitializer
    {
        public static UniversityDBEntities1 Seed()
        {
            var context = new UniversityDBEntities1();
            if (!context.Departments.Any())
            {
                var departments = new[]
                {
                new Department { Name = "Computer Science", OfficeLocation = "Building A" },
                new Department { Name = "Mathematics", OfficeLocation = "Building B" },
                new Department { Name = "Physics", OfficeLocation = "Building C" },
                new Department { Name = "Literature", OfficeLocation = "Building D" }
            };
                foreach (var department in departments)
                {
                    context.Departments.Add(department);
                }
                context.SaveChanges();
            }

            //  Teachers
            if (!context.Teachers.Any())
            {
                var teachers = new[]
                {
                    new Teacher { FullName = "Alice Johnson", Email = "alice@univ.edu", HireDate = DateTime.Now.AddYears(-5), DepartmentId = 1 },
                    new Teacher { FullName = "Bob Smith", Email = "bob@univ.edu", HireDate = DateTime.Now.AddYears(-3), DepartmentId = 2 },
                    new Teacher { FullName = "Carol Lee", Email = "carol@univ.edu", HireDate = DateTime.Now.AddYears(-4), DepartmentId = 3 },
                    new Teacher { FullName = "David Kim", Email = "david@univ.edu", HireDate = DateTime.Now.AddYears(-2), DepartmentId = 1 }
                };

                foreach (var teacher in teachers)
                {
                    context.Teachers.Add(teacher);
                }
                context.SaveChanges();
            }

            //  Courses
            if (!context.Courses.Any())
            {
                var courses = new[]
                {
                new Course { Title = "Intro to Programming", Credits = 3, DepartmentId = 1 },
                new Course { Title = "Calculus I", Credits = 4, DepartmentId = 2 },
                new Course { Title = "Modern Physics", Credits = 3, DepartmentId = 3 },
                new Course { Title = "English Literature", Credits = 2, DepartmentId = 4 }
            };
                foreach (var course in courses)
                {
                    context.Courses.Add(course);
                }
                context.SaveChanges();
            }

            //  Students
            if (!context.Students.Any())
            {
                var students = new[]
                {
                new Student { FullName = "Emily Carter", Email = "emily@student.edu", EnrollmentDate = DateTime.Now.AddYears(-1) },
                new Student { FullName = "Frank Moore", Email = "frank@student.edu", EnrollmentDate = DateTime.Now.AddYears(-2) },
                new Student { FullName = "Grace Hall", Email = "grace@student.edu", EnrollmentDate = DateTime.Now.AddMonths(-6) },
                new Student { FullName = "Henry Adams", Email = "henry@student.edu", EnrollmentDate = DateTime.Now.AddMonths(-3) }
            };
                foreach (var student in students)
                {
                    context.Students.Add(student);
                }
                context.SaveChanges();
            }

            //  Enrollments
            if (!context.Enrollments.Any())
            {
                var enrollments = new[]
                {
                new Enrollment { CourseId = 1, StudentId = 1, Grade = 90 },
                new Enrollment { CourseId = 2, StudentId = 2, Grade = 85 },
                new Enrollment { CourseId = 3, StudentId = 3, Grade = 88 },
                new Enrollment { CourseId = 4, StudentId = 4, Grade = null }
            };
                foreach (var enrollment in enrollments)
                {
                    context.Enrollments.Add(enrollment);
                }
                context.SaveChanges();
            }

            // TeacherCourse relationships
            if (!context.TeacherCourses.Any())
            {
                var teacherCourses = new[]
                {
                new TeacherCourse { TeacherId = 1, CourseId = 1 },
                new TeacherCourse { TeacherId = 2, CourseId = 2 },
                new TeacherCourse { TeacherId = 3, CourseId = 3 },
                new TeacherCourse { TeacherId = 4, CourseId = 1 }
            };
                foreach (var teachercourse in teacherCourses)
                {
                    context.TeacherCourses.Add(teachercourse);
                }
                context.SaveChanges();
            }
            return context;
        }
    }
}
