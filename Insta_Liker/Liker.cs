using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Insta_Liker
{
    public partial class Liker : Form
    {
        #region Properties
        private string UserName { get; set; }
        private string Password { get; set; }
        private int NumOfLikes { get; set; }

        List<TextBox> HashtagTextBox = new List<TextBox>();
        List<string> Hashtag = new List<string>();
        #endregion

        public Liker()
        {
            InitializeComponent();

            HashtagTextBox.Add(hashtag1TextBox);
            HashtagTextBox.Add(hashtag2TextBox);
            HashtagTextBox.Add(hashtag3TextBox);
            HashtagTextBox.Add(hashtag4TextBox);
            HashtagTextBox.Add(hashtag5TextBox);
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            UserName = usernameTextBox.Text;
            Password = passwordTextBox.Text;

            for (int i = 0; i < HashtagTextBox.Count(); i++)
            {
                Hashtag.Add(HashtagTextBox[i].Text);
            }

            NumOfLikes = int.Parse(numLikesTextBox.Text);

            RunLiker();
        }

        private void RunLiker()
        {
            Selenium theSelenium = new Selenium(UserName, Password);
            theSelenium.Run();
        }
    }
}
