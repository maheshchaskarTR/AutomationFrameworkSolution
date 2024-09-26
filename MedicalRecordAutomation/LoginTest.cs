﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using source.MedicalRecordAutomation.Base;
using source.MedicalRecordAutomation.Utilities;

namespace source.MedicalRecordAutomation
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.ValidLoginDataExcel))]
        public void ValidLoginTest(string username, string password, string expectedValue)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            //Assert the title  - OpenEMR
            Assert.That(driver.Title, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.InValidLoginDataExcel))]

        //[TestCase("saul", "saul234", "Invalid username or password")]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            //Assert the error - Invalid username or password
            string actualError = driver.FindElement(By.XPath("//p[contains(text(),'Invalid')]")).Text;
            Assert.That(actualError.Contains(expectedError)); //expect true
        }
    }
}
