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
    //-->Get Hashtags for User based on selected Username (3)
    //

    //To Do In next commits:
    //--> (3)
    //

    //To Do Later:
    //Refactor Designer.cs
    //split up the Selenium class (this can be part of the refactoring)
    //sort out a careful algorithm to make the speed of likes look natural
    //add try catches in cases of elements not loading fast enough





}
