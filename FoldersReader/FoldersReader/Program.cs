using System;
using System.Data;
using System.IO;
using System.Reflection;
using DbUp;
using Npgsql;
using Dapper;

class Program
{
    static void Main()
    {
        

        Console.Write("Enter directory name to scan: ");
        string path = Console.ReadLine();

        EnsureDatabaseSchema();

        if (Directory.Exists(path))
        {
            ProcessDirectory(path);
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
        }
    }

    static void EnsureDatabaseSchema()
    {
        var connectionString = "Host=localhost;Username=your_username;Password=your_password;Database=your_database";

        var upgrader = DeployChanges.To
            .PostgresqlDatabase(connectionString)
            .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly()) // Arba kitas šaltinis, kuriame yra SQL skriptai
            .LogToConsole()
            .Build();

        var result = upgrader.PerformUpgrade();

        if (!result.Successful)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result.Error);
            Console.ResetColor();
            Environment.Exit(1); // Baigti programą su klaida
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Database schema updated successfully!");
            Console.ResetColor();
        }
    }

    static void ProcessDirectory(string targetDirectory)
    {
        string[] fileEntries = Directory.GetFiles(targetDirectory);

        using (var connection = new NpgsqlConnection("Host=localhost;Username=your_username;Password=your_password;Database=your_database"))
        {
            connection.Open();

            foreach (string fileName in fileEntries)
            {
                FileInfo fileInfo = new FileInfo(fileName);
                InsertFileData(connection, fileInfo.Name, fileInfo.FullName, fileInfo.Length);
            }
        }

        Console.WriteLine("Data inserted into the 'files' table successfully.");
    }

    static void InsertFileData(IDbConnection connection, string name, string fullDirectory, long fileSize)
    {
        connection.Execute("INSERT INTO FilesReader.files (name, full_directory, file_size) VALUES (@name, @fullDirectory, @fileSize)",
            new { name, fullDirectory, fileSize }, commandType: CommandType.Text);
    }
}