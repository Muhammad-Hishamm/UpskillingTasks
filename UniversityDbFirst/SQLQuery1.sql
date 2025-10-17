-- Create the database
-- DROP DATABASE UniversityDB;
CREATE DATABASE UniversityDB;
GO

-- Use the database
USE UniversityDB;
GO

-- Create Department table
CREATE TABLE Department (
    DepartmentId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    OfficeLocation NVARCHAR(100)
);
GO

-- Create Teacher table
CREATE TABLE Teacher (
    TeacherId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    HireDate DATETIME,
    DepartmentId INT FOREIGN KEY REFERENCES Department(DepartmentId)
);
GO

-- Create Course table
CREATE TABLE Course (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    Credits INT,
    DepartmentId INT FOREIGN KEY REFERENCES Department(DepartmentId)
);
GO

-- Create Student table
CREATE TABLE Student (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    EnrollmentDate DATETIME
);
GO

-- Create Enrollment table (junction between Student and Course)
CREATE TABLE Enrollment (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    CourseId INT FOREIGN KEY REFERENCES Course(CourseId),
    StudentId INT FOREIGN KEY REFERENCES Student(StudentId),
    EnrollmentDate DATETIME DEFAULT GETDATE(),
    Grade INT NULL
);
GO

-- Create TeacherCourse table (junction between Teacher and Course)
CREATE TABLE TeacherCourse (
    TeacherCourseId INT PRIMARY KEY IDENTITY(1,1),
    TeacherId INT FOREIGN KEY REFERENCES Teacher(TeacherId),
    CourseId INT FOREIGN KEY REFERENCES Course(CourseId)
);
GO