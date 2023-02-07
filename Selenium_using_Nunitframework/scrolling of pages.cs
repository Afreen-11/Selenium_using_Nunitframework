using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_using_Nunitframework
{
    public class scrolling_of_pages
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void ScrollDown()
        {
            driver.Url=("https://www.appple.com/");
            driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 500)");
            Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}