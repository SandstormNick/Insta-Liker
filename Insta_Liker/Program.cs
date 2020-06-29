using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta_Liker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Liker());
        }
    }

    //Iteration 1
    //
    //Don't need to get DB involved for this iteration
    //
    //Needs to login (DONE)
    //Take up to 5 #'s (DONE)
    //Run the Selenium bit (IN PROGRESS)
    //-> logins in (DONE)
    //-> goes through each # entered and likes the first photos on the 
    //   "most recent" tab for the # (IN PROGRESS)

    //To Do:
    //
    //1) Navigate to search
    //2) enter #'s and then like the photos based on the NumOfLikes value
    //3) loops through this based on the num of #'s entered
    //

    //To Do Later:
    //Refactor Designer.cs
    //proper validation on form
    //split up the Selenium class (this can be part of the refactoring)





}
