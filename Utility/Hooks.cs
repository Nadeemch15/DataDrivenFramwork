using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DataDrivenFramwork.Utility
{
    [Binding]
    public sealed class Hooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

        }

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    driver.Close();
        //}
    }
}
