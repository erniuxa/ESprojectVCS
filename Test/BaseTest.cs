using ESprojectVCS.Drivers;
using ESprojectVCS.Page;
using ESprojectVCS.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESprojectVCS.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;

        public static A1RimiFirstPage _rimiFirstPage;
        public static A2RimiBestSellingProductsPage _rimiBestSellingProductsPage;
        public static A3RimiForOwnBarPage _rimiForOwnBarPage;


        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetChromeDriver();
            _rimiFirstPage = new A1RimiFirstPage(driver);
            _rimiBestSellingProductsPage = new A2RimiBestSellingProductsPage(driver);
            _rimiForOwnBarPage = new A3RimiForOwnBarPage(driver);


        }

        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                MyScreenshot.MakeScreeshot(driver);
        }



/*        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }*/
    }
}
