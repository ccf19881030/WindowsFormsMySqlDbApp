using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace WindowsFormsMySqlDbApp
{
    public class MySQLDataAccess
    {
        //public static string connStr = "Server=127.0.0.1;Port=3306;database=ytdemo;user id=root;password=123456;"; 
        public List<Person> GetPersonList(string lastName)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.ConnectVal("SampleDB")))
            {
                //string searchSql = "select * from people where LastName=@LastName";
                //return connection.Query<Person>(searchSql, new { LastName = lastName }).ToList();

                var personList = connection.Query<Person>($"select * from people where LastName = '{lastName}'").ToList();

                return personList;
            }

        }
    }
}
