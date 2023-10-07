using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace IntegrationTestingCalculator.System_integration
{
    public class Assignment2
    {
        IWebDriver driver = new ChromeDriver();
        public Assignment2()
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "user-name")]  //locator used -Id
        IWebElement userNametxtbox { get; set; }

        [FindsBy(How = How.Name, Using = "password")] //locator used - Name
        IWebElement userPasswordtxtbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".submit-button.btn_action")] //locator used - CssSelector
        IWebElement submitButton { get; set; }

        [FindsBy(How = How.TagName, Using = "button")] //locator used - TagName
        IWebElement menuItem { get; set; }

        [FindsBy(How = How.LinkText, Using = "About")] //locator used - LinkText
        IWebElement menuAbout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"item_1_title_link\"]/div")] //locator used - XPath
        IWebElement lnkItem { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-cart-sauce-labs-bolt-t-shirt")] //locator used - Id
        IWebElement btnAddCart { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[2]/div/button")] //locator used - XPath
        IWebElement btnClose { get; set; }

        [FindsBy(How = How.ClassName, Using = "shopping_cart_link")] //locator used - ClassName
        IWebElement imgCart { get; set; }

        [FindsBy(How = How.Id, Using = "checkout")] //locator used - Id
        IWebElement btnCheckout { get; set; }

        [FindsBy(How = How.Name, Using = "firstName")] //locator used - Name
        IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastName")] //locator used - Name
        IWebElement txtlastName { get; set; }

        [FindsBy(How = How.Name, Using = "postalCode")] //locator used - Name
        IWebElement txtpostalCode { get; set; }

        [FindsBy(How = How.Id, Using = "continue")]  //locator used -Id
        IWebElement btncontinue { get; set; }

        [FindsBy(How = How.ClassName, Using = "inventory_item_price")] //locator used - ClassName
        IWebElement inventory_item_price { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn.btn_action.btn_medium.cart_button")] //locator used - CssSelector
        IWebElement btnFinalize { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".summary_info_label.summary_total_label")] //locator used - CssSelector
        IWebElement txtTotalPrice { get; set; }

        [FindsBy(How = How.ClassName, Using = "complete-header")] //locator used - ClassName
        IWebElement orderCompleteMsg { get; set; }

        [FindsBy(How = How.Id, Using = "back-to-products")]  //locator used -Id
        IWebElement btnBackToHome { get; set; }


        [SetUp]
        public void PresetUp()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(100);
        }
        [Test]
        public void Login()
        {
            userNametxtbox.SendKeys("standard_user");
            userPasswordtxtbox.SendKeys("secret_sauce");
            string title = driver.Title;
            Assert.That("Swag Labs", Is.EqualTo(title));
            submitButton.Click();
            menuItem.Click();
            Thread.Sleep(1000);
            Actions action = new Actions(driver);
            action.KeyDown(Keys.LeftControl).Click(menuAbout).KeyUp(Keys.LeftControl).Build().Perform();
            Thread.Sleep(1000);
            btnClose.Click();
            lnkItem.Click();
            Thread.Sleep(100);
            btnAddCart.Click();
            Thread.Sleep(1000);
            imgCart.Click();
            Thread.Sleep(100);
            btnCheckout.Click();
            Thread.Sleep(100);
            txtFirstName.SendKeys("TestUser");
            txtlastName.SendKeys("TestUser");
            txtpostalCode.SendKeys("N2k9f0");
            btncontinue.Click();
            Thread.Sleep(1000);
            string totalCost = inventory_item_price.Text;
            Assert.That("$15.99", Is.EqualTo(totalCost));
            string totalPrice = txtTotalPrice.Text;
            Assert.IsTrue(totalPrice.Contains("$17.27"), totalPrice + " populated is not correct");
            btnFinalize.Click();
            string orderCmpleteMsg = orderCompleteMsg.Text;
            Assert.IsTrue(orderCmpleteMsg.Equals("Thank you for your order!"));
            Thread.Sleep(1000);
            btnBackToHome.Click();
            Thread.Sleep(1000);
        }

        [TearDown]
        public void tearDown()
        {
            driver.Quit();
        }
    }
}
