using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharpSelenium.TestCases
{
    [TestFixture]
    public class TestOne

    {
        [Test]
        public void firstTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            var title = driver.Title;
            Assert.That(title, Is.EqualTo("Selenium"));
            driver.Close();

        }
    }
}
