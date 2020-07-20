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

        public void SaveUser(string username)
        {
            SetUsername(username);

            bll.SaveUser(user.GetUsername());
        }

        private void SetUsername(string usernameInput)
        {
            user.SetUsername(usernameInput);
        }

        public string GetUsername()
        {
            return bll.GetUsername();
        }

    }
}
