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
        /// <summary>
        /// 根据lastName获取所有的人员信息列表
        /// </summary>
        /// <param name="lastName">姓</param>
        /// <returns></returns>
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
        /// <summary>
        /// 往数据库表people中插入一条记录
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAdress"></param>

        public void InsertPerson(string firstName, string lastName, string emailAddress)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.ConnectVal("SampleDB")))
            {
                //string insertSql = $"INSERT INTO `people`(FirstName, LastName, emailAddress) VALUES ('{firstName}', '{lastName}', '{emailAdress}');";
                //connection.Execute(insertSql);

                Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress };
                string insertSql = "INSERT INTO `people`(FirstName, LastName, emailAddress) VALUES (@FirstName, @LastName, @EmailAddress);";
                connection.Execute(insertSql, newPerson);
            }
        }
    }
}
