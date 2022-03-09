using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class DataService
    {
        private static readonly string _dbPath = ".\\Test2DB.db";
        private static readonly string _connectionString = $"Data Source={_dbPath};Version=3;";
        public DataService()
        {
            if (! File.Exists(_dbPath))
            {
                CreateTable();
            }
            //File.Create(_dbName);
        }

        private void CreateTable()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = @"create table csv_import (Id int primary key not null,
                                Name text not null,
                                Surname text not null,
                                Initials text not null,
                                Age int not null,
                                DateOfBirth text not null)";

                connection.Execute(query);
            }
        }
        //Id, Name, Surname, Initials, Age, DateOfBirth
        public void SaveUsers(List<User> users)
        {
            ClearTable();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                var insertQuery = @$"insert into csv_import(Id, Name, Surname, Initials, Age, DateOfBirth) values";

                foreach (var user in users)
                {
                    insertQuery += $" ({user.Id}, '{user.Name}', '{user.Surname}', '{user.Initials}', {user.Age}, '{user.DateOfBirth.ToString("dd/MM/yyyy")}'),";
                }

                // remove the comma at the end of the query, as there are no more values to be inserted
                insertQuery = insertQuery.Remove(insertQuery.Length - 1);

                connection.Execute(insertQuery);
            }
         }

        private void ClearTable()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = "delete from csv_import";

                connection.Execute(query);
            }
        }

        //public int GetNextUsableId()
        //{
        //    using (var connection = new SQLiteConnection(_connectionString))
        //    {
        //        return connection.QuerySingle<int>("select max(id) from csv_import");
        //    }
        //}

        public List<User> GetUsersAsList()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var query = "select id, name, surname, initials, age from csv_import";

                return connection.Query<User>(query).ToList();
            }
        }


    }
}
