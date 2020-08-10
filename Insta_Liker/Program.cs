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
    //-->Record likes per hashtag in the UserHashtag table
    //-->Record number of runs for a user
    //-->Work a little more on making try catches more descriptive
    //-->Display data on the User tab
    //----> Need to add a new panel for displaying info.
    //

    //To Do In next commits:
    //-->Record number of runs for a user
    //

    //To Do Later:
    //Refactor Designer.cs
    //split up the Selenium class (this can be part of the refactoring)
    //sort out a careful algorithm to make the speed of likes look natural
    //end selenium after its done executing
    //add try catches in cases of elements not loading fast enough





}
