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
        //temp method
        public void SaveUsername(string username)
        {
            if (username != "")
            {
                dal.SaveUsername(username);
            }
        }

        public string GetUsername()
        {
            return dal.GetUsername();
        }
    }
}
