using OpenQA.Selenium;

namespace SauceDemo.Test.POMs
{
    public class ShoppingCartPage
    {
        private IWebDriver driver { get; }
        public IWebElement RemoveBackPack => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement RemoveBikeLight => driver.FindElement(By.Id("remove-sauce-labs-bike-light"));
        public IWebElement RemoveTshirt => driver.FindElement(By.Id("remove-sauce-labs-bolt-t-shirt"));
        public IWebElement BackToShopping => driver.FindElement(By.Id("continue-shopping"));

        public ShoppingCartPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public bool IsRemoveBackPackDisplayed => RemoveBackPack.Displayed;
        public bool IsRemoveBikeLightDisplayed => RemoveBikeLight.Displayed;
        public bool IsRemoveTshirtDisplayed => RemoveTshirt.Displayed;
        public bool IsBackToShoppingDisplayed => BackToShopping.Displayed;

        
        public void ClickBackToShopping() => BackToShopping.Click();

        public void RemovingItemsFromCart()
        {
            RemoveBackPack.Click();
            RemoveBikeLight.Click();
            RemoveTshirt.Click();
        }
    }
}
