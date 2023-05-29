using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.control;

namespace YopmailAndTodoist.src.code.page.Todoist
{
    public class MainPage
    {
        public Button logInButton = new Button(By.XPath("//li/a[contains(@href,'login')]"));
    }
}
