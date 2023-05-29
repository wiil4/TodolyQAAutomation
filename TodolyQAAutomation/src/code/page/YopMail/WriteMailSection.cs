using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.control;

namespace YopmailAndTodoist.src.code.page.YopMail
{
    public class WriteMailSection
    {
        public TextBox toTxtBox = new TextBox(By.XPath("//input[@id='msgto']"));
        public TextBox subjectTxtBox = new TextBox(By.XPath("//input[@id='msgsubject']"));
        public TextBox bodyTxtBox = new TextBox(By.XPath("//div[@id='msgbody']"));
        public Button sendButton = new Button(By.XPath("//button[@id='msgsend']"));        

        public bool MsgSentPopDisplayed()
        {
            PopDialog msgSentDialog = new PopDialog(By.XPath("//div[@id='msgpop']"));
            return msgSentDialog.IsControlDisplayed();
        }
    }
}
