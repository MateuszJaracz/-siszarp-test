using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenQA.Selenium.IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://google.pl");
            //ChromeWebElement element = driver.FindElement(DivideByZeroException.
            //OpenQA.Selenium.IWebDriver element = driver.FindElement

            OpenQA.Selenium.IWebElement elementName = driver.FindElement(by: nameof("q"));

            OpenQA.Selenium.IWebElement element = driver.FindElement(by:class("g"));

          
       

            elementName.SendKeys("executeautomation");

            driver.Close();












        }

        private static By nameof(string v)
        {
           throw new NotImplementedException();
       }
    }
}
