using OpenQA.Selenium;
using OrangeProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Page
{
    public class Login
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.Name("username"));
        public IWebElement password => driver.FindElement(By.Name("password"));

        public IWebElement LogInButton => driver.FindElement(By.CssSelector(".orangehrm-login-button"));

        internal static void LoginUser(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public void LogInUser(string name, string pass)
        {
            UserName.SendKeys(name);
            password.SendKeys(pass);
            LogInButton.Submit();
        }
    }

   
}
