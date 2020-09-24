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
        private List<string> Hashtags { get; set; }
        private List<int> HashtagLikes { get; set; }

        public DateTime LastRunDate { get; set; }
        public string DateCreated { get; set; }
        public int RunCount { get; set; }

        public void SetUserId(int userId)
        {
            UserId = userId;
        }

        #region Username methods
        public void SetUsername(string username)
        {
            Username = username;
        }

        public string GetUsername()
        {
            return Username;
        }
        #endregion

        #region Hashtags
        private void SetHashtags(List<string> hashtags)
        {
            Hashtags = hashtags;
        }

        private void InitialiseHashtagLikes()
        {
            HashtagLikes = new List<int>();
            for (int i = 0; i < Hashtags.Count(); i++)
            {
                HashtagLikes.Add(0);
            }
        }

        public void InitializeHashtags(List<string> hashtags)
        {
            SetHashtags(hashtags);
            InitialiseHashtagLikes();
        }

        public void UpdateHashtagLikes(int hashtagIndex, int numOfLikes)
        {
            HashtagLikes[hashtagIndex] = numOfLikes; 
        }

        public int GetHashtagCount()
        {
            return Hashtags.Count;
        }

        public int GetHashtagLikes(int index)
        {
            return HashtagLikes[index];
        }

        public string GetHashtag(int index)
        {
            string hashtag = Hashtags[index];

            return hashtag.Trim(new Char[] { '#' });
            
        }
        #endregion
    }
}
