using SauceDemo.Test.POMs;
using System.Threading;
using Xunit;

namespace SauceDemo.Test.Tests
{
    public class AddingItemsToShoppingBasket : BaseTest
    {
        private readonly HomePage homePage;
        private readonly InventoryPage inventoryPage;

        public AddingItemsToShoppingBasket()
        {
            inventoryPage = new InventoryPage(driver);
            homePage = new HomePage(driver);
        }
        
        [Fact(DisplayName ="Adding and checking number of items in shopping cart")]
        public void ShouldBeThreeItemsInCart()
        {
            Navigate("https://www.saucedemo.com/");

            homePage.Login("standard_user", "secret_sauce");

            inventoryPage.AddProducts();

            Assert.Equal("3", homePage.ShoppingCart.Text);
        }
    }
}
