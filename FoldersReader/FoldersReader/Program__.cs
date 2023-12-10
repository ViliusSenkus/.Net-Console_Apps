using System;
using System.IO;
using System.Data;
using Npgsql;
using Dapper;

namespace FoldersReader
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Prašome pateikti direktorijos pavadinimą
            Console.Write("Enter directory name to scan: ");
            string path = Console.ReadLine();

            //Paruošiam duomenų bazę
            EnsureDatabaseSchema();

            //tikriname ar tokia direktorija egzistuoja
            if (Directory.Exists(path))
            {
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }

            static void EnsureDatabaseSchema()
            {
                using (var connection = new NpgsqlConnection("Host=localhost;Username=your_username;Password=your_password;Database=your_database"))
                {
                    connection.Open();

                    // Patikriname, ar "FilesReader" schema egzistuoja
                    var schemaExists = connection.ExecuteScalar<bool>("SELECT EXISTS(SELECT 1 FROM information_schema.schemata WHERE schema_name = 'FilesReader')");

                    if (!schemaExists)
                    {
                        // Sukuriame "FilesReader" schema
                        connection.Execute("CREATE SCHEMA FilesReader");
                    }

                    // Patikriname, ar "files" lentelė egzistuoja
                    var tableExists = connection.ExecuteScalar<bool>("SELECT EXISTS(SELECT 1 FROM information_schema.tables WHERE table_schema = 'FilesReader' AND table_name = 'files')");

                    if (!tableExists)
                    {
                        // Sukuriame "files" lentelę
                        connection.Execute("CREATE TABLE FilesReader.files (id serial PRIMARY KEY, name VARCHAR(255), full_directory VARCHAR(255), file_size bigint)");
                    }
                }
            }

                //failų nuskaitymo metodas
                static void ProcessDirectory(string dir)
            {
                string[] files = Directory.GetFiles(dir);

                using (var connection = new NpgsqlConnection("Host=localhost;Username=your_username;Password=your_password;Database=your_database"))
                {
                    connection.Open();

                    foreach (string fileName in files)
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        InsertFileData(connection, fileInfo.Name, fileInfo.FullName, fileInfo.Length);
                    }
                }
                Console.WriteLine("Scan Successfull, data inserted into the 'files' table.");
            }

            static void InsertFileData(NpgsqlConnection connection, string name, string fullDirectory, long fileSize)
            {
                connection.Execute("INSERT INTO files (name, full_directory, file_size) VALUES (@name, @fullDirectory, @fileSize)",
                    new { name, fullDirectory, fileSize }, commandType: CommandType.Text);
            }








            List<string> fullFilesData = new List<string>();

            foreach (FileInfo file in filesData)
            {
                string fileName = Path.GetFileName(file.FullName);
                long fileSize = file.Length;
                string filePath = Path.GetFullPath(file.FullName);

                fullFilesData.Add("Name: " + fileName + 
                                    ", Size: " + fileSize + 
                                    ", Path: " + filePath);
            }

            //atsivaizduoju failu sarasa
            foreach (string file in fullFilesData)
            {
                Console.WriteLine(file);
            }


            //skanuoju ar yra subfolderiu:


            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                Console.WriteLine(directory);
            }



            /*


            string[] filesList = Directory.GetFiles(path);
            List<string> filesInfo = new List<string>();


            List<string> getFileInfo(string[] filesList) {
                List<string> result;
                    foreach (string file in filesList)
                {
                     result.Add(FileInfo(file));
                }
                return result;
                    }
            */


            /*
             cia reikia tikrinti ar jau yra db ir jeigu nera ja sukuri:
            - prisijungiam prie Postgres,
            - tikrinam ar yra duomenu baze
            - sukuriam baze
            */

            // Specify the name of the PostgreSQL database
            string dbName = "folder_data";


            //cia kuriame lenteles
            // Specify the name of the table where data will be inserted
            string tableName = "files";

            /*
            // Create a connection object
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost:3306;Username=user;Password=password;Database=" + dbName))
            {
                // Open a connection to DB
                conn.Open();

                // Create a command object with an insert statement
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO " + tableName + " (id, name, size) VALUES (@id, @name, @size)", conn))
                {
                    // Add parameters with values from arguments
                    cmd.Parameters.AddWithValue("@id", 1);
                    cmd.Parameters.AddWithValue("@name", "test.txt");
                    cmd.Parameters.AddWithValue("@size", 1024);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }

                // Close connections to DB
                conn.Close();
            }
            

            Console.WriteLine("Scan completed.");
            
            */
        }
    }
}


