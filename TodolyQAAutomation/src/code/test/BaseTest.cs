using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.session;

namespace YopmailAndTodoist.src.code.test
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void OpenBrowser()
        {
            //Session.Instance().GetBrowser().Navigate().GoToUrl("https://yopmail.com/");
            Session.Instance().GetBrowser().Navigate().GoToUrl("https://todoist.com/");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            Session.instance.CloseBrowser();
        }

    }
}
