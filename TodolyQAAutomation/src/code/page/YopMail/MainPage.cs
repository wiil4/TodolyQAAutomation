using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.control;

namespace YopmailAndTodoist.src.code.page.YopMail
{
    public class MainPage
    {
        private string _baseMailText = "mojix";
        public string emailIdentifier { get; set; }

        public TextBox emailTxtBox = new TextBox(By.XPath("//input[@id='login']"));
        public Button submitButton = new Button(By.Id("refreshbut"));

        public void GenerateRandomEmail()
        {
            Random value = new Random();
            emailIdentifier = string.Concat(_baseMailText,value.Next(99,9999));
        }

        public void CreateEmail()
        {
            emailTxtBox.SetText(emailIdentifier);
            submitButton.Click();           
        }
    }
}
