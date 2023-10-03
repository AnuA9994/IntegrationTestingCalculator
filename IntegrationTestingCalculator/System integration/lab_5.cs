using Calculator;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTestingCalculator.System_integration
{
    internal class lab_5
    {
        IWebDriver driver= new ChromeDriver();
        [SetUp]
        public void PresetUp()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.ca/");
            Thread.Sleep(100);
        }

        [Test]
        public void SelectLap()
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Laptop" + Keys.Enter);
            string title = driver.Title;
            Assert.AreEqual(title, "Amazon.ca : Laptop");
            driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[14]/div/div/div/div/div[1]/span/a/div/img")).Click();
            Thread.Sleep(100);
            driver.FindElement(By.Id("add-to-cart-button")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"attachSiNoCoverage\"]/span/input")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"sc-buy-box-ptc-button\"]/span/input")).Click();
            Thread.Sleep(100);
            driver.Quit();
        }
    }
}
