using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESprojectVCS.Test
{
    public class A3RimiForOwnBarPageTest : BaseTest
    {
        [Order(1)]
        [TestCase(TestName = "Open For own bar page, accept cookies, choose and compare 1 product [LT menu]")]
        public static void ChooseFirstProduct()
        {
            _rimiForOwnBarPage
                .NavigateToPage()
                .AcceptAllConsents();

            _rimiForOwnBarPage
                .ClickFirstProduct()
                .AddToCartProduct()
                .CheckIsCompareFirstProductText();
        }

        [Order(2)]
        [TestCase(TestName = "Check 1 own bar product price, delete from cart and check [LT menu]")]
        public static void CheckFirstProductPrice()
        {
            _rimiForOwnBarPage
                .ProductPrice()
                .DeleteAllProductsFromCart()
                .ConfirmToDeleteAllProductsFromCart()
                .CheckIsCartEmty()
                .CheckIsCartShowsZero();
        }

        [Order(3)]
        [TestCase(TestName = "Open For own bar, accept cookies, choose and compare 2 product [LT menu]")]
        public static void ChooseSecondProduct()
        {
            _rimiForOwnBarPage
                .NavigateToPage()
                .AcceptAllConsents();

            _rimiForOwnBarPage
                .ClickSecondProduct()
                .AddToCartProduct()
                .CheckIsCompareSecondProductText();
        }

        [Order(4)]
        [TestCase(TestName = "Check 2 own bar product price, delete from cart and check [LT menu]")]
        public static void CheckSecondProductPrice()
        {
            _rimiForOwnBarPage
                .ProductPrice2()
                .DeleteAllProductsFromCart()
                .ConfirmToDeleteAllProductsFromCart()
                .CheckIsCartEmty()
                .CheckIsCartShowsZero();
        }
    }
}
