using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FlightSearchApp_Test.TestCases
{
    public class EmailVerification
    {
        [OneTimeSetUp]
        public void Test_Setup()
        {
            DriverClass.driver = new ChromeDriver();
            DriverClass.driver.Navigate().GoToUrl("http://jt-dev.azurewebsites.net/#/SignUp");
            DriverClass.driver.Manage().Window.Maximize();
            DriverClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);  //Change
        }

        [Test]
        public void Verify_Email()
        {
            Action.CreateEmailAccount(Data.Email_Data.temp_email);
            Action.FillSignUpForm(Data.SignUp_Data.Name, Data.SignUp_Data.OrganizationName, Data.SignUp_Data.Email);
            POM.SignUpPage sup = new POM.SignUpPage();

            Action.EmailTab(Data.Email_Data.temp_email);
            IList<IWebElement> allEmails = Action.GetEmails();
            if (allEmails.Count != 0)
            {
                Assert.Pass("Your email has been received");
            }
            else
            {
                Assert.Fail("Your email hasn't been received");
            }
        }
        [OneTimeTearDown]
        public void Test_Cleanup()
        {
            DriverClass.driver.Quit();
        }
    }
}
