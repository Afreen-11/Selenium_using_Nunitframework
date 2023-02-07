using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_using_Nunitframework
{
    [TestFixture]//representation of classes
    class checkboxesandradiobuttons
    {
        IWebDriver driver;



        [SetUp]
        public void Setup() 
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/basic-controls.html";
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Testingcheckboxes()
        {
            Thread.Sleep(2000);
           
            driver.FindElement(By.Id("englishchbx")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("hindichbx")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("chinesechbx")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("spanishchbx")).Click();
            Thread.Sleep(2000);
            IWebElement checkbox = driver.FindElement(By.Id("englishchbx"));
            //unchecking a chckbox
            if (checkbox.Selected)
            {
                checkbox.Click();
            }
            IWebElement checkbox1 = driver.FindElement(By.Id("hindichbx"));
            bool isChecked = checkbox1.Selected;
            Console.WriteLine(isChecked);

            IWebElement checkbox2 = driver.FindElement(By.Id("spanishchbx"));
            bool isEnabled = checkbox2.Enabled;
            Console.WriteLine(isEnabled);
        }
            [Test]
            public void Testingradiobuttons()
            {

                Thread.Sleep(1000);
                driver.FindElement(By.Id("femalerb")).Click();
                IWebElement radiobutton = driver.FindElement(By.Id("femalerb"));
                bool a = radiobutton.Enabled;
                Console.WriteLine("the radiobutton is enabled" + a);
            }
        [TearDown]
        public void Teardown() 
        {
            driver.Quit();
        
        }
       
        
        
        
        






        

    }
}
