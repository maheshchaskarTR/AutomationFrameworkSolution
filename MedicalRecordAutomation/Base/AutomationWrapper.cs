using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalRecordAutomation.Base
{
    public class AutomationWrapper
    {

        protected IWebDriver driver;

        [SetUp]
        public void BeforeTestMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");
        }

        [TearDown]

        public void AfterTestMethod()
        {
            driver.Dispose();
        }

        //[Test]
        //public void ValidLoginTest()
        //{
        //    driver.FindElement(By.Id("authUser")).SendKeys("admin");

        //}


       

    }
}
