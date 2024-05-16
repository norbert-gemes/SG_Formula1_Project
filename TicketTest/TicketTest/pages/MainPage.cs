using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTest.pages
{
    public class MainPage
    {
        IWebDriver driver;
        public MainPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"onetrust-accept-btn-handler\"]")]
        public IWebElement popup { get; set; }

    }
}
