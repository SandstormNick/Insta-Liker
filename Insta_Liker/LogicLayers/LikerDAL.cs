using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Insta_Liker.Models;

namespace Insta_Liker
{
    class LikerDAL
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["LikerDB"].ConnectionString;

        public int SaveUsername(string username)
        {
            //Save User to the database
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

        public int CheckUserHashtagExists(int userId, string hashtag)
        {
            int hashtagExists = 0;

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_CheckUserHashtagExists", sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@userId", userId);
                sqlCommand.Parameters.AddWithValue("@hashtag", hashtag);

                hashtagExists = (int)sqlCommand.ExecuteScalar();

                sqlCommand.Dispose();
            }

            return hashtagExists;
        }

        public int GetUserId(string username)
        {
            int userId;
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_GetUserId", sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@username", username);

                userId = (int)sqlCommand.ExecuteScalar();

                sqlCommand.Dispose();
            }
            return userId;
        }

        public void SaveHashtags(string hashtag)
        {
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

        public void SaveUserHashtag(int userId, string hashtag, int isFavourite)
        {
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand command;

            sqlConn.Open();

            command = new SqlCommand("sp_SetUserHashtag", sqlConn);

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@hashtag", hashtag);
            command.Parameters.AddWithValue("@isFavourite", isFavourite);

            command.ExecuteNonQuery();
            command.Dispose();
            sqlConn.Close();
        }

        public List<string> GetUsernames()
        {
            List<string> usernames = new List<string>();
            DataTable dt = new DataTable("UsernameTable");

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_GetUsernames", sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                
                dt.Load(sqlDataReader);
            }

            foreach (DataRow dr in dt.Rows)
            {
                usernames.Add((string)dr["Username"]);
            }

            return usernames;
        }

        public List<string> GetFavouriteHashtagsForUser(string selectedUsername)
        {
            List<string> favHashtags = new List<string>();
            DataTable dt = new DataTable("Hashtags");

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_GetFavouriteHashtagsForUser", sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@username", selectedUsername);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                dt.Load(sqlDataReader);
            }

            foreach (DataRow dr in dt.Rows)
            {
                favHashtags.Add((string)dr["HashtagString"]);
            }

            return favHashtags;
        }

        public void UpdateRunCount(string username)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_UpdateUserRunCount", sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@username", username);

                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }

        public void UpdateUserHashtagLikeCount(string username, string hashtag, int likeCount)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand("sp_UpdateUserHashtagLikeCount", sqlConn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@hashtag", hashtag);
                sqlCommand.Parameters.AddWithValue("@likeCount", likeCount);

                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
        }
    }
}