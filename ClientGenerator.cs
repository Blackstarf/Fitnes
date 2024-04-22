using Fitnes;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Xml.Linq;

namespace Fitnes
{
    public class DataGenerator
    {
        private string path = @"C:\Users\lalka\source\repos\Fit\bin\Debug\net6.0-windows\Resource\Viking.db";

        private List<string> ReadLinesFromFile(string fileName)
        {
            var lines = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading from file {fileName}: {ex.Message}");
            }
            return lines;
        }

        public void GenerateRandomData()
        {
            var surnames = ReadLinesFromFile("C:\\Users\\lalka\\source\\repos\\Fit\\bin\\Debug\\net6.0-windows\\familii.txt");
            var maleNames = ReadLinesFromFile("C:\\Users\\lalka\\source\\repos\\Fit\\bin\\Debug\\net6.0-windows\\imena_muzhskie.txt");
            var femaleNames = ReadLinesFromFile("C:\\Users\\lalka\\source\\repos\\Fit\\bin\\Debug\\net6.0-windows\\imena_zhenskie.txt");
            var malePatronymics = ReadLinesFromFile("C:\\Users\\lalka\\source\\repos\\Fit\\bin\\Debug\\net6.0-windows\\Otchestva_muzhskie.txt");
            var femalePatronymics = ReadLinesFromFile("C:\\Users\\lalka\\source\\repos\\Fit\\bin\\Debug\\net6.0-windows\\Otchestva_zhenskie.txt");

            Random random = new Random();

            string surname = surnames[random.Next(surnames.Count)];
            string firstName = random.Next(2) == 0 ? maleNames[random.Next(maleNames.Count)] : femaleNames[random.Next(femaleNames.Count)];
            string patronymic = random.Next(2) == 0 ? malePatronymics[random.Next(malePatronymics.Count)] : femalePatronymics[random.Next(femalePatronymics.Count)];

            string[] statuses = { "клиент", "бизнес-клиент", "вип-клиент" };
            int randomNumber = random.Next(0, 3);

            int randomDay = random.Next(1, 365);
            string phoneNumber = "+7" + random.Next(100000000, 999999999).ToString();

            string birthDate = random.Next(1950, 2003) + "-" + random.Next(1, 13) + "-" + random.Next(1, 29);

            try
            {
                using (var connection = new SqliteConnection($"Data Source={path};Cache=Default;Mode=ReadWrite;"))
                {
                    connection.Open();
                    string sqlExpression = "INSERT INTO clients (FirstName, Name, Otchestvo, Data, Number, Age,Status,Subscription,ID,DateReg) " +
                        "VALUES (@FirstName, @Name, @Otchestvo, @Data, @Number, @Age,@Status, @Subscription, @ID,@DateReg)";

                    using (SqliteCommand command = new SqliteCommand(sqlExpression, connection))
                    {
                        int age = DateTime.Today.Year - Convert.ToDateTime(birthDate).Year;
                        command.Parameters.AddWithValue("@Name", firstName);
                        command.Parameters.AddWithValue("@FirstName", surname);
                        command.Parameters.AddWithValue("@Otchestvo", patronymic);
                        command.Parameters.AddWithValue("@Data", birthDate);
                        command.Parameters.AddWithValue("@Number", phoneNumber);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Status", statuses[randomNumber]);
                        command.Parameters.AddWithValue("@Subscription", randomDay);
                        command.Parameters.AddWithValue("@ID", Guid.NewGuid());
                        command.Parameters.AddWithValue("@DateReg", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while inserting data into database: {ex.Message}");
            }
        }
    }
}