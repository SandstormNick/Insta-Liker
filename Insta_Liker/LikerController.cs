using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta_Liker
{
    class LikerController
    {
        LikerBLL bll = new LikerBLL();

        public void SaveUsername(string username)
        {
            bll.SaveUsername(username);
        }

        public string GetUsername()
        {
            return bll.GetUsername();
        }

    }
}
