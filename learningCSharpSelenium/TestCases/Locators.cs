﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharpSelenium.TestCases
{
    internal class Locators
    {
        [Test]
        public void findingLocators()
        {
            //Test -With Locators
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.leafground.com/dashboard.xhtml#");
            var title = driver.Title;
            Assert.That(title, Is.EqualTo("Dashboard"));
            Thread.Sleep(1000);
            driver.Quit();
            //NewWC


            //Added MJ Changes in the Locator class    


            //Need to update the code cahnges for issue fix

        }
    }
}
