﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Insta_Liker
{
    class LikerDAL
    {
        
        //temp method
        public void SaveUsername(string username)
        {
            //Save to the database
            //string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LikerEntities"].ConnectionString;
            string connectionString = @"Data Source=localhost;Initial Catalog=Liker;Persist Security Info=true; Integrated Security=SSPI;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlInsert = "INSERT INTO [dbo].[User] (Username) VALUES ('" + username + "')";

            sqlConn.Open();

            command = new SqlCommand(sqlInsert, sqlConn);

            adapter.InsertCommand = new SqlCommand(sqlInsert, sqlConn);
            adapter.InsertCommand.ExecuteNonQuery();


            command.Dispose();
            sqlConn.Close();
            
        }

        public string GetUsername()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=Liker;Persist Security Info=true; Integrated Security=SSPI;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlGet = "SELECT Username FROM [dbo].[User] WHERE UserId = 1";

            sqlConn.Open();
            command = new SqlCommand(sqlGet, sqlConn);

            string username = (string)(command.ExecuteScalar());

            command.Dispose();
            sqlConn.Close();

            return username;
        }
    }
}