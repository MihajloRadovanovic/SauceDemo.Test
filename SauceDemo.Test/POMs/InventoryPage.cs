using OpenQA.Selenium;

namespace SauceDemo.Test.POMs
{
    public class InventoryPage
    {
        private IWebDriver driver { get; }
        public IWebElement BackPack => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement BikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement Tshirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement ShoppingCart => driver.FindElement(By.ClassName("shopping_cart_badge"));

        public InventoryPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public bool BackPackDisplayed() => BackPack.Displayed;
        public bool BikeLightDisplayed() => BikeLight.Displayed;
        public bool TshirtDisplayed() => Tshirt.Displayed;
        public bool ShoppingCartDisplayed => ShoppingCart.Displayed;

       public void AddProducts()
        {
            BackPack.Click();
            BikeLight.Click();
            Tshirt.Click();
        }

    }
}
