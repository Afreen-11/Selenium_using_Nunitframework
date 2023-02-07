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
    public class framesandiframes

    {

        IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://www.uitestpractice.com/students/switchto";
            driver.Manage().Window.Maximize();


        }
        [Test] 
        public void Frames() 
        {
            //Thread.Sleep(1000);
            driver.SwitchTo().Frame(0);//by index number
            //driver.SwitchTo().Frame("iframe_a");
            driver.FindElement(By.Id("name")).SendKeys("abc");
            Thread.Sleep(2000);
            driver.SwitchTo().DefaultContent();
            driver.FindElement(By.LinkText("uitestpractice.com")).Click();
            Thread.Sleep(1000);



        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

















    }





}
