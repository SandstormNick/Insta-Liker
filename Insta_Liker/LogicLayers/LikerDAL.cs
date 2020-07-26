using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Insta_Liker
{
    class LikerDAL
    {
        public int SaveUsername(string username)
        {
            //Save User to the database
            string connectionString = @"Data Source=localhost;Initial Catalog=Liker;Persist Security Info=true; Integrated Security=SSPI;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand command;

            sqlConn.Open();

            command = new SqlCommand("sp_CreateUser", sqlConn);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", username);

            int response = (int)(command.ExecuteScalar());

            command.Dispose();
            sqlConn.Close();

            return response;
        }

        public void SaveHashtags(string hashtag)
        {
            //Save User to the database
            string connectionString = @"Data Source=localhost;Initial Catalog=Liker;Persist Security Info=true; Integrated Security=SSPI;";

            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand command;

            sqlConn.Open();

            command = new SqlCommand("sp_CreateHashtag", sqlConn);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@hashtag", hashtag);

            command.ExecuteNonQuery();
            command.Dispose();
            sqlConn.Close();
        }

        public void SaveUserHashtag(int userId, string hashtag)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=Liker;Persist Security Info=true; Integrated Security=SSPI;";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand command;

            sqlConn.Open();

            command = new SqlCommand("sp_SetUserHashtag", sqlConn);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@hashtag", hashtag);
            command.Parameters.AddWithValue("@isFavourite", 1);

            command.ExecuteNonQuery();
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