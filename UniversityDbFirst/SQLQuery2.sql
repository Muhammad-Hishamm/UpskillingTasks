USE master;
GO
ALTER DATABASE UniversityDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE UniversityDB;

SELECT 
    session_id,
    login_name,
    host_name,
    program_name,
    status,
    database_id,
    DB_NAME(database_id) AS database_name
FROM sys.dm_exec_sessions
WHERE DB_NAME(database_id) = 'UniversityDB';
