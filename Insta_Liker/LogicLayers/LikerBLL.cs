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

            //if (username != "" && username != null)
            //{
            //    response = dal.SaveUsername(username);
            //}
            return response;
        }

        public void SaveHashtags(string hashtag)
        {
            dal.SaveHashtags(hashtag);
        }

        public void SaveUserHashtag(int userId, string hashtag)
        {
            dal.SaveUserHashtag(userId, hashtag);
        }

        public List<string> GetUsernames()
        {
            return dal.GetUsernames();
        }

        public List<string> GetFavouriteHashtagsForUser(string selectedUsername)
        {
            return dal.GetFavouriteHashtagsForUser(selectedUsername);
        }
    }
}
