using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Task8
{
    internal class Program
    {
        public static void Get(string sqlQuery, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"Emp ID: {sqlDataReader["ID"]}, Name: {sqlDataReader["Name"]}, Department: {sqlDataReader["Department"]}");
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

        public static void Operation(string sqlQuery, SqlConnection sqlConnection, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            foreach (var param in parameters)
            {
                sqlCommand.Parameters.AddWithValue(param.Key, param.Value);
            }

            try
            {
                sqlConnection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) affected.");
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

        public static void Add(SqlConnection sqlConnection)
        {
            string sqlQuery = "INSERT INTO Employees (Name, Age, Department) VALUES (@Name, @Age, @Department)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", "Ahmed Hassan" },
                { "@Age", 30 },
                { "@Department", "Engineering" }
            };
            Operation(sqlQuery, sqlConnection, parameters);
        }

        public static void Update(SqlConnection sqlConnection)
        {
            string sqlQuery = "UPDATE Employees SET Department = @Department WHERE Age = @Age";
            var parameters = new Dictionary<string, object>
            {
                { "@Department", "Marketing" },
                { "@Age", 30 }
            };
            Operation(sqlQuery, sqlConnection, parameters);
        }

        public static void Delete(SqlConnection sqlConnection)
        {
            string sqlQuery = "DELETE FROM Employees WHERE Department = @Department";
            var parameters = new Dictionary<string, object>
            {
                { "@Department", "Engineering" }
            };
            Operation(sqlQuery, sqlConnection, parameters);
        }

        static void Main(string[] args)
        {
            var connectionString = "Data Source=MUHAMMAD-HISHAM\\SQLEXPRESS;Initial Catalog=UniversityDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            Add(sqlConnection);
            Update(sqlConnection);
            Delete(sqlConnection);

            string selectQuery = "SELECT * FROM Employees";
            Get(selectQuery, sqlConnection);
        }
    }
}