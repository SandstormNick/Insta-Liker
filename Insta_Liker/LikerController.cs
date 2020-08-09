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
            int response;
            //handle empty username field. Dont do this in bll.
            //display popup message if save successful or not
            SetUsername(username);

            if (username != "" && username != null)
            {
                response = bll.SaveUsername(user.GetUsername());

                if (response > -1)
                {
                    for (int i = 0; i < addHashtag.Count(); i++)
                    {
                        bll.SaveHashtags(addHashtag[i]);
                        bll.SaveUserHashtag(response, addHashtag[i]);
                    }
                }
                return response;
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

        private void SetUserId(int userId)
        {

        }

        public List<string> GetUsernames()
        {
            return bll.GetUsernames();
        }

    }
}
