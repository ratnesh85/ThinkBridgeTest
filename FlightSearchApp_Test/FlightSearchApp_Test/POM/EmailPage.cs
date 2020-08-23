using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FlightSearchApp_Test.POM
{
   public class EmailPage
    {
        public EmailPage()
        {
            PageFactory.InitElements(DriverClass.driver, this);
        }

        [FindsBy(How=How.Id, Using = "inbox-id")]
        public IWebElement uname { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/div/span[1]/span/input")]
        public IWebElement setmailtxtbox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/div/span[1]/span/button[1]")]
        public IWebElement setemailbtn { get; set; }
    }
}
