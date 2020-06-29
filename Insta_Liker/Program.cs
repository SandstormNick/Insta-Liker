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
    //Needs to login
    //Take up to 5 #'s
    //Run the Selenium bit
    //-> logins in
    //-> goes through each # entered and likes the first photos on the "most recent" tab for the #

    //To Do:
    //
    //1) Install Selenium chromedriver
    //
    //

    //To Do Later:
    //Refactor Designer.cs





}
