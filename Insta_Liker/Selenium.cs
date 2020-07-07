using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Insta_Liker
{
    class Selenium
    {
        #region Properties
        private ChromeDriver Driver { get; set; }

        private const int FIVE_SECONDS = 5;
        private const string INSTA_URL = "https://www.instagram.com/";

        OpenQA.Selenium.IWebElement UsernameTextBox { get; set; }
        OpenQA.Selenium.IWebElement PasswordTextBox { get; set; }
        OpenQA.Selenium.IWebElement LogInButton { get; set; }

        OpenQA.Selenium.IWebElement SearchBarTextBox { get; set; }
        OpenQA.Selenium.IWebElement SearchTermLink { get; set; }

        OpenQA.Selenium.IWebElement HashtagImageLink { get; set; }
        OpenQA.Selenium.IWebElement HeartButton { get; set; }
        OpenQA.Selenium.IWebElement NextImageButton { get; set; }
        OpenQA.Selenium.IWebElement XButton { get; set; }

        private string Username { get; set; }
        private string Password { get; set; }
        private int NumOfLikes { get; set; }

        private List<string> Hashtag { get; set; }

        private int HashtagCounter { get; set; }

        #endregion

        public Selenium( string username, string password, List<string> hashtag, int numLikes)
        {
            Driver = new ChromeDriver();

            Username = username;
            Password = password;
            Hashtag = hashtag;
            NumOfLikes = numLikes;
        }

        //The main method that runs the selenium
        public void Run()
        {
            MaximiseWindow();
            NavigateToWebsite();

            SetLoginScreenElements();

            EnterCredentials();
            LogInButton.Click();

            for (int tagCount = 0; tagCount < Hashtag.Count(); tagCount++)
            {
                //some teething issues around going onto second hashtag
                Thread.Sleep(10000);
                SetHomeScreenElements();
                EnterHashtag();
                SetSearchTermLink();
                ClickSearchTermLink();

                SetHashtagImageLink();
                ClickHashtagImageLink();

                for (int i = 0; i < NumOfLikes; i++)
                {
                    SetHeartButton();
                    SetNextImageButton();

                    ClickHeartButton();
                    ClickNextImageButton();
                    Thread.Sleep(3000);

                    if (i == NumOfLikes - 1)
                    {
                        SetXButton();
                        ClickXButton();
                    }
                }
            }
        }

        #region Login Screen
        public void SetLoginScreenElements()
        {
            ImplicitWait();
            UsernameTextBox = Driver.FindElementByName("username");
            PasswordTextBox = Driver.FindElementByName("password");
            LogInButton = Driver.FindElementByXPath("//button/div[contains(text(), 'Log In')]");
        }

        public void EnterUsername(string username)
        {
            UsernameTextBox.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordTextBox.SendKeys(password);
        }

        public void EnterCredentials()
        {
            ImplicitWait();
            EnterUsername(Username);
            EnterPassword(Password);
        }

        public void ClickLoginButton()
        {
            LogInButton.Click();
        }
        #endregion

        #region Home Screen
        public void SetHomeScreenElements()
        {
            ImplicitWait();
            SearchBarTextBox = Driver.FindElementByXPath("//nav/div[2]/div/div/div[2]/input");
        }

        public void SetSearchTermLink()
        {
            ImplicitWait();
            SearchBarTextBox = Driver.FindElementByXPath("//span[text() = '" + Hashtag[HashtagCounter] + "']/ancestor::a");
        }

        public void ClickSearchTermLink()
        {
            SearchBarTextBox.Click();
        }

        public void EnterHashtag()
        {
            SearchBarTextBox.SendKeys(Hashtag[HashtagCounter]);
        }

        public void UpdateHashtagCounter()
        {
            HashtagCounter++;
        }
        #endregion

        #region Hashtag Screen
        public void SetHashtagImageLink()
        {
            ImplicitWait();
            HashtagImageLink = Driver.FindElementByXPath("//h2[text() = 'Most recent']/following-sibling::div/div/div[1]/div[1]");
        }

        public void ClickHashtagImageLink()
        {
            HashtagImageLink.Click();
        }

        public void SetHeartButton()
        {
            ImplicitWait();
            HeartButton = Driver.FindElementByXPath("//article/div[2]/section[1]/span[1]/button");
        }

        public void ClickHeartButton()
        {
            HeartButton.Click();
        }

        public void SetNextImageButton()
        {
            ImplicitWait();
            NextImageButton = Driver.FindElementByXPath("//a[text() = 'Next']");
        }

        public void ClickNextImageButton()
        {
            NextImageButton.Click();
        }

        public void SetXButton()
        {
            ImplicitWait();
            XButton = Driver.FindElementByXPath("//body/div[4]/div[3]/button");
        }

        public void ClickXButton()
        {
            XButton.Click();
        }
        #endregion

        public void MaximiseWindow()
        {
            Driver.Manage().Window.Maximize();
        }

        public void NavigateToWebsite()
        {
            Driver.Navigate().GoToUrl(INSTA_URL);
        }

        public void ImplicitWait()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(FIVE_SECONDS);
        }
    }
}
