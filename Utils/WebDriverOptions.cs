// <copyright file="WebDriverOptions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Final_Task.Utils
{
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Edge;

    /// <summary>
    /// Class with methods to set options for the specified browser.
    /// </summary>
    public static class WebDriverOptions
    {
        /// <summary>
        /// Set options for Chrome driver.
        /// </summary>
        /// <returns>ChromeOptions.</returns>
        public static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-save-password-bubble");
            options.AddArgument("ignore-certificate-errors");
            options.AddArgument("--start-maximized");
            options.AddArguments("--no-sandbox");

            return options;
        }

        /// <summary>
        /// Set options for Edge driver.
        /// </summary>
        /// <returns>EdgeOptions.</returns>
        public static EdgeOptions GetEdgeOptions()
        {
            EdgeOptions options = new EdgeOptions();
            options.AddArgument("--disable-save-password-bubble");
            options.AddArgument("ignore-certificate-errors");
            options.AddArgument("--start-maximized");

            return options;
        }
    }
}
