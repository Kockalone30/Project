using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Driver
{
    public class WebDrivers
    {
        public static IWebDriver Instance { get; set; }
        public static void initialisation()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Instance.Navigate().GoToUrl("https://opensource.orange.com/en/open-source-orange/");
        }

        public static void CleanUp()
        {
            Instance.Quit();
        }
    }
}
