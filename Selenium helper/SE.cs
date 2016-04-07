using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_helper
{
    partial class SE
    {
        public IWebDriver Driver { get; set; }
        // needs Selenium support classes
        public WebDriverWait wait { get; set; }
        // when Selenium is too weak to do the job, JavaScript comes to save the day
        public IJavaScriptExecutor JS { get; set; }

        // Chrome gives more freedom and ease of configuration, because of the hundreds of starting flags it has.
        public IWebDriver EnterWithChrome()
        {
            Driver = new ChromeDriver();
            // You can define as many wait times as you need.
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            JS = Driver as IJavaScriptExecutor;
            // I return driver so I can chain many events together, ex: EnterWithChrome().GoTo("https://www.gmail.com").
            return Driver;
        }

        // For advanced configuration Firefox uses profiles instead of starting flags.
        public IWebDriver EnterWithFirefox()
        {
            Driver = new FirefoxDriver();
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            JS = Driver as IJavaScriptExecutor;
            return Driver;
        }

        /**
         * public IWebDriver EnterWithPhantomJS()
         * If you need to be extra fast and stealthy or run from a server, there is a driver for the headless browser PhantomJS :)
         * Careful tho, working Chromedriver or Firefoxdriver code will not always work on PhantomJS, test it after switching!
        **/

        /* The fluid code with my wrapper functions looks like this
         * WaitId("MyButton").Click();
         * You will not worry about slow loading time or events breaking your tests 
        **/
    }
}
