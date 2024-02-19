using System;
using Microsoft.Data.Sqlite;


namespace habit_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=habit-Tracker.db";
            
            using (var connection = new SqliteConnection(connectionString)){
                connection.Open();  

                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText = 
                    @"CREATE TABLE IF NOT EXISTS making_money (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Date Text,
                        Quantity Integer
                        )";

                tableCmd.ExecuteNonQuery();
                connection.Close();
            }

            static void GetUserInput()
            {
                Console.Clear();
                bool closeApp = false;
                while (closeApp = false)
                {
                    Console.WriteLine("\n\nMAIN MENU");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("\nType 0 to close the application.");
                    Console.WriteLine("\nType 1 to View All Records");
                    Console.WriteLine("\nType 2 to Insert Record.");
                    Console.WriteLine("\nType 3 to Delete Record.");
                    Console.WriteLine("\nType 4 to Update Record.");
                    Console.WriteLine("-----------------------------------------\n");

                    string commandInput = Console.ReadLine();
                   }
            }
        }
}