using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta_Liker.Models
{
    public class User
    {
        private string Username { get; set; }
        private List<string> FavouriteHashtags { get; set; }

        public void SetUsername(string inputUsername)
        {
            Username = inputUsername;
        }

        public string GetUsername()
        {
            return Username;
        }
    }
}
