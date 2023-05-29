using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.control;

namespace YopmailAndTodoist.src.code.page.YopMail
{
    public class NewMailSection
    {
        public Button newMailButton = new Button(By.Id("newmail"));
        public Frame mailFrame = new Frame(By.Id("ifmail"));
        public Button sendMsgButton = new Button(By.XPath("//button[@id='msgsend']"));

        public Button refreshButton = new Button(By.Id("refresh"));
        public Frame inboxFrame = new Frame(By.Id("ifinbox"));
        public Button lastMailButton = new Button(By.XPath("//div[@currentmail='']/button"));

        public bool MailNameDisplayed(string mailIdentifier)
        {
            Label mailName = new Label(By.XPath($"//div[text()='{mailIdentifier}@yopmail.com']"));
            return mailName.IsControlDisplayed();
        }      

        public void SwitchDefaultContentFrame()
        {
            session.Session.Instance().GetBrowser().SwitchTo().DefaultContent();
        }
    }
}
