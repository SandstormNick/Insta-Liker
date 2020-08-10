using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta_Liker
{
    public partial class Liker : Form
    {
        #region Properties
        private string UserName { get; set; }
        private string Password { get; set; }
        private int NumOfLikes { get; set; }

        private List<TextBox> HashtagTextBox = new List<TextBox>();
        private List<string> Hashtag = new List<string>();

        private List<TextBox> AddHashtagTextBox = new List<TextBox>();
        private List<string> AddHashtag = new List<string>();
        private List<string> Usernames = new List<string>();
        private List<string> UserFavHashtags = new List<string>();

        private bool MinHashtags { get; set; }

        LikerController likerController;
        #endregion

        public Liker()
        {
            InitializeComponent();

            HashtagTextBox.Add(hashtag1TextBox);
            HashtagTextBox.Add(hashtag2TextBox);
            HashtagTextBox.Add(hashtag3TextBox);
            HashtagTextBox.Add(hashtag4TextBox);
            HashtagTextBox.Add(hashtag5TextBox);

            likerController = new LikerController();

            PopulateUsernameComboBox();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            UserName = usernameTextBox.Text;
            Password = passwordTextBox.Text;

            for (int i = 0; i < HashtagTextBox.Count(); i++)
            {
                if (!string.IsNullOrEmpty(HashtagTextBox[i].Text))
                {
                    Hashtag.Add("#" + HashtagTextBox[i].Text);
                }
            }

            if (Hashtag.Count() > 0 && hashtag1TextBox.Text != "")
            {
                MinHashtags = true;
            }
            else
            {
                MinHashtags = false;
                Hashtag.RemoveRange(0, Hashtag.Count());
            }

            NumOfLikes = int.Parse(numLikesTextBox.Text);

            if (UserName != "" && Password != "" && NumOfLikes != 0 && MinHashtags == true)
            {
                RunLiker();
            }
            else
            {
                ShowInputValidation();
            }
        }

        private void ShowInputValidation()
        {
            if (UserName == "")
            {
                usernameTextBox.BackColor = Color.Salmon;
            }
            if (Password == "")
            {
                passwordTextBox.BackColor = Color.Salmon;
            }
            if (!MinHashtags)
            {
                hashtag1TextBox.BackColor = Color.Salmon;
            }
        }

        private void RunLiker()
        {
            DisplayLikerPostRunMessage(likerController.RunLikerBot(UserName, Password, Hashtag, NumOfLikes));
        }

        private void DisplayLikerPostRunMessage(int runPassed)
        {
            //if runPassed = 1 then the Liker Bot completed successfully
            if (runPassed == 1)
            {
                MessageBox.Show("Liker Bot Completed Successfully", "Liker Bot Run", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("An unexpected error occured during the Liker Bot run", "Liker Bot Run", MessageBoxButtons.OK);
            }
        }

        #region Events
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text))
            {
                usernameTextBox.BackColor = Color.White;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordTextBox.BackColor = Color.White;
            }
        }

        private void hashtag1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hashtag1TextBox.Text))
            {
                hashtag2TextBox.ReadOnly = false;
                hashtag1TextBox.BackColor = Color.White;
            }
            else
            {
                hashtag2TextBox.ReadOnly = true;
            }
        }

        private void hashtag2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hashtag2TextBox.Text))
            {
                hashtag3TextBox.ReadOnly = false;
            }
            else
            {
                hashtag3TextBox.ReadOnly = true;
            }
        }

        private void hashtag3TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hashtag3TextBox.Text))
            {
                hashtag4TextBox.ReadOnly = false;
            }
            else
            {
                hashtag4TextBox.ReadOnly = true;
            }
        }

        private void hashtag4TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hashtag4TextBox.Text))
            {
                hashtag5TextBox.ReadOnly = false;
            }
            else
            {
                hashtag5TextBox.ReadOnly = true;
            }
        }

        private void numLikesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numLikesTextBox.Text))
            {
                numLikesTextBox.BackColor = Color.White;
            }
            else
            {
                runButton.Enabled = false;
            }

            int i = 0;
            if (!string.IsNullOrEmpty(numLikesTextBox.Text) && !int.TryParse(numLikesTextBox.Text, out i))
            {
                numLikesTextBox.BackColor = Color.Salmon;
                runButton.Enabled = false;
            }

            if (!string.IsNullOrEmpty(numLikesTextBox.Text) && int.TryParse(numLikesTextBox.Text, out i))
            {
                if (int.Parse(numLikesTextBox.Text) > 100)
                {
                    numLikesTextBox.BackColor = Color.Salmon;
                    max100LikesLabel.Text = "Enter less than 100";
                    runButton.Enabled = false;
                }
                else
                {
                    max100LikesLabel.Text = "(Max of 100)";
                    runButton.Enabled = true;
                }
            }
        }
        #endregion

        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUserPanel.Visible = true;
        }

        private void saveUserInfoButton_Click(object sender, EventArgs e)
        {
            int response;
            SetAddHashtagTextboxes();
            AddUserHashtags();
            response = likerController.SaveUser(addUsernameTextbox.Text, AddHashtag);

            if (response > -1)
            {
                MessageBox.Show("Username Saved", "Status", MessageBoxButtons.OK);
            }
            else if (response == -1)
            {
                MessageBox.Show("Username already exists", "Status", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Enter a Username", "Status", MessageBoxButtons.OK);
            }
        }

        private void SetAddHashtagTextboxes()
        {
            AddHashtagTextBox.Add(addHashtag1);
            AddHashtagTextBox.Add(addHashtag2);
            AddHashtagTextBox.Add(addHashtag3);
            AddHashtagTextBox.Add(addHashtag4);
            AddHashtagTextBox.Add(addHashtag5);
        }

        private void AddUserHashtags()
        {
            for (int i = 0; i < AddHashtagTextBox.Count(); i++)
            {
                if (!string.IsNullOrEmpty(AddHashtagTextBox[i].Text))
                {
                    AddHashtag.Add(AddHashtagTextBox[i].Text);
                }
            }
        }

        private void PopulateUsernameComboBox()
        {
            Usernames = likerController.GetUsernames();
            foreach (string username in Usernames)
            {
                usernameComboBox.Items.Add(username);
            }
        }

        private void usernameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            usernameTextBox.Text = usernameComboBox.Text;

            UserFavHashtags = likerController.GetFavouriteHashtagsForUser(usernameTextBox.Text);
            for (int i = 0; i < UserFavHashtags.Count(); i++)
            {
                HashtagTextBox[i].Text = UserFavHashtags[i];
            }
        }
    }
}
