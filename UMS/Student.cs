using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    internal class Student
    {
        UMS_DB db = new UMS_DB();


        public bool insertStudent(string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `idstudent`(`id`, `first_name`, `last_name`, `birthdate`, `gender`, `phone`, `address`, `picture`) VALUES (@fn,@ln,@bd,@gr,@ph,@ad,@pic ) ", db.getConnection);
            
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@ad", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.VarChar).Value = picture.ToArray();

            db.openConnection();

            if(command.ExecuteNonQuery() == 1) 
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection( );  
                return false;
            }
           
        }
    }
}
