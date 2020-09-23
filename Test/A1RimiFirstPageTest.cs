using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESprojectVCS.Test
{
    public class A1RimiFirstPageTest : BaseTest
    {
        [Order(1)]
        [TestCase(TestName = "Coockies acceptance")]
        public static void TestAcceptAllCoockies()
        {
            _rimiFirstPage.NavigateToPage().AcceptAllConsents();
        }

        [Order(2)]
        [TestCase("Produktai", "Perkamiausi produktai", "🛒 Akcijos", "Kavos puodelio ritualai", 
            "Rinkis sveikiau", "Savam barui", "Pristatymo būdai", "Pasirinkti pristatymą", TestName = "Check first page menu tabs [LT menu]")]

        public static void TestCheckProductsMenuTitle(string productsMenuTitle, string bestSellingMenuTitle, string salesMenuTitle,
            string coffeRitualsTitle, string chooseHealthier, string forOwnBarMenuTitle, string deliveryMethodsMenuTitle, string chooseDeliveryMenuTitle)
        {
            _rimiFirstPage.CheckMenuList(productsMenuTitle, bestSellingMenuTitle, salesMenuTitle,
            coffeRitualsTitle, chooseHealthier, forOwnBarMenuTitle, deliveryMethodsMenuTitle, chooseDeliveryMenuTitle);     
        }
    }
}
