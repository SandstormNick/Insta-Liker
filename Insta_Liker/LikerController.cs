using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insta_Liker.Models;

namespace Insta_Liker
{
    class LikerController
    {
        LikerBLL bll = new LikerBLL();
        User user;

        public LikerController()
        {
            user = new User();
        }

        public int SaveUser(string username, List<string> addHashtag)
        {
            int userId;
            //handle empty username field. Dont do this in bll.
            //display popup message if save successful or not
            SetUsername(username);

            if (username != "" && username != null)
            {
                userId = bll.SaveUsername(user.GetUsername());

                if (userId > -1)
                {
                    for (int i = 0; i < addHashtag.Count(); i++)
                    {
                        bll.SaveHashtags(addHashtag[i]);
                        bll.SaveUserHashtag(userId, addHashtag[i], 1);
                    }
                }
                return userId;
            }
            else
            {
                return -2;
            }
        }

        private void SetUsername(string usernameInput)
        {
            user.SetUsername(usernameInput);
        }

        public List<string> GetUsernames()
        {
            return bll.GetUsernames();
        }

        public List<string> GetFavouriteHashtagsForUser(string selectedUsername)
        {
            return bll.GetFavouriteHashtagsForUser(selectedUsername);
        }

        public int RunLikerBot(string username, string password, List<string> hashtags, int numOfLikes)
        {
            SaveNewHashtags(username, hashtags);
            user.InitializeHashtags(hashtags);
            int runPassed = 1;
            Selenium selenium = new Selenium(username, password, hashtags, numOfLikes);

            runPassed = selenium.Run(user);

            for (int i = 0; i < user.GetHashtagCount(); i++)
            {
                if (user.GetHashtagLikes(i) != 0)
                {
                    bll.UpdateUserHashtagLikeCount(username, user.GetHashtag(i), user.GetHashtagLikes(i));
                }
            }

            if (runPassed == 1)
            {
                UpdateRunCount(username);
            }

            return runPassed;
        }

        public void UpdateRunCount(string username)
        {
            bll.UpdateRunCount(username);
        }

        private void SaveNewHashtags(string username, List<string> hashtags)
        {
            int userId = bll.GetUserId(username);
            for (int i = 0; i < hashtags.Count(); i++)
            {
                hashtags[i] = hashtags[i].Trim(new Char[] { '#' });
                bll.SaveHashtags(hashtags[i]);
                bll.SaveUserHashtag(userId, hashtags[i], 0);
            }
        }

        public void SetUser(string username)
        {
            user.SetUserId(bll.GetUserId(username));
            user.SetUsername(username);
            user.LastRunDate = bll.GetLastRunDate(username);
            user.RunCount = bll.GetRunCount(username);
            user.DateCreated = bll.GetDateCreated(username);
            //call stored procedures
            //set the user properties
        }

        public string GetLastRunDate()
        {
            return user.LastRunDate.ToString();
        }

        public string GetDateCreated()
        {
            return user.DateCreated;
        }

        public int GetUserRunCount()
        {
            return user.RunCount;
        }

    }
}
