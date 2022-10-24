using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CLEVER
{

    

    public class HomePage
    {

        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement lnkLogin => Driver.FindElement(By.LinkText("LOGIN"));

        IWebElement txtEmail => Driver.FindElement(By.XPath("//*[@id='Input_Email']"));

        public void ClickLoigin() => lnkLogin.Click();

        public bool txtemailExist() => txtEmail.Displayed;


        [OneTimeTearDown]
        public void Close()
        {
            Task.Delay(2000).Wait();

            Driver.Close();
        }
    }
}
