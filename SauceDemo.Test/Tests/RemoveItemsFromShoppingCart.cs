using OpenQA.Selenium;
using SauceDemo.Test.POMs;
using System.Threading;
using Xunit;

namespace SauceDemo.Test.Tests
{
    public class RemoveItemsFromShoppingCart : BaseTest
    {
        private readonly HomePage homePage;
        private readonly InventoryPage inventoryPage;
        private readonly ShoppingCartPage shoppingCartPage;

        public RemoveItemsFromShoppingCart()
        {
            homePage = new HomePage(driver);
            inventoryPage = new InventoryPage(driver);
            shoppingCartPage = new ShoppingCartPage(driver);
        }

        [Fact(DisplayName ="Remoing items from shopping cart")]
        public void RemoveItemsFromCart()
        {
            Navigate("https://www.saucedemo.com/");
            homePage.Login("standard_user", "secret_sauce");

            inventoryPage.AddProducts();

            Navigate("https://www.saucedemo.com/cart.html");

            shoppingCartPage.RemovingItemsFromCart();

            Assert.Equal("", homePage.ShoppingCart.Text);
        }

        [Fact(DisplayName = "Return to shopping")]
        public void ShouldReturnToShopping()
        {
            RemoveItemsFromCart();
                   
            element =  driver.FindElement(By.Id("react-burger-menu-btn"));
            element.Click();

            //Thread.Sleep(2000);
           
            element = driver.FindElement(By.Id("inventory_sidebar_link"));

           Thread.Sleep(2000);

            element.Click();

            //Thread.Sleep(2000);

            Assert.True(homePage.SauceDemo.Displayed);

    }
}
}
