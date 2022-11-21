using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Page
{
    internal class DashboardPage
    {
        public class DashboardPAge
        {
            private IWebDriver driver = WebDriver.Instance;

            public IWebElement UserMenu => driver.FindElements(By.ClassName("oxd-userdropdown-name"));

            public void SelectOptions(string text)
            {
                SelectElement element = new SelectElement(driver.FindElement(By.ClassName("oxd-dropdown-menu")));
                element.SelectByText(text);
            }
        }
    }
}
