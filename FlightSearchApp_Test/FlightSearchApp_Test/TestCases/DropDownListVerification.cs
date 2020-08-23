using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FlightSearchApp_Test.TestCases
{
    public class DropDownListVerification
    {
        [OneTimeSetUp]
        public void Test_Setup()
        {
            DriverClass.driver = new ChromeDriver();
            DriverClass.driver.Navigate().GoToUrl("http://jt-dev.azurewebsites.net/#/SignUp");
            DriverClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);  //Waiting for 1 min to load the site
        }

        [Test]
        public void Verify_DropDownList()
        {
            List<string> Actual_DDL = Action.GetDDList();
            //Assert.Multiple is used as there are multiple verification in dropdown list
            Assert.Multiple(() =>
            {
                foreach (var item in Actual_DDL)
                {
                    Assert.That(Data.DropDownList_Data.DDL_ExpectedValues.Contains(item));
                }
            });

        }
        [OneTimeTearDown]
        public void Test_Cleanup()
        {
            DriverClass.driver.Quit();
        }
    }
}
