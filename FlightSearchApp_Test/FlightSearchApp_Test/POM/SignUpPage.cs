using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FlightSearchApp_Test.POM
{
    public class SignUpPage
    {
        public SignUpPage()
        {
            PageFactory.InitElements(DriverClass.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#language > div.ui-select-match.ng-scope > span > span.ui-select-match-text.pull-left")]
        public IWebElement DDLlang { get; set; }
        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement txt_Name { get; set; }
        [FindsBy(How = How.Id, Using = "orgName")]
        public IWebElement txt_Org_name { get; set; }
        [FindsBy(How = How.Id, Using = "singUpEmail")]
        public IWebElement txt_Email { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/section/div/div[3]/div/section/div[1]/form/fieldset/div[4]/label/span")]
        public IWebElement chk_IAgree { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#content > div > div.main-body > div > section > div.form-container > form > fieldset > div:nth-child(5) > button")]
        public IWebElement btn_GetStarted { get; set; }
    }
}
