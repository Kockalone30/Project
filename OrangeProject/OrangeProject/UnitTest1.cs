using NUnit.Framework;
using OpenQA.Selenium;
using OrangeProject.Driver;
using OrangeProject.Page;

namespace OrangeProject
{
    public class Tests
    {
        Login login;
        [SetUp]
        public void Setup()
        {
            WebDrivers.initialisation();
            login = new Login();
        }

        [Test]
        public void Test1()
        {
            Login.LoginUser("Admin","admin123");
        }
    }
}