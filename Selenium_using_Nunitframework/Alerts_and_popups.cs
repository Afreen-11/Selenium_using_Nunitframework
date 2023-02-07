using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_using_Nunitframework
{
    public class Alerts_and_popups
    {
        IWebDriver driver;



        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/alertsdemo.html";
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void assertions() 
        
        {
            string expectedTitle = "AlertsDemo - H Y R Tutorials";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            //Assert.IsTrue(actualTitle == expectedTitle, $"Title mismatch: expected '{expectedTitle}', but got '{actualTitle}'");


        }
        [Test]
        public void alertstesting()

        {
            //simple alert
            driver.FindElement(By.XPath("//*[@id=\"alertBox\"]")).Click();
            string message = driver.SwitchTo().Alert().Text;
            Console.WriteLine(message);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
            //confirmation alert

            driver.FindElement(By.XPath("//*[@id=\"confirmBox\"]")).Click();
            //driver.SwitchTo().Alert().Accept();
            driver.SwitchTo().Alert().Dismiss();
            Thread.Sleep(1000);

            //prompt alert
            driver.FindElement(By.XPath("//*[@id=\"promptBox\"]")).Click();
            //driver.SwitchTo().Alert().Dismiss();
            driver.SwitchTo().Alert().SendKeys("Afreen");
            driver.SwitchTo().Alert().Accept();
            


        }

        public void TearDown()
        {
            driver.Quit();
        }

    }
}
 