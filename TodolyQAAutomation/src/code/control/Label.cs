﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YopmailAndTodoist.src.code.control
{
    public class Label : Control
    {
        public Label(By locator) : base(locator)
        {
        }
        public string GetLabelText()
        {
            FindControl();
            return control.Text;
        }
    }
}
