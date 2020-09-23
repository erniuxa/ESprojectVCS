using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESprojectVCS.Test
{
    public class A2RimiBestSellingProductsPageTest : BaseTest
    {
        [Order(1)]
        [TestCase(TestName = "Open Best selling page, accept cookies, choose and compare 1 product [LT menu]")]
        public static void ChooseFirstProduct()
        {
            _rimiBestSellingProductsPage
                .NavigateToPage()
                .AcceptAllConsents();

            _rimiBestSellingProductsPage
                .ClickFirstProduct()
                .AddToCartProduct()
                .CheckIsCompareFirstProductText();
        }

        [Order(2)]
        [TestCase(TestName = "Check 1 product price, delete from cart and check [LT menu]")]
        public static void CheckFirstProductPrice()
        {
            _rimiBestSellingProductsPage
                .ProductPrice()
                .DeleteAllProductsFromCart()
                .ConfirmToDeleteAllProductsFromCart()
                .CheckIsCartEmty()
                .CheckIsCartShowsZero();
        }

        [Order(3)]
        [TestCase(TestName = "Open Best selling page, accept cookies, choose and compare 2 product [LT menu]")]
        public static void ChooseSecondProduct()
        {
            _rimiBestSellingProductsPage
                .NavigateToPage()
                .AcceptAllConsents();

            _rimiBestSellingProductsPage
                .ClickSecondProduct()
                .AddToCartProduct()
                .CheckIsCompareSecondProductText();
        }

        [Order(4)]
        [TestCase(TestName = "Check 2 product price, delete from cart and check [LT menu]")]
        public static void CheckSecondProductPrice()
        {
            _rimiBestSellingProductsPage
                .ProductPrice()
                .DeleteAllProductsFromCart()
                .ConfirmToDeleteAllProductsFromCart()
                .CheckIsCartEmty()
                .CheckIsCartShowsZero();
        }
    }
}
