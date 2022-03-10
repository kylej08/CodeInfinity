using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class CSVHelper
    {
        //private readonly string _filePath;

        private readonly RandomUserGenerator _randomUserGenerator;

        public event EventHandler UserGenerated;
        public event EventHandler UserCreatedForImport;

        public string FilePath { get; set; }

        public int TotalUsersForImport { get; set; }

        public CSVHelper()
        {
            _randomUserGenerator = new RandomUserGenerator();

            _randomUserGenerator.UserGenerated += OnUserGeneratedEvent;
        }

        public void CreateCSVAsync(int variations)
        {
            var users = _randomUserGenerator.CreateUserList(variations);

            File.WriteAllLines(FilePath, GenerateCSVListFromUserList(users));
        }

        private List<string> GenerateCSVListFromUserList(LinkedList<User> users)
        {
            var csvUserList = new List<string>();
            csvUserList.Add("Id,Name,Surname,Initials,Age,DateOfBirth");

            foreach (var user in users)
            {
                csvUserList.Add($"\"{user.Id}\",\"{user.Name}\",\"{user.Surname}\",\"{user.Initials}\",\"{user.Age}\",\"{user.DateOfBirth.ToString("dd/MM/yyyy")}\"");
            }

            return csvUserList;
        }

        public List<User> CreateUserListFromCSV(string filePath)
        {
            var userList = new List<User>();

            var lines = File.ReadAllLines(filePath);

            TotalUsersForImport = lines.Length - 1;
            // start from index 1 to ignore header
            for (int i = 1; i< lines.Length; i++)
            {
                var line = lines[i].Replace("\"", "").Split(",");

                userList.Add(CreateUserFromCSVRecord(line));

                UserCreatedForImport.Invoke(this, new EventArgs());
            }
            TotalUsersForImport = 0;
            return userList;
        }

        private User CreateUserFromCSVRecord(string[] record)
        {
            var dateOfBirth = record[5].Split("/");
            var dateOfBirthDay = int.Parse(dateOfBirth[0]);
            var dateOfBirthMonth = int.Parse(dateOfBirth[1]);
            var dateOfBirthYear = int.Parse(dateOfBirth[2]);

            return new User
            {
                Id = int.Parse(record[0]),
                Name = record[1],
                Surname = record[2],
                Age = int.Parse(record[4]),
                DateOfBirth = new DateTime(dateOfBirthYear, dateOfBirthMonth, dateOfBirthDay)
            };
        }

        private void OnUserGeneratedEvent(object sender, EventArgs e)
        {
            UserGenerated.Invoke(sender, e); 
        }
    }


}
