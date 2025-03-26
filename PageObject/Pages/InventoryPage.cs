// <copyright file="InventoryPage.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Final_Task.PageObject.Pages
{
    using OpenQA.Selenium;

    /// <summary>
    /// Class that contains all elements and methods of the InventoryPage.
    /// </summary>
    public class InventoryPage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryPage"/> class.
        /// </summary>
        /// <param name="driver">WebDriver.</param>
        public InventoryPage(IWebDriver driver) => this.driver = driver ?? throw new ArgumentException(nameof(driver));

        private IWebElement Title => this.driver.FindElement(By.XPath("//*[@class = 'app_logo']"));

        /// <summary>
        /// Method that returns the header element.
        /// </summary>
        /// <returns>Header web element.</returns>
        public IWebElement GetTitle()
        {
            return this.Title;
        }
    }
}
