using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_using_Nunitframework
{
    public class Locators
    {
     
       IWebDriver driver;

      
        [SetUp]
        public void Setup()
        {
           driver = new ChromeDriver();  //edge,firefox,safari etc
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();// Minimize)()
            
           
           
        }

        [Test]
        public void Usinglocators()
        {
            // //By id
            // driver.FindElement(By.Id("email")).SendKeys("abc@gmail.com");
            // Thread.Sleep(2000);
            // //By class name
             driver.FindElement(By.ClassName("_6luy")).SendKeys("abc@gmail.com");
            // //By Name
            // driver.FindElement(By.Name("pass")).SendKeys("abc@123");
            // Thread.Sleep(2000);
            // //By class name
            // driver.FindElement(By.ClassName("_6luy")).SendKeys("abc@123");
            // //By tagname
            // driver.FindElement(By.TagName("button")).Click();
            // Thread.Sleep(2000);
            // //by partaillink
            // driver.FindElement(By.PartialLinkText("Forgotten")).Click();
            // //By linktext
            // driver.FindElement(By.LinkText("Forgotten password?")).Click();
            // //by xpath
            // //absolute xpath
            // driver.FindElement(By.XPath("/ html / body / div[1] / div[1] / div[1] / div / div / div / div[2] / div / div[1] / form / div[5] / a")).Click();
            // //relative xpath by attribute
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//a[@id='u_0_0_Q+']")).Click();
            ////relative xpath by text
            //driver.FindElement(By.XPath("//a[text()='Create new account']")).Click();
            ////relative xpath by contains
            //driver.FindElement(By.XPath("//a[contains(text(),'Create new')]")).Click();
            ////relative xpath by contains along with attributes
            //driver.FindElement(By.XPath("//a[contains(@id,'u_0_0_68')]")).Click();
            ////relative xpath by startswith()
            //driver.FindElement(By.XPath("//a[starts-with(text(),'Create new')]")).Click();
            ////css selector
            //Thread.Sleep(1000);
            ////by attribute value
            driver.FindElement(By.CssSelector("input[placeholder=\"Email address or phone number\"]")).SendKeys("abc@gmail.com");
            ////by simpleselectors such as id,class and tagname
            //driver.FindElement(By.CssSelector("#email")).SendKeys("abc@gmail.com");






        }
        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //}



    }
}