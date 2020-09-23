using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESprojectVCS.Page
{
    public class A1RimiFirstPage : BasePage
    {
        private const string PageAddress = "https://www.rimi.lt/e-parduotuve";

        private IWebElement _actualProductsMenuTitle => Driver.FindElement(By.XPath("/html/body/div[1]/div/ul/li[1]/a"));
        private IWebElement _actualBestSellingProductsMenuTitle => Driver.FindElement(By.XPath("/html/body/div[1]/div/ul/li[2]/a"));
        private IWebElement _actualSalesMenuTitle => Driver.FindElement(By.XPath("/html/body/div[1]/div/ul/li[3]/a"));
        private IWebElement _actualCoffeRitualsTitle => Driver.FindElement(By.XPath("/html/body/div[1]/div/ul/li[4]/a"));
        private IWebElement _actualChooseHealthier => Driver.FindElement(By.XPath("/html/body/div[1]/div/ul/li[5]/a"));
        private IWebElement _actualForOwnBarMenuTitle => Driver.FindElement(By.XPath("/html/body/div[1]/div/ul/li[6]/a"));
        private IWebElement _actualDeliveryMethodsMenuTitle => Driver.FindElement(By.XPath("/html/body/div[1]/div/ul/li[7]/a"));
        private IWebElement _actualChooseDeliveryMenuTitle => Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/a/span"));

        public A1RimiFirstPage(IWebDriver webdriver) : base(webdriver)
        { }
        public A1RimiFirstPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public A1RimiFirstPage AcceptAllConsents()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%27NDQkerFt+RZxk4VoklqoLhWxNQ7zeq/ljnHOfE08GdswowadlGIqHA==%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:true%2Cmarketing:true%2Cver:2%2Cutc:1600839127738%2Cregion:%27lt%27}",
                "www.rimi.lt", "/", DateTime.Now.AddDays(2));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
            return this;
        }

        public void CheckMenuList(string productsMenuTitle, string bestSellingMenuTitle, string salesMenuTitle, 
            string coffeRitualsTitle, string chooseHealthier, string forOwnBarMenuTitle, string deliveryMethodsMenuTitle, string chooseDeliveryMenuTitle)
        {
            Assert.AreEqual(productsMenuTitle, _actualProductsMenuTitle.Text, "Text is not the same. Check screenshot!");
            Assert.AreEqual(bestSellingMenuTitle, _actualBestSellingProductsMenuTitle.Text, "Text is not the same. Check screenshot!");
            Assert.AreEqual(salesMenuTitle, _actualSalesMenuTitle.Text, "Text is not the same. Check screenshot!");
            Assert.AreEqual(coffeRitualsTitle, _actualCoffeRitualsTitle.Text, "Text is not the same. Check screenshot!");
            Assert.AreEqual(chooseHealthier, _actualChooseHealthier.Text, "Text is not the same. Check screenshot!");
            Assert.AreEqual(forOwnBarMenuTitle, _actualForOwnBarMenuTitle.Text, "Text is not the same. Check screenshot!");
            Assert.AreEqual(deliveryMethodsMenuTitle, _actualDeliveryMethodsMenuTitle.Text, "Text is not the same. Check screenshot!");
            Assert.AreEqual(chooseDeliveryMenuTitle, _actualChooseDeliveryMenuTitle.Text, "Text is not the same. Check screenshot!");
        }
    }
}
