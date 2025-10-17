using Iced.Intel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UniversityDbFirst.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Runtime;
using Microsoft.EntityFrameworkCore;

namespace UniversityDbFirst
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //var context = UniversityDbInitializer.Seed();
            var context = new UniversityDBEntities1();


            #region aAssign teachers to courses using the TeacherCourse table
            //var teacherCourse1 = new TeacherCourse()
            //{
            //    TeacherId = 1,
            //    CourseId = 4,
            //};

            //var teachercourse2 = new TeacherCourse()
            //{
            //    TeacherId = 2,
            //    CourseId = 3,
            //};
            ////context.TeacherCourses.Add(teacherCourse1);
            //context.TeacherCourses.Add(teachercourse2);

            //Enroll each student in multiple courses using the Enrollment table.
            //var erollment1 = new Enrollment()
            //{
            //    StudentId = 1,
            //    CourseId = 3,
            //};
            //var erollment2 = new Enrollment()
            //{
            //    StudentId = 2,
            //    CourseId = 4,
            //};

            //context.Enrollments.Add(erollment1);
            //context.Enrollments.Add(erollment2);
            //context.SaveChanges(); 
            #endregion

            #region List all courses with their department name and assigned teachers.
            //var coursess = context.TeacherCourses
            //                      .Select(teachercourse => new
            //                      {
            //                          teacherName = teachercourse.Teacher.FullName,
            //                          courseName = teachercourse.Course.Title,
            //                          department = teachercourse.Course.Department.Name
            //                      });
            #endregion

            #region Display all students with the courses they are enrolled in and their grades.
            //var studentCourses = context.Enrollments
            //                     .Select(enrollment => new
            //                     { 
            //                        studentName = enrollment.Student.FullName,
            //                        courseName = enrollment.Course.Title,
            //                        grade = enrollment.Grade != null ? enrollment.Grade.Value : -1
            //                     }); 
            #endregion

            #region Show all teachers in each department. 
            //var departmentTeachers = context.Departments
            //                                .Select(dep => new
            //                                {
            //                                    teachers = dep.Teachers,
            //                                    department = dep.Name
            //                                }).ToList();

            #endregion

            #region List all departments with the number of teachers and courses in each.
            //var departments = context.Departments.Select(dep => new
            //{
            //    department = dep.Name,
            //    noOfTeachers = dep.Teachers.Count(),
            //    noOfCourses = dep.Courses.Count()
            //}); 
            #endregion

            #region Implement pagination when displaying students and courses(for example, show 5 records per page).
            //int pageSize = 1;
            //int page = 0; 
            //int count = context.Students.Count();
            //while (count!=0)
            //{
            //    count--;
            //    var students = context.Students
            //                          .OrderBy(s => s.StudentId)
            //                          .Skip(page * pageSize)
            //                          .Take(pageSize)
            //                          .ToList();
            //    page++;
            //    foreach (var student in students)
            //        Console.WriteLine($"Student ID: {student.StudentId}, Name: {student.FullName}");
            //}
            #endregion

            #region Implement a search feature that allows searching:
            //Students by name or email
            //Courses by title
            //Teachers by name

            //string studentSearchTerm = "Hall";
            //var studentResultsWithName = context.Students
            //                            .Where(student => student.FullName.Contains(studentSearchTerm)).ToList();
            //var studentResultsWithEmail = context.Students
            //                            .Where(student => student.Email.Contains(studentSearchTerm)).ToList();
            //var CourseResultsWithTitle = context.Courses
            //                            .Where(course => course.Title.Contains(studentSearchTerm)).ToList();
            //var teacherResultsWithName = context.Teachers
            //                           .Where(teacher => teacher.FullName.Contains(studentSearchTerm)).ToList(); 
            #endregion

            #region Update a student’s grade for a specific course.
            //int courseIDtoUpdate = 3;
            //int studentIDtoUpdate = 1;
            //var enrollmentToChange = context.Enrollments
            //                                .FirstOrDefault(enrollment => enrollment.CourseId == courseIDtoUpdate
            //                                                           && enrollment.StudentId == studentIDtoUpdate);
            //if (enrollmentToChange!= null)
            //{
            //    enrollmentToChange.Grade = 5;
            //}
            //context.SaveChanges();
            #endregion

            #region Change a teacher’s department.
            int teacherId = 2;
            var teacherToUpdate = context.Teachers.FirstOrDefault(teacher => teacher.TeacherId == teacherId);
            if (teacherToUpdate != null)
            {
                teacherToUpdate.DepartmentId = 1; // New department ID
            }
            context.SaveChanges();
            #endregion

            #region Update a course’s credit hours.
            int courseIdToUpdate = 3;   
            var courseToUpdtate = context.Courses.FirstOrDefault(course => course.CourseId == courseIdToUpdate);
            if(courseToUpdtate != null)
            {
                courseToUpdtate.Credits = 5; // New credit hours
            }
            context.SaveChanges();
            #endregion

            #region Modify a student’s email or name.

            int studentIdToUpdate = 1;
            //string newEmail = "Teka@gmail.com";
            //var studentToUpdate = context.Students.FirstOrDefault(student => student.StudentId == studentIdToUpdate);
            //if (studentToUpdate != null)
            //{
            //    studentToUpdate.Email = newEmail;
            //    context.SaveChanges();
            //}

            //string newName = "Teka";
            //var studentToUpdate = context.Students.FirstOrDefault(student => student.StudentId == studentIdToUpdate);
            //if (studentToUpdate != null)
            //{
            //    studentToUpdate.FullName = newName;
            //    context.SaveChanges();
            //}
            #endregion

            #region Delete a student and their related enrollment records.
            //int studentIdToDelete = 3;
            //var enrollmentsToDelete = context.Enrollments
            //                                 .Where(enrollment => enrollment.StudentId == studentIdToDelete);
            //foreach (var enrollment in enrollmentsToDelete)
            //{
            //    context.Enrollments.Remove(enrollment);
            //}

            //var studentToDelete = context.Students.FirstOrDefault(student=>student.StudentId == studentIdToDelete);
            //if (studentToDelete != null)
            //{
            //    context.Students.Remove(studentToDelete);
            //    context.SaveChanges();
            //}


            #endregion

            #region Delete a course only if no students are currently enrolled in it.

            //var courses = context.Courses.ToList();
            //foreach (var course in courses)
            //{
            //    var coursesToDelete= context.Courses.Where(c => c.CourseId == course.CourseId);
            //    if (coursesToDelete != null)
            //    {
            //        var teacherCoursesToDelete = context.TeacherCourses.Where(teacherCourse => teacherCourse.CourseId == course.CourseId);
            //        foreach(var tc in teacherCoursesToDelete)
            //        {
            //            context.TeacherCourses.Remove(tc);
            //        }
            //        context.Courses.Remove(course);
            //        context.SaveChanges();
            //    }
            //}
            #endregion

            #region Delete a department only after handling or reassigning related teachers and courses.
            var depID = 1;
            var teachersToDelete = context.Teachers.Where(teacher => teacher.DepartmentId == depID).ToList();
            foreach(var teacher in teachersToDelete)
            {
                var teachercoursesToDelete = context.TeacherCourses.Where(tc => tc.TeacherId == teacher.TeacherId).ToList();
                foreach(var teachercourse in teachercoursesToDelete)
                {
                    context.TeacherCourses.Remove(teachercourse);
                }
                if (teacher != null)
                {
                    context.Teachers.Remove(teacher);
                }
               
            }
            var coursesToDelete = context.Courses.Where(course => course.DepartmentId == depID).ToList();
            foreach (var course in coursesToDelete)
            {
                var teachercoursesToDelete = context.TeacherCourses.Where(tc => tc.CourseId == course.CourseId).ToList();
                foreach (var teachercourse in teachercoursesToDelete)
                {
                    context.TeacherCourses.Remove(teachercourse);
                }
                if (course != null)
                {
                    context.Courses.Remove(course);
                }

            }
             var departmentsToDelete = context.Departments.FirstOrDefault(d => d.DepartmentId == depID);
            if (departmentsToDelete != null)
            {
                context.Departments.Remove(departmentsToDelete);
            }
            context.SaveChanges();
            #endregion
        }
    }
}
