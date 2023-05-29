using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YopmailAndTodoist.src.code.control
{
    public class Frame : Control
    {
        public Frame(By locator) : base(locator)
        {
        }

        public void SwitchFrame()
        {
            FindControl();
            session.Session.Instance().GetBrowser().SwitchTo().Frame(control);
        }
    }
}
