using Automation_Framework.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Automation_Framework.Steps
{
    [Binding]
    public class PersonalDetailsSteps
    {
        [When(@"I click on personal details")]
        public void WhenIClickOnPersonalDetails()
        {
            AutomationWrapper.driver.FindElement(By.LinkText("Personal Details")).Click();
        }
        
        [When(@"I click on edit")]
        public void WhenIClickOnEdit()
        {
            AutomationWrapper.driver.FindElement(By.Id("btnSave")).Click();
        }
        
        [When(@"I fill personal details")]
        public void WhenIFillPersonalDetails(Table table)
        {
            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmpFirstName")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmpFirstName")).SendKeys(table.Rows[0]["firstname"]);

            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmpMiddleName")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmpMiddleName")).SendKeys(table.Rows[0]["middlename"]);

            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmpLastName")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmpLastName")).SendKeys(table.Rows[0]["lastname"]);

            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmployeeId")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmployeeId")).SendKeys(table.Rows[0]["employeeid"]);

            AutomationWrapper.driver.FindElement(By.Id("personal_txtOtherID")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtOtherID")).SendKeys(table.Rows[0]["otherid"]);

            AutomationWrapper.driver.FindElement(By.Id("personal_txtLicenNo")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtLicenNo")).SendKeys(table.Rows[0]["licensenumber"]);
           
            IWebElement licenseExpiry = AutomationWrapper.driver.FindElement(By.Name("personal[txtLicExpDate]"));
            licenseExpiry.Clear();
            licenseExpiry.SendKeys(table.Rows[0]["licenseexpirydate"]);
            
            var dobEle1 = AutomationWrapper.driver.FindElement(By.Id("personal_txtLicExpDate"));
            dobEle1.Clear();
            dobEle1.SendKeys(table.Rows[0]["licenseexpirydate"]);
            AutomationWrapper.driver.FindElement(By.XPath("//input[@id='personal_txtLicExpDate']/following::img")).Click();

            AutomationWrapper.driver.FindElement(By.Id("personal_txtNICNo")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtNICNo")).SendKeys(table.Rows[0]["ssnnumber"]);

            AutomationWrapper.driver.FindElement(By.Id("personal_txtSINNo")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtSINNo")).SendKeys(table.Rows[0]["sinnumber"]);

            string gender = table.Rows[0]["gender"];
            if (gender.ToLower().Equals("male"))
            {
                AutomationWrapper.driver.FindElement(By.Id("personal_optGender_1")).Click();

            }
            else
            {
                AutomationWrapper.driver.FindElement(By.Id("personal_optGender_2")).Click();
            }
            SelectElement select = new SelectElement(AutomationWrapper.driver.FindElement(By.Id("personal_cmbMarital")));
            select.SelectByText(table.Rows[0]["martialstatus"]);

            select = new SelectElement(AutomationWrapper.driver.FindElement(By.Id("personal_cmbNation")));
            select.SelectByText(table.Rows[0]["nationality"]);

            var dobEle = AutomationWrapper.driver.FindElement(By.Id("personal_DOB"));
            dobEle.Clear();
            dobEle.SendKeys(table.Rows[0]["dob"]);
            AutomationWrapper.driver.FindElement(By.XPath("//input[@id='personal_DOB']/following::img")).Click();


            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmpNickName")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtEmpNickName")).SendKeys(table.Rows[0]["nickname"]);

            var smokerEle = AutomationWrapper.driver.FindElement(By.Id("personal_chkSmokeFlag"));
            string smoker = table.Rows[0]["smoker"];
            if(smoker.ToLower().Equals("yes") && !smokerEle.Selected)
            {
                smokerEle.Click();
            }
            if (smoker.ToLower().Equals("no") && smokerEle.Selected)
            {
                smokerEle.Click();
            }

            AutomationWrapper.driver.FindElement(By.Id("personal_txtMilitarySer")).Clear();
            AutomationWrapper.driver.FindElement(By.Id("personal_txtMilitarySer")).SendKeys(table.Rows[0]["militaryservice"]);




        }

        [When(@"I click on save Personal Details")]
        public void WhenIClickOnSavePersonalDetails()
        {
            AutomationWrapper.driver.FindElement(By.Id("btnSave")).Click();
        }
        
        [Then(@"I should get fistname as '(.*)' and lastname as '(.*)'")]
        public void ThenIShouldGetFistnameAsAndLastnameAs(string p0, string p1)
        {
            
        }
    }
}
