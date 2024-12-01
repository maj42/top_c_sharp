using System;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace homework_1_27._11__ADO.NET_
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; " +
                                      "Database=Library; " +
                                      "Trusted_Connection=True";

            string createDB = @"CREATE DATABASE Library";

            string createTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Books')
                    BEGIN
                        CREATE TABLE Books (
                            AuthorID int PRIMARY KEY,
                            Title nvarchar(50),
                            Price int,
                            Pages int
                        )
                    END";

            string insertDataQuery = @"
                    INSERT INTO Books (AuthorID, Title, Price, Pages)
                    VALUES
                        (1, 'Plague', 7, 560),
                        (2, 'Process', 8, 450),
                        (3, 'Dolls', 5, 237)";

            string calculatePricesAndPages = @"
                    SELECT SUM(Price) AS TotalPrice, SUM(Pages) AS TotalPages
                    FROM Books;
                    ";

            //await ExecuteQuery(insertDataQuery, connectionString);
            await ExecuteReader(calculatePricesAndPages, connectionString);
        }

        static async Task ExecuteQuery(string query, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    Console.WriteLine("Connected to the DB.");

                    SqlCommand cmd = new SqlCommand(query, conn);
                    await cmd.ExecuteNonQueryAsync();
                    Console.WriteLine("Query successful.");
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static async Task ExecuteReader(string query, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    Console.WriteLine("Connected to the DB.\n");

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        Console.WriteLine();
                        while (await reader.ReadAsync())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader.GetValue(i) + "\t\t");
                            }
                            Console.WriteLine();
                        }
                    }
                    await reader.CloseAsync();
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine($"SQL Error: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}