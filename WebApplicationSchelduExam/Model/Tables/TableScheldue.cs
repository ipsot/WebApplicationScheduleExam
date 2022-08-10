using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationSchelduExam.Model.Entities;
using MySql.Data.MySqlClient;
using WebApplicationSchelduExam.Model.Entities.Tools;
namespace WebApplicationSchelduExam.Model.Tables
{
    public class TableScheldue
    {
        public List<Scheldue> GetAllScheldues()
        {
            List<Scheldue> scheldues = new List<Scheldue>();
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            mySqlCommand.CommandText = "SELECT * FROM `scheduleexam`";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read()==true)
            {
                scheldues.Add(new Scheldue()
                {
                    Id = reader.GetInt32("id"),
                    Subject = reader.GetString("subject"),
                    Date = reader.GetString("date"),
                    Mark = reader.GetInt32("mark"),
                }); ;
                reader.Close();
            }
            return scheldues;
        }
        public bool InsertNewScheldue(Scheldue scheldue)
        {
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            mySqlCommand.CommandText = $"INSERT INTO `scheduleexam`(`subject`,`date`,`mark`) VALUES('{scheldue.Subject}','{scheldue.Date}','{scheldue.Mark}')";
            mySqlCommand.ExecuteNonQuery();
            return true;
        }
        public bool DeleteScheldueById(int id)
        {
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            mySqlCommand.CommandText = $"DELETE FROM `scheduleexam`WHERE `id`={id}";
            mySqlCommand.ExecuteNonQuery();
            return true;
        }
    }
}