using MedicalRecordAutomation.Base;
using OpenQA.Selenium;
using source.MedicalRecordAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace source.MedicalRecordAutomation
{
    
    public class LoginTest : AutomationWrapper
    {
       

        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginData))]
        //[TestCase("admin","pass", "OpenEMR")]
        //[TestCase("accountant","accountant", "OpenEMR")]
        public void ValidLoginTest(string username, string password, string expectedValue)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            //assert the title- OpenEMR
            Assert.That(driver.Title, Is.EqualTo(expectedValue));

        }

        [Test]
        //[TestCaseSource(nameof(ValidLoginData))]

        [TestCase("saul", "saul234", "Invalid username or password")]

        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(username);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            //assert the error - Invalid username or password
            string error = driver.FindElement(By.XPath("//p[contains(text(),'Invalid')]")).Text;
            //Validate Error message
            //Assert.That(error, Is.EqualTo(expectedError));
            Assert.That(error.Contains(expectedError)); //expect true
           // Assert.That(driver.Equals(expectedError), Is.False);

        }


        }
}
