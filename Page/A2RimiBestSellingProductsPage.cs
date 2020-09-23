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
    public class A2RimiBestSellingProductsPage : BasePage
    {
        private const string PageAddress = "https://www.rimi.lt/e-parduotuve/lt/perkamiausi-produktai";

        private IWebElement _clickFirstProduct => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section/div/div[2]/div[1]/div/div[1]/a/img"));
        private IWebElement _clickSecondProduct => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section/div/div[3]/div/div/div[1]/a/img"));
        private IWebElement _addToCartProducts => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/div[2]/form[1]/button"));       
        private IWebElement _checkFirstProductText => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/h3"));
        private IWebElement _checkSecondProductText => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/h3"));
        private IWebElement _compareFirstProductText => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/div[2]/div[1]/div[1]/div[2]/a"));
        private IWebElement _compareSecondProductText => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/div[2]/div[1]/div[1]/div[2]/a"));
        private IWebElement _productPriceEur => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/div[1]/div[1]/span"));        
        private IWebElement _productPriceCents => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[1]/div/div/section[1]/div/div[1]/div[2]/div[1]/div[1]/div/sup"));
        private IWebElement _compareFirstProductPriceCents => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/footer/div[1]/p[2]/span[2]"));
        private IWebElement _deleteAllProductsFromCart => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/footer/div[2]/button[2]"));
        private IWebElement _confirmToDeleteAllProductsFromCart => Driver.FindElement(By.XPath("/html/body/div[3]/div/div/form/button[1]"));
        private IWebElement _checkIsCartEmty => Driver.FindElement(By.XPath("//*[@id=\"main\"]/section/div[2]/div/aside/div[2]/div/p"));
        private IWebElement _checkIsCartShowaZero => Driver.FindElement(By.XPath("/html/body/div[1]/div/a/div/div"));


        public A2RimiBestSellingProductsPage(IWebDriver webdriver) : base(webdriver)
        { }

        public A2RimiBestSellingProductsPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public A2RimiBestSellingProductsPage AcceptAllConsents()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%27NDQkerFt+RZxk4VoklqoLhWxNQ7zeq/ljnHOfE08GdswowadlGIqHA==%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:true%2Cmarketing:true%2Cver:2%2Cutc:1600839127738%2Cregion:%27lt%27}",
                "www.rimi.lt", "/", DateTime.Now.AddDays(2));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
            return this;
        }

        public A2RimiBestSellingProductsPage ClickFirstProduct()
        {
            _clickFirstProduct.Click();
            return this;
        }

        public A2RimiBestSellingProductsPage ClickSecondProduct()//+
        {
            _clickSecondProduct.Click();
            return this;
        }

        public A2RimiBestSellingProductsPage AddToCartProduct()
        {
            _addToCartProducts.Click();
            return this;
        }

        public A2RimiBestSellingProductsPage CheckIsCompareFirstProductText()
        {
            string compareFirstProductText =_compareFirstProductText.Text;
            GetWait().Equals(ExpectedConditions.Equals(_checkFirstProductText, compareFirstProductText));
            Assert.AreEqual(_checkFirstProductText.Text, compareFirstProductText, "Text is not the same. Check screenshot!");
            return this;
        }

        public A2RimiBestSellingProductsPage CheckIsCompareSecondProductText()// +
        {
            string compareSecondProductText = _compareSecondProductText.Text;
            GetWait().Equals(ExpectedConditions.Equals(_checkSecondProductText, compareSecondProductText));
            Assert.AreEqual(_checkSecondProductText.Text, compareSecondProductText, "Text is not the same. Check screenshot!");
            return this;
        }

        public A2RimiBestSellingProductsPage ProductPrice()
        {
            string firstProductPrice = (_productPriceEur.Text + "," + _productPriceCents.Text + " €");
            string comparefirstProductPrice = _compareFirstProductPriceCents.Text;
            Assert.AreEqual(firstProductPrice, comparefirstProductPrice, "Text is not the same. Check screenshot!");
            return this;
        }

        public A2RimiBestSellingProductsPage DeleteAllProductsFromCart()
        {
            _deleteAllProductsFromCart.Click();
            return this;
        }
        public A2RimiBestSellingProductsPage ConfirmToDeleteAllProductsFromCart()
        {
            _confirmToDeleteAllProductsFromCart.Click();
            return this;
        }
        public A2RimiBestSellingProductsPage CheckIsCartEmty()
        {
            _checkIsCartEmty.Click();
            return this;
        }

        public A2RimiBestSellingProductsPage CheckIsCartShowsZero()
        {
            Assert.AreEqual("0", _checkIsCartShowaZero.Text, "Text is not the same. Check screenshot!");
            return this;
        }

    }
}
