﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo
{
    public class DriverSettings
    {
        private static IWebDriver driver;
     
        public static IWebDriver Driver
        {
            get { return driver; } 
            set { driver = value; }
        }
    }
}
