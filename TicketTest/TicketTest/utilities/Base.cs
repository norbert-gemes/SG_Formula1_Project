using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTest.utilities
{
    public class Base
    {
        public static jsonReader reader { get; set; }  = new jsonReader();
        public IWebDriver driver;
        [SetUp]
        public void Init()
        {
            driver = new ChromeDriver("chromedriver.exe");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            string? actUrl = ConfigurationManager.AppSettings["Url"];
            driver.Url = actUrl;
        }
        [TearDown]
        public void Cleanup() 
        { 
            driver.Dispose();
        }
    }
}
