namespace Insta_Liker
{
    partial class Liker
    {
        private System.Windows.Forms.Label mainHeaderLabel;
        private System.Windows.Forms.GroupBox CredentialsBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainHeaderLabel = new System.Windows.Forms.Label();
            this.CredentialsBox = new System.Windows.Forms.GroupBox();
            this.credentialsHeaderLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.hashtagFormBox = new System.Windows.Forms.GroupBox();
            this.hashtagHeaderLabel = new System.Windows.Forms.Label();
            this.hashtag5TextBox = new System.Windows.Forms.TextBox();
            this.hashtag4TextBox = new System.Windows.Forms.TextBox();
            this.hashtag3TextBox = new System.Windows.Forms.TextBox();
            this.hashtag2TextBox = new System.Windows.Forms.TextBox();
            this.hashtag1TextBox = new System.Windows.Forms.TextBox();
            this.numLikesGroupBox = new System.Windows.Forms.GroupBox();
            this.max100LikesLabel = new System.Windows.Forms.Label();
            this.numLikesTextBox = new System.Windows.Forms.TextBox();
            this.numLikesHeader = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CredentialsBox.SuspendLayout();
            this.hashtagFormBox.SuspendLayout();
            this.numLikesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainHeaderLabel
            // 
            this.mainHeaderLabel.AutoSize = true;
            this.mainHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeaderLabel.Location = new System.Drawing.Point(155, 12);
            this.mainHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainHeaderLabel.Name = "mainHeaderLabel";
            this.mainHeaderLabel.Size = new System.Drawing.Size(109, 26);
            this.mainHeaderLabel.TabIndex = 3;
            this.mainHeaderLabel.Text = "Insta <3er";
            // 
            // CredentialsBox
            // 
            this.CredentialsBox.Controls.Add(this.credentialsHeaderLabel);
            this.CredentialsBox.Controls.Add(this.passwordLabel);
            this.CredentialsBox.Controls.Add(this.usernameLabel);
            this.CredentialsBox.Controls.Add(this.passwordTextBox);
            this.CredentialsBox.Controls.Add(this.usernameTextBox);
            this.CredentialsBox.Location = new System.Drawing.Point(12, 48);
            this.CredentialsBox.Name = "CredentialsBox";
            this.CredentialsBox.Size = new System.Drawing.Size(400, 97);
            this.CredentialsBox.TabIndex = 0;
            this.CredentialsBox.TabStop = false;
            // 
            // credentialsHeaderLabel
            // 
            this.credentialsHeaderLabel.AutoSize = true;
            this.credentialsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsHeaderLabel.Location = new System.Drawing.Point(15, 16);
            this.credentialsHeaderLabel.Name = "credentialsHeaderLabel";
            this.credentialsHeaderLabel.Size = new System.Drawing.Size(79, 17);
            this.credentialsHeaderLabel.TabIndex = 4;
            this.credentialsHeaderLabel.Text = "Credentials";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(217, 45);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(15, 45);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(219, 61);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(165, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(18, 61);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(165, 20);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // hashtagFormBox
            // 
            this.hashtagFormBox.Controls.Add(this.hashtagHeaderLabel);
            this.hashtagFormBox.Controls.Add(this.hashtag5TextBox);
            this.hashtagFormBox.Controls.Add(this.hashtag4TextBox);
            this.hashtagFormBox.Controls.Add(this.hashtag3TextBox);
            this.hashtagFormBox.Controls.Add(this.hashtag2TextBox);
            this.hashtagFormBox.Controls.Add(this.hashtag1TextBox);
            this.hashtagFormBox.Location = new System.Drawing.Point(12, 157);
            this.hashtagFormBox.Name = "hashtagFormBox";
            this.hashtagFormBox.Size = new System.Drawing.Size(400, 181);
            this.hashtagFormBox.TabIndex = 1;
            this.hashtagFormBox.TabStop = false;
            // 
            // hashtagHeaderLabel
            // 
            this.hashtagHeaderLabel.AutoSize = true;
            this.hashtagHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashtagHeaderLabel.Location = new System.Drawing.Point(15, 16);
            this.hashtagHeaderLabel.Name = "hashtagHeaderLabel";
            this.hashtagHeaderLabel.Size = new System.Drawing.Size(23, 17);
            this.hashtagHeaderLabel.TabIndex = 5;
            this.hashtagHeaderLabel.Text = "#s";
            // 
            // hashtag5TextBox
            // 
            this.hashtag5TextBox.Location = new System.Drawing.Point(18, 137);
            this.hashtag5TextBox.Name = "hashtag5TextBox";
            this.hashtag5TextBox.ReadOnly = true;
            this.hashtag5TextBox.Size = new System.Drawing.Size(165, 20);
            this.hashtag5TextBox.TabIndex = 6;
            // 
            // hashtag4TextBox
            // 
            this.hashtag4TextBox.Location = new System.Drawing.Point(219, 94);
            this.hashtag4TextBox.Name = "hashtag4TextBox";
            this.hashtag4TextBox.ReadOnly = true;
            this.hashtag4TextBox.Size = new System.Drawing.Size(165, 20);
            this.hashtag4TextBox.TabIndex = 5;
            // 
            // hashtag3TextBox
            // 
            this.hashtag3TextBox.Location = new System.Drawing.Point(18, 94);
            this.hashtag3TextBox.Name = "hashtag3TextBox";
            this.hashtag3TextBox.ReadOnly = true;
            this.hashtag3TextBox.Size = new System.Drawing.Size(165, 20);
            this.hashtag3TextBox.TabIndex = 4;
            // 
            // hashtag2TextBox
            // 
            this.hashtag2TextBox.Location = new System.Drawing.Point(219, 49);
            this.hashtag2TextBox.Name = "hashtag2TextBox";
            this.hashtag2TextBox.ReadOnly = true;
            this.hashtag2TextBox.Size = new System.Drawing.Size(165, 20);
            this.hashtag2TextBox.TabIndex = 3;
            this.hashtag2TextBox.TextChanged += new System.EventHandler(this.hashtag2TextBox_TextChanged);
            // 
            // hashtag1TextBox
            // 
            this.hashtag1TextBox.Location = new System.Drawing.Point(18, 49);
            this.hashtag1TextBox.Name = "hashtag1TextBox";
            this.hashtag1TextBox.Size = new System.Drawing.Size(165, 20);
            this.hashtag1TextBox.TabIndex = 2;
            this.hashtag1TextBox.TextChanged += new System.EventHandler(this.hashtag1TextBox_TextChanged);
            // 
            // numLikesGroupBox
            // 
            this.numLikesGroupBox.Controls.Add(this.max100LikesLabel);
            this.numLikesGroupBox.Controls.Add(this.numLikesTextBox);
            this.numLikesGroupBox.Controls.Add(this.numLikesHeader);
            this.numLikesGroupBox.Location = new System.Drawing.Point(12, 350);
            this.numLikesGroupBox.Name = "numLikesGroupBox";
            this.numLikesGroupBox.Size = new System.Drawing.Size(400, 83);
            this.numLikesGroupBox.TabIndex = 4;
            this.numLikesGroupBox.TabStop = false;
            // 
            // max100LikesLabel
            // 
            this.max100LikesLabel.AutoSize = true;
            this.max100LikesLabel.Location = new System.Drawing.Point(189, 51);
            this.max100LikesLabel.Name = "max100LikesLabel";
            this.max100LikesLabel.Size = new System.Drawing.Size(66, 13);
            this.max100LikesLabel.TabIndex = 6;
            this.max100LikesLabel.Text = "(Max of 100)";
            // 
            // numLikesTextBox
            // 
            this.numLikesTextBox.Location = new System.Drawing.Point(18, 48);
            this.numLikesTextBox.Name = "numLikesTextBox";
            this.numLikesTextBox.Size = new System.Drawing.Size(165, 20);
            this.numLikesTextBox.TabIndex = 5;
            this.numLikesTextBox.TextChanged += new System.EventHandler(this.numLikesTextBox_TextChanged);
            // 
            // numLikesHeader
            // 
            this.numLikesHeader.AutoSize = true;
            this.numLikesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLikesHeader.Location = new System.Drawing.Point(15, 16);
            this.numLikesHeader.Name = "numLikesHeader";
            this.numLikesHeader.Size = new System.Drawing.Size(106, 17);
            this.numLikesHeader.TabIndex = 5;
            this.numLikesHeader.Text = "Number of likes";
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(324, 450);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(88, 28);
            this.runButton.TabIndex = 5;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save username (temp)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Liker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.numLikesGroupBox);
            this.Controls.Add(this.hashtagFormBox);
            this.Controls.Add(this.CredentialsBox);
            this.Controls.Add(this.mainHeaderLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Liker";
            this.Text = "Form1";
            this.CredentialsBox.ResumeLayout(false);
            this.CredentialsBox.PerformLayout();
            this.hashtagFormBox.ResumeLayout(false);
            this.hashtagFormBox.PerformLayout();
            this.numLikesGroupBox.ResumeLayout(false);
            this.numLikesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hashtagFormBox;
        private System.Windows.Forms.TextBox hashtag5TextBox;
        private System.Windows.Forms.TextBox hashtag4TextBox;
        private System.Windows.Forms.TextBox hashtag3TextBox;
        private System.Windows.Forms.TextBox hashtag2TextBox;
        private System.Windows.Forms.TextBox hashtag1TextBox;
        private System.Windows.Forms.Label credentialsHeaderLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label hashtagHeaderLabel;
        private System.Windows.Forms.GroupBox numLikesGroupBox;
        private System.Windows.Forms.Label max100LikesLabel;
        private System.Windows.Forms.TextBox numLikesTextBox;
        private System.Windows.Forms.Label numLikesHeader;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button button1;
    }
}

