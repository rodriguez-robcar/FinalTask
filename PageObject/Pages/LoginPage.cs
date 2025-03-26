﻿// <copyright file="LoginPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Final_Task.PageObject.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// Class that contains all elements and methods of the LoginPage.
    /// </summary>
    public class LoginPage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage"/> class.
        /// </summary>
        /// <param name="driver">Constructor receives the webdriver as parameter.</param>
        public LoginPage(IWebDriver driver) => this.driver = driver ?? throw new ArgumentException(nameof(driver));

        private static string Url { get; } = "https://www.saucedemo.com/";

        private IWebElement UsernameField => this.driver.FindElement(By.XPath("//input[@id = 'user-name']"));

        private IWebElement PasswordField => this.driver.FindElement(By.XPath("//input[@id = 'password']"));

        private IWebElement LoginButton => this.driver.FindElement(By.XPath("//input[@id = 'login-button']"));

        private IWebElement ErrorMessage => this.driver.FindElement(By.XPath("//*[@data-test = 'error']"));

        /// <summary>
        /// Opens url and returns an instance of the <see cref="LoginPage"/> class.
        /// </summary>
        /// <returns>Instance of the LoginPage class.</returns>
        public LoginPage Open()
        {
            this.driver.Navigate().GoToUrl(Url);
            return this;
        }

        /// <summary>
        /// Method to test Login form with empty credentials.
        /// </summary>
        /// <param name="username">Login username.</param>
        /// <param name="password">Login password.</param>
        public void LoginWithEmptyCredentials(string username, string password)
        {
            this.UsernameField.SendKeys(username);
            this.PasswordField.SendKeys(password);

            this.UsernameField.SendKeys(Keys.Control + "a");
            this.UsernameField.SendKeys(Keys.Delete);

            this.PasswordField.SendKeys(Keys.Control + "a");
            this.PasswordField.SendKeys(Keys.Delete);

            var clearFieldWait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            clearFieldWait.Until(driver => this.UsernameField.GetAttribute("value") == string.Empty);

            this.LoginButton.Click();
        }

        /// <summary>
        /// Method to test Login form with credentials by passing only the username.
        /// </summary>
        /// <param name="username">Login username.</param>
        /// <param name="password">Login password.</param>
        public void LoginWithEmptyPassword(string username, string password)
        {
            this.UsernameField.SendKeys(username);
            this.PasswordField.SendKeys(password);

            this.PasswordField.SendKeys(Keys.Control + "a");
            this.PasswordField.SendKeys(Keys.Delete);

            var clearFieldWait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            clearFieldWait.Until(driver => this.PasswordField.GetAttribute("value") == string.Empty);

            this.LoginButton.Click();
        }

        /// <summary>
        /// Method to test Login form with credentials by passing Username & Password.
        /// </summary>
        /// <param name="username">Login username.</param>
        /// <param name="password">Login password.</param>
        public void LoginWithUsernameAndPassword(string username, string password)
        {
            this.UsernameField.SendKeys(username);
            this.PasswordField.SendKeys(password);
            this.LoginButton.Click();
        }

        /// <summary>
        /// Returns the error message shown after a failed login.
        /// </summary>
        /// <returns>Error message element.</returns>
        public IWebElement GetErrorMessage()
        {
            return this.ErrorMessage;
        }
    }
}
