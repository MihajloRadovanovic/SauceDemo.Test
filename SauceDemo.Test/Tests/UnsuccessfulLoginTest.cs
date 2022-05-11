﻿using SauceDemo.Test.POMs;
using Xunit;

namespace SauceDemo.Test.Tests
{
    public class UnsuccessfulLoginTest : BaseTest
    {
        private readonly HomePage homePage;

        public UnsuccessfulLoginTest()
        {
            homePage = new HomePage(driver);
        }

        [Theory(DisplayName = "Log in with wrong inputs")]
        [InlineData("saucedemo", "1234", "https://www.saucedemo.com/")]
        [InlineData("mihajlo1!", "sifra", "https://www.saucedemo.com/")]
        [InlineData("!@#$%^", "secret_sauce", "https://www.saucedemo.com/")]
        [InlineData("", "", "https://www.saucedemo.com/")]

        public void ShouldUnsucessfullLoginWhenWrongUsernameAndPasswordAreEntered(string username, string password, string url)
        {
            Navigate(url);

            homePage.Login(username, password);

            Assert.True(homePage.SauceDemoLogoDisplayed());
        }
    }
}


