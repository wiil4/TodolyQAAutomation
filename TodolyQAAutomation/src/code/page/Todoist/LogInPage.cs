using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.control;

namespace YopmailAndTodoist.src.code.page.Todoist
{
    public class LogInPage
    {
        public TextBox usertxtBox = new TextBox(By.XPath("//input[@id='element-0']"));
        public TextBox passtxtBox = new TextBox(By.XPath("//input[@id='element-3']"));
        public Button logInButton = new Button(By.XPath("//form/button"));

        public void LogIn(string user, string pwd)
        {
            usertxtBox.SetText(user);
            passtxtBox.SetText(pwd);
            logInButton.Click();
        }

        public bool IsInboxDisplayed()
        {
            Button inboxButton = new Button(By.XPath("//li[@id='filter_inbox']//a"));
            return inboxButton.IsControlDisplayed();
        }
    }
}
