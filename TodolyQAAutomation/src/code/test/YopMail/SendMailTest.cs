using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.page.YopMail;

namespace YopmailAndTodoist.src.code.test.YopMail
{
    [TestClass]
    public class SendMailTest : BaseTest
    {
        MainPage mainPage = new MainPage();
        NewMailSection newMailSection = new NewMailSection();
        WriteMailSection writeMailSection = new WriteMailSection();
        ReceivedMailSection receivedMailSection = new ReceivedMailSection();    

        //[TestMethod]
        public void SendMailTestMethod()
        {
            //GENERATING A NEW EMAIL WITH RANDOM NUMBER
            mainPage.GenerateRandomEmail();
            mainPage.CreateEmail();
            //CHECK IF THE GENERATED MAIL IS THE SAME AS THE MAIL PAGE
            Assert.IsTrue(newMailSection.MailNameDisplayed(mainPage.emailIdentifier),
                "ERROR! Incorrect mail name");
            //CREATING NEW MAIL
            newMailSection.newMailButton.Click();
            newMailSection.mailFrame.SwitchFrame();
            //CHECKING IF THE FRAME WAS CORRECTLY CHANGED
            Assert.IsTrue(newMailSection.sendMsgButton.IsControlDisplayed());

            MailInfo newMail = new MailInfo();
            newMail.To = $"{mainPage.emailIdentifier}@yopmail.com";            
            newMail.Subject = "12345678";
            newMail.Body = "12345678";

            //USING AN OBJECT TO TEMPORARY SAVE THE GENERATED DATA
            writeMailSection.toTxtBox.SetText(newMail.To);
            writeMailSection.subjectTxtBox.SetText(newMail.Subject);
            writeMailSection.bodyTxtBox.SetText(newMail.Body);

            //CHECK IF ALL REQUIRED INPUTS WERE FILLED
            Assert.IsTrue(writeMailSection.sendButton.IsEnabled(),"ERROR! Required Button is not enabled");

            //SENDING THE MAIL
            writeMailSection.sendButton.Click();
            //CHECK IF THE MAIL WAS CORRECTLY SENT
            Thread.Sleep(2000);
            Assert.IsTrue(writeMailSection.MsgSentPopDisplayed(),"ERROR! Message has not been sent");

            //CHANGING THE FRAME SO THE PAGE CAN BE REFRESHED
            newMailSection.SwitchDefaultContentFrame();
            Thread.Sleep(2000);

            //PROCESS FOR OPENING THE LAST RECEIVED MAIL
            newMailSection.refreshButton.Click();
            newMailSection.inboxFrame.SwitchFrame();
            Thread.Sleep(2000);
            newMailSection.lastMailButton.Click();
            newMailSection.SwitchDefaultContentFrame();
            newMailSection.mailFrame.SwitchFrame();

            //CHECKING IF THE MAIL RECEIVED HAS THE SAME VALUES AS THE GENERATED IN THE OBJECT MAILINFO
            Assert.IsTrue(receivedMailSection.IsMailEqualToSentMail(newMail),
                "ERROR! received mail is not like the sent mail");            
        }
    }
}
