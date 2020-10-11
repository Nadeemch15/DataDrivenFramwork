using DataDrivenFramwork.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenFramwork
{
    class Methods
    {
        public Methods()
        {
            Hooks hook = new Hooks();
        }
        public IWebElement LoginLink => Hooks.driver.FindElement(By.Id("loginLink"));
        public IWebElement UserName => Hooks.driver.FindElement(By.Id("UserName"));
        public IWebElement Password => Hooks.driver.FindElement(By.Id("Password"));
        public IWebElement LoginButton => Hooks.driver.FindElement(By.XPath("//input[@class='btn btn-default']"));

        public void ClickLoginLink()
        {
            LoginLink.Click();
        }
        public void EnterUserDetials(string uname, string pword)
        {
            UserName.SendKeys(uname);
            Password.SendKeys(pword);
        }
        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
        public void ConfirmUserLoggedIn()
        {

        }
    }
}
