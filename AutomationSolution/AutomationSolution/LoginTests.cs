using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationSolution
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://a.testaddressbook.com/");
            driver.FindElement(By.Id("sign-in")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("input[data-test='email']")).SendKeys("asd@asd.asd");
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("asd");
            driver.FindElement(By.XPath("//input[@value='Sign in']")).Click();

            Assert.AreEqual("asd@asd.asd",
                driver.FindElement(By.CssSelector("span[data-test='current-user']")).Text);

            driver.Quit();
        }
    }
}
