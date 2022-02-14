using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Automation_Framework.Hooks
{
    [Binding]
    public class AutomationWrapper
    {
        public static IWebDriver driver;

        [AfterScenario]
        public void EndBrowser()
        {
            AutomationWrapper.driver.Quit();
        }
    }
    
}
