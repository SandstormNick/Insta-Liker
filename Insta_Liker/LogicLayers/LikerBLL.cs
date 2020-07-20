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
        
        public void SaveUser(string username)
        {
            if (username != "" && username != null)
            {
                dal.SaveUser(username);
            }
        }

        public string GetUsername()
        {
            return dal.GetUsername();
        }
    }
}
