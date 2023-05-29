using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.control;

namespace YopmailAndTodoist.src.code.page.YopMail
{
    public class ReceivedMailSection
    {

        public bool IsMailEqualToSentMail(MailInfo sentMail)
        {
            Label subjectLbl = new Label(By.XPath("//div[@class='fl']/div[contains(@class,'f18')]"));
            Label bodyLbl = new Label(By.XPath("//div[@id='mail']/div"));
            MailInfo receivedMail = new MailInfo();
            receivedMail.Subject = subjectLbl.GetLabelText();
            receivedMail.Body = bodyLbl.GetLabelText();
            return sentMail.Subject == receivedMail.Subject && sentMail.Body == receivedMail.Body;
        }
    }
}
