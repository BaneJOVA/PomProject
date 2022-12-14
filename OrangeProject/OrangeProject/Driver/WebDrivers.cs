using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Driver
{
    public static class WebDrivers
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialization()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            Instance.Navigate().GoToUrl("https://oprnsource-demo.orangehrmlive.com");
        }
        public static void Cleanup()
        {
            Instance.Quit();
        }

        internal static void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}