using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace CLEVER
{
    public class Tests
    {
        WebDriver webDriver = new ChromeDriver(@"C:\Users\DELL\Downloads\Driver");



        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            webDriver.Navigate().GoToUrl("https://eshoponwebclever.azurewebsites.net/");

            webDriver.Manage().Window.Maximize();

            Task.Delay(2000).Wait();

            IWebElement lnkLogin = webDriver.FindElement(By.LinkText("LOGIN"));

            Task.Delay(2000).Wait();

            lnkLogin.Click();

            var txtEmail = webDriver.FindElement(By.XPath("//*[@id='Input_Email']"));


            Assert.That(txtEmail.Displayed, Is.True);

            Task.Delay(2000).Wait();

            txtEmail.SendKeys("demouser@microsoft.com");

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("//*[@id='Input_Password']")).SendKeys("Pass@word1");

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/div/div/div/section/form/div[5]/button")).Submit();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("//*[@id='CatalogModel_TypesFilterApplied']")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[5]/form/input[1]")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/header/div/article/section[1]/a/img")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("//*[@id='CatalogModel_TypesFilterApplied']")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[6]/form/input[1]")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/div/form/div/div[3]/section[2]/button")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/div/form/div/div[3]/section[2]/a")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/div/form/div/div[3]/section[1]/a")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/div/form/div/div[3]/section[2]/a")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/div/form/div/div[3]/section[2]/input")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/article/section[2]/div/form/section[1]/img")).Click();

            Task.Delay(2000).Wait();

            webDriver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/article/section[2]/div/form/section[2]/a[3]/img")).Click();

            Task.Delay(2000).Wait();
                      

            
        }


        [OneTimeTearDown]
        public void Close()
        {
            Task.Delay(2000).Wait();

            webDriver.Close();
        }


    }

           

}

                




