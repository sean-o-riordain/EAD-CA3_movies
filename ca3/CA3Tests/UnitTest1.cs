using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

namespace CA3Tests
{
    public class Tests
    {
        WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestLoading()
        {
            driver.Navigate().GoToUrl("https://sorstorageacc1ca3.z13.web.core.windows.net/");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.Id("title"));
            Assert.AreEqual("Services", element.Text);
            driver.Close();
            
        }

        [Test]
        public void TestNavigation()
        {
            driver.Navigate().GoToUrl("https://sorstorageacc1ca3.z13.web.core.windows.net/");
            Thread.Sleep(7000);
            IWebElement element = driver.FindElement(By.Id("allServices"));
            element.Click();
            element = driver.FindElement(By.Id("servicesList"));
            Assert.AreEqual("Services List", element.Text);
            Thread.Sleep(5000);
            element = driver.FindElement(By.Id("title"));
            element.Click();
            Thread.Sleep(1000);
            element = driver.FindElement(By.Id("expandCast"));
            element.Click();
            element = driver.FindElement(By.Id("castName"));
            element.Click();
            element = driver.FindElement(By.Id("personInfo"));
            Assert.AreEqual("Person Info", element.Text);
            driver.Close();
        }

        [Test]
        public void TestSearch()
        {
            driver.Navigate().GoToUrl("https://sorstorageacc1ca3.z13.web.core.windows.net/search");
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.Id("search"));
            element.SendKeys("Game of Thrones");
            element = driver.FindElement(By.Id("send"));
            element.Click();
            Thread.Sleep(1000);
            element = driver.FindElement(By.Id("title"));
            Assert.AreEqual("Game of Thrones", element.Text);
            element.Click();
            Thread.Sleep(3000);
            element = driver.FindElement(By.Id("title"));
            Assert.AreEqual("Game of Thrones", element.Text);
            driver.Close();
        }

    }
}