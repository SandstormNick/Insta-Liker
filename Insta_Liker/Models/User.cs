using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta_Liker.Models
{
    public class User
    {
        private int UserId { get; set; }
        private string Username { get; set; }
        private List<string> FavouriteHashtags { get; set; }

        public void SetUserId(int userId)
        {
            UserId = userId;
        }

        public void SetUsername(string username)
        {
            Username = username;
        }

        public string GetUsername()
        {
            return Username;
        }
    }
}
