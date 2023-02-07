using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_using_Nunitframework
{
    public class Screenshots
    {
        IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();


        }
        [Test]
        public void Screenshot() 
        {
            ITakesScreenshot screenshot = (ITakesScreenshot)driver;
            //Calling Getscreenhot method to create an image file which is provided by screenshot class
            Screenshot ss = screenshot.GetScreenshot();
            string filepath = "D:\\myworks\\screenshot\\";
            ss.SaveAsFile(filepath + "fbss123" + ".png", ScreenshotImageFormat.Png);
            //ITakesScreenshot? screenshot = driver as ITakesScreenshot;
            //Screenshot screenshot1 = screenshot.GetScreenshot();
            
            //screenshot1.SaveAsFile("D:\\myworks\\screenshot\\fbss1.png", ScreenshotImageFormat.Png);




        }
        [TearDown]  
        public void TearDown()
        { 
            driver.Close();
        
        }






    }
}
