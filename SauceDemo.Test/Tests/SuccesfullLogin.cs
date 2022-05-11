using SauceDemo.Test.POMs;
using System.Threading;
using Xunit;

namespace SauceDemo.Test.Tests
{
    public class SuccesfullLogin : BaseTest
    {
        private readonly HomePage homePage;

        public SuccesfullLogin()
        {
            homePage = new HomePage(driver);
        }
        [Fact(DisplayName = "Login user succesfully")]
        public void WhenCorrectDataIsEnteredUserIsSuccessfullyLogedIn()
        {
            Navigate("https://www.saucedemo.com/");

            homePage.Login("standard_user", "secret_sauce");

            Assert.True(homePage.SauceDemoLogoDisplayed());

        }

    }
}
