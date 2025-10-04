using Microsoft.Data.SqlClient;
using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task8
{
    internal class Program
    {
        public static void get(string sqlQuery, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    // int id = (int)sqlDataReader["ID"];
                    Console.WriteLine($"Emp ID: {sqlDataReader["ID"]}, Emp Name: {sqlDataReader["Name"]},Emp Name: {sqlDataReader["Department"]}");
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
        }

        public static void Add(string sqlQuery, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
        }

        public static void update(string sqlQuery, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
        }

        public static void delete (string sqlQuery, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
        }

        static void Main(string[] args)
        {
            var connectionString = "Data Source=MUHAMMAD-HISHAM\\SQLEXPRESS;Initial Catalog=UniversityDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            ////Add
            //string sqlQuery = "INSERT INTO Employees (Name, Age, Department) VALUES (N'Ahmed Hassan', 30, N'Engineering')";
            //Add(sqlQuery, sqlConnection);


            ////update
            //sqlQuery = "UPDATE Employees SET Department = N'Marketing' WHERE Age = 30;";
            //update(sqlQuery, sqlConnection);


            //Delete
            //sqlQuery = "DELETE FROM Employees WHERE Department = 'Engineering'";
            //delete(sqlQuery, sqlConnection);


            //get
            // sqlQuery = "SELECT * FROM Employees";
            //get(sqlQuery, sqlConnection);
        }
    }
}
