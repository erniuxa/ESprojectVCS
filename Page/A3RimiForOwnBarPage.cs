using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESprojectVCS.Page
{
    public class A3RimiForOwnBarPage : BasePage
    {
        private const string PageAddress = "https://www.rimi.lt/e-parduotuve/lt/savam-barui";

        private IWebElement _clickFirstProduct => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section/div/div[2]/div/div/div[2]/div/div/div[1]/div/div/a"));
        private IWebElement _clickSecondProduct => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section/div/div[2]/div/div/div[2]/div/div/div[2]/div/div/a"));
        private IWebElement _addToCartProducts => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/div[2]/form[1]/button"));
        private IWebElement _checkFirstProductText => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/h3"));        
        private IWebElement _checkSecondProductText => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/h3"));
        private IWebElement _compareFirstProductText => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/div[2]/div[1]/div[1]/div[2]/a"));
        private IWebElement _compareSecondProductText => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/div[2]/div[1]/div[1]/div[2]/a"));
        private IWebElement _productPriceEur => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/div[1]/div[1]/span"));
        private IWebElement _productPriceCents => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/div[1]/div[1]/div/sup"));
        
        private IWebElement _compareFirstProductPriceCents => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/footer/div[1]/p[3]/span[2]"));
        private IWebElement _deleteAllProductsFromCart => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/footer/div[2]/button[2]"));
        private IWebElement _confirmToDeleteAllProductsFromCart => Driver.FindElement(By.XPath("/html/body/div[3]/div/div/form/button[1]"));
        private IWebElement _checkIsCartEmty => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/div[2]/div/p"));
        private IWebElement _checkIsCartShowaZero => Driver.FindElement(By.XPath("/html/body/div[1]/div/a/div/div"));


        public A3RimiForOwnBarPage (IWebDriver webdriver) : base(webdriver)
        { }

        public A3RimiForOwnBarPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public A3RimiForOwnBarPage AcceptAllConsents()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%27NDQkerFt+RZxk4VoklqoLhWxNQ7zeq/ljnHOfE08GdswowadlGIqHA==%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:true%2Cmarketing:true%2Cver:2%2Cutc:1600839127738%2Cregion:%27lt%27}",
                "www.rimi.lt", "/", DateTime.Now.AddDays(2));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
            return this;
        }

        public A3RimiForOwnBarPage ClickFirstProduct()
        {
            _clickFirstProduct.Click();
            return this;
        }

       public A3RimiForOwnBarPage ClickSecondProduct()
        {
            _clickSecondProduct.Click();
            return this;
        }

        public A3RimiForOwnBarPage AddToCartProduct()
        {
            _addToCartProducts.Click();
            return this;
        }

        public A3RimiForOwnBarPage CheckIsCompareFirstProductText()
        {
            string compareFirstProductText = _compareFirstProductText.Text;
            GetWait().Equals(ExpectedConditions.Equals(_checkFirstProductText, compareFirstProductText));
            Assert.AreEqual(_checkFirstProductText.Text, compareFirstProductText, "Text is not the same. Check screenshot!");
            return this;
        }

        public A3RimiForOwnBarPage CheckIsCompareSecondProductText()// +
        {
            string compareSecondProductText = _compareSecondProductText.Text;
            GetWait().Equals(ExpectedConditions.Equals(_checkSecondProductText, compareSecondProductText));
            Assert.AreEqual(_checkSecondProductText.Text, compareSecondProductText, "Text is not the same. Check screenshot!");
            return this;
        }

        public A3RimiForOwnBarPage ProductPrice()
        {
            string firstProductPrice = "1,49 €";
            string comparefirstProductPrice = _compareFirstProductPriceCents.Text;
            Assert.AreEqual(firstProductPrice, comparefirstProductPrice, "Text is not the same. Check screenshot!");
            return this;
        }

        public A3RimiForOwnBarPage ProductPrice2()
        {
            string firstProductPrice = "0,89 €";
            string comparefirstProductPrice = _compareFirstProductPriceCents.Text;
            Assert.AreEqual(firstProductPrice, comparefirstProductPrice, "Text is not the same. Check screenshot!");
            return this;
        }

        public A3RimiForOwnBarPage DeleteAllProductsFromCart()
        {
            _deleteAllProductsFromCart.Click();
            return this;
        }

        public A3RimiForOwnBarPage ConfirmToDeleteAllProductsFromCart()
        {
            _confirmToDeleteAllProductsFromCart.Click();
            return this;
        }

        public A3RimiForOwnBarPage CheckIsCartEmty()
        {
            _checkIsCartEmty.Click();
            return this;
        }

        public A3RimiForOwnBarPage CheckIsCartShowsZero()
        {
            Assert.AreEqual("0", _checkIsCartShowaZero.Text, "Text is not the same. Check screenshot!");
            return this;
        }
    }
}
