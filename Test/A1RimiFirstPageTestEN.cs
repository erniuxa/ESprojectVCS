using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESprojectVCS.Test
{
    public class A1RimiFirstPageTestEN : BaseTest
    {
        [Order(1)]
        [TestCase(TestName = "Coockies acceptance [EN menu]")]
        public static void TestAcceptAllCoockies()
        {
            _rimiFirstPageEN.NavigateToPage().AcceptAllConsents();
        }

        [Order(2)]
        [TestCase("All categories", "Usually bought", "🛒 Offers", "Choose healthier",
            "Coffee days", "For own bar", "Delivery methods", "Select time", TestName = "Check first page menu tabs [EN menu]")]

        public static void TestCheckProductsMenuTitle(string productsMenuTitle, string bestSellingMenuTitle, string salesMenuTitle,
            string coffeRitualsTitle, string chooseHealthier, string forOwnBarMenuTitle, string deliveryMethodsMenuTitle, string chooseDeliveryMenuTitle)
        {
            _rimiFirstPageEN.CheckMenuList(productsMenuTitle, bestSellingMenuTitle, salesMenuTitle,
            coffeRitualsTitle, chooseHealthier, forOwnBarMenuTitle, deliveryMethodsMenuTitle, chooseDeliveryMenuTitle);
        }
    }
}
