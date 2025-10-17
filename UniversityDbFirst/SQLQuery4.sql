use UniversityDB

DELETE FROM Student
Delete from Department;
Delete  FROM [UniversityDB].[dbo].[Teacher]

DBCC CHECKIDENT ('Student', RESEED, 0);
DBCC CHECKIDENT ('Teacher', RESEED, 0);
DBCC CHECKIDENT ('Department', RESEED, 0);