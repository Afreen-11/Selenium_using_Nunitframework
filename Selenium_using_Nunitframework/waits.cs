using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Selenium_using_Nunitframework
{
   public class waits
    {

        IWebDriver driver;


        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/waits-demo.html";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [Test]
        public void testing() 
        {
            driver.FindElement(By.Id("btn1")).Click();
          
          
            driver.FindElement(By.Id("txt1")).SendKeys("Afreen");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


        }






   }
}
