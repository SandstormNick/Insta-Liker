using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta_Liker
{
    class LikerBLL
    {
        LikerDAL dal = new LikerDAL();
        
        public int SaveUsername(string username)
        {
            int response = dal.SaveUsername(username);

            return response;
        }

        private int CheckUserHashtagExists(int userId, string hashtag)
        {
            int hashtagExists = dal.CheckUserHashtagExists(userId, hashtag);
            return hashtagExists;
        }

        public void SaveHashtags(string hashtag)
        {
            dal.SaveHashtags(hashtag);
        }

        public void SaveUserHashtag(int userId, string hashtag, int isFav)
        {
            if (CheckUserHashtagExists(userId, hashtag) == 0)
            {
                dal.SaveUserHashtag(userId, hashtag, isFav);
            }
        }

        public List<string> GetUsernames()
        {
            return dal.GetUsernames();
        }

        public List<string> GetFavouriteHashtagsForUser(string selectedUsername)
        {
            return dal.GetFavouriteHashtagsForUser(selectedUsername);
        }

        public void UpdateRunCount(string username)
        {
            dal.UpdateRunCount(username);
        }

        public void UpdateUserHashtagLikeCount(string username, string hashtag, int likeCount)
        {
            dal.UpdateUserHashtagLikeCount(username, hashtag, likeCount);
        }

        public int GetUserId(string username)
        {
            return dal.GetUserId(username);
        }
    }
}
