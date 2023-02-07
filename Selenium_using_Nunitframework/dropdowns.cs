using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Selenium_using_Nunitframework
{
    public class dropdown
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void Multiselecteddropdown()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.hyrtutorials.com/p/html-dropdown-elements-practice.html";
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Test()
        {
            //IWebElement Ideelement = driver.FindElement(By.Id("ide"));
            //SelectElement IdeDropdown = new SelectElement(Ideelement);
            //IdeDropdown.SelectByIndex(0);
            //IdeDropdown.SelectByValue("nb");
            //IdeDropdown.SelectByText("Visual Studio");
            //Thread.Sleep(2000);
            //IdeDropdown.DeselectByValue("nb");


            //IList<IWebElement> IdeDropdownoptions = IdeDropdown.Options;
            //Console.WriteLine(IdeDropdownoptions.Count);

            //foreach (var element in IdeDropdownoptions)
            //{
            //    Console.WriteLine(element.Text);
            //}

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.LinkText("Tutorials"))).

            ClickAndHold(driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/ul/li[2]/ul/li[4]/a"))).ClickAndHold(driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div/div/ul/li[2]/ul/li[4]/ul/li[1]/a"))).
            Click().Perform();
            Thread.Sleep(2000);

        }

        [OneTimeTearDown]
        public void OneTimeTearDown() 
        {
            driver.Quit();
        
        
        }
    }












}
