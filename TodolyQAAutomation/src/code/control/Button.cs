using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YopmailAndTodoist.src.code.control
{
    public class Button : Control
    {
        public Button(By locator) : base(locator)
        {
        }

        public bool IsEnabled()
        {
            FindControl();
            return control.Enabled;
        }

        public void RightClick()
        {
            FindControl();
            Actions rightClick = new Actions(session.Session.Instance().GetBrowser());
            rightClick.ContextClick(control).Perform();
        }
    }
}
