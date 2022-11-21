using NUnit.Framework;
using OpenQA.Selenium;
using OrangeProject.Driver;
using OrangeProject.Page;

namespace OrangeProject
{
    public class Tests
    {
        Login login
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            login = new Login();
        }

        [Test]
        public void Test1()
        {
            login LoginUser("Admin", "Admin123");
        }
    }

    internal class Login
    {
        public Login()
        {
        }
    }
}