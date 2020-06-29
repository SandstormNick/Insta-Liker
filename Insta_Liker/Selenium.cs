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


        private string Username { get; set; }
        private string Password { get; set; }
        #endregion

        public Selenium( string username, string password)
        {
            Driver = new ChromeDriver();

            Username = username;
            Password = password;
        }

        //The main method that runs the selenium
        public void Run()
        {
            MaximiseWindow();
            NavigateToWebsite();

            SetLoginScreenElements();

            EnterCredentials();
            LogInButton.Click();
            Thread.Sleep(5000); //can get rid of later
        }

        public void SetLoginScreenElements()
        {
            ImplicitWait();
            UsernameTextBox = Driver.FindElementByXPath("//input[@name = 'username']");
            PasswordTextBox = Driver.FindElementByXPath("//input[@name='password']");
            LogInButton = Driver.FindElementByXPath("//button/div[contains(text(), 'Log In')]");
        }

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
    }
}
