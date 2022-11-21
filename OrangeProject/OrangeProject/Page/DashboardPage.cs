using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Page
{
    public class DashboardPage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebDriver UserMenu = driver FindElement(By.Class);

        public void SelectOption()
        { 
            SelectElement element => new SelectElement(driver.FindElement())



    }
}
