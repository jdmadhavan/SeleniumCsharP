using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace learningCSharpSelenium.TestCases
{
    internal class DifferentBrowsers
    {
        [Test]
        public void chromeBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            var title = driver.Title;
            Assert.That(title, Is.EqualTo("Selenium"));
            driver.Quit();

        }
        [Test]
        public void firefoxBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            var title = driver.Title;
            Assert.That(title, Is.EqualTo("Selenium"));
            driver.Quit();

        }
        [Test]
        public void edgeBrowser()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            var title = driver.Title;
            Assert.That(title, Is.EqualTo("Selenium"));
            driver.Quit();

        }
    }
}
