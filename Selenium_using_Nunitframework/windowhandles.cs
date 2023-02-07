using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections;

namespace Selenium_using_Nunitframework
{
    public class windowhandles
    {
        IWebDriver driver;



        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/window-handles-practice.html";
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void windowhandlestesting()
        {
            string parentwindow = driver.CurrentWindowHandle;
            //opening a new window
            driver.FindElement(By.Id("newWindowBtn")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Manage().Window.Maximize();
            //performing operations on new window
            driver.FindElement(By.Id("firstName")).SendKeys("Afreen");
            Thread.Sleep(2000);
            driver.Close();
            //back to parentwindow
            driver.SwitchTo().Window(parentwindow);
            driver.FindElement(By.Id("name")).SendKeys("Hello");

            //driver.FindElement(By.Id("newWindowsBtn")).Click();
            //IList<string> windows = driver.WindowHandles;
            //Console.WriteLine(windows.Count);
           













        }










    }
}
