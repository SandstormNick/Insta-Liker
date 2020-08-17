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

    //Iteration 3
    //-->Record likes per hashtag in the UserHashtag table (2)
    //-->Create Hashtag when user just types it into one of the textboxes. They don't only have
    //   to be created when the user is saved. (2.1)
    //   could do this by returning the list of hashtags linked to a user. If any hashtags in the textboxes when LikerBot is 
    //   run then they must be added into the hashtag table and the mapping must be added to UserHashtag table
    //-->Display data on the User tab (3)
    //----> Need to add a new panel for displaying info.
    //

    //To Do In next commits:
    //--> (2.1)
    //

    //To Do Later:
    //Refactor Designer.cs
    //split up the Selenium class (this can be part of the refactoring)
    //sort out a careful algorithm to make the speed of likes look natural
    //end selenium after its done executing
    //add try catches in cases of elements not loading fast enough





}
