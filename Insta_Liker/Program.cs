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
    //Add DB aspect
    //Add try catches for failing tests
    //exit selenium after the Liker is finished
    //

    //To Do:
    //
    //

    //To Do Later:
    //Refactor Designer.cs
    //split up the Selenium class (this can be part of the refactoring)
    //sort out a careful algorithm to make the speed of likes look natural
    //end selenium after its done executing
    //add try catches in cases of elements not loading fast enough

    //Iteration 2
    //
    //Get a basic db going so you could load some of the basic inputs instead of entering them in the whole time





}
