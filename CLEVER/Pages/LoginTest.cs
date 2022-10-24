using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CLEVER.HomePages
{
    class Login
    {

        WebDriver Driver;

        public Login(IWebDriver driver)
        {

            WebDriver = driver;

        }

        public IWebDriver WebDriver { get; }


        IWebElement txtEmail => WebDriver.FindElement(By.XPath("//*[@id='Input_Email']"));

        IWebElement txtPassword => WebDriver.FindElement(By.XPath("//*[@id='Input_Password']"));

        IWebElement btnLogin => WebDriver.FindElement(By.XPath("/html/body/div[1]/div/div/div/section/form/div[5]/button"));


        public void LoginPage(string username, string password)
        {


            txtEmail.SendKeys("admin");

            Task.Delay(2000).Wait();

            txtPassword.SendKeys("password");

            Task.Delay(2000).Wait();

            btnLogin.Submit();

        }

        [OneTimeTearDown]
        public void Close()
        {
            Task.Delay(2000).Wait();

            Driver.Close();
        }



    }
}
