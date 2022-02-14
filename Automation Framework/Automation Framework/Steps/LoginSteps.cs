using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Automation_Framework.Hooks;

namespace Automation_Framework.Steps
{
    [Binding]
    public class LoginSteps
    {

        [Given(@"I have browser with orangehrm page")]
        public void GivenIHaveBrowserWithOrangehrmPage()
        {
            AutomationWrapper.driver = new ChromeDriver();
            AutomationWrapper.driver.Manage().Window.Maximize();
            AutomationWrapper.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            AutomationWrapper.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
           
        }

       
        [When(@"I enter username as '(.*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            AutomationWrapper.driver.FindElement(By.Name("txtUsername")).SendKeys(username);
        }
        
        [When(@"I enter password as '(.*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            AutomationWrapper.driver.FindElement(By.Id("txtPassword")).SendKeys(password);
            
        }
        
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            AutomationWrapper.driver.FindElement(By.Name("Submit")).Submit(); 
        }
        [Then(@"I should get access to the portal with text as '(.*)'")]
        public void ThenIShouldGetAccessToThePortalWithTextAs(string expectedOutput)
        {
            string actualOutput = AutomationWrapper.driver.FindElement(By.Id("menu__Performance")).Text;
            Assert.AreEqual(expectedOutput, actualOutput);
            AutomationWrapper.driver.Quit();
        }
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            AutomationWrapper.driver.FindElement(By.XPath("//b[normalize-space()='My Info']")).Click();
        }

    }
}
