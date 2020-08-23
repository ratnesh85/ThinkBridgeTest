using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightSearchApp_Test
{
    public static class Action
    {
        public static List<string> GetDDList()
        {
            POM.SignUpPage sup = new POM.SignUpPage();
            sup.DDLlang.Click();

            List<string> ActualVal = new List<string>();
           
            IList<IWebElement> dropdown_list = DriverClass.driver.FindElements(By.XPath("//*[contains(@id,'ui-select-choices-row-1-')]//a//div"));
            foreach (IWebElement item in dropdown_list)
            {
                ActualVal.Add(item.Text);
            }
            return ActualVal;
        }
        public static void FillSignUpForm(string name, string orgName, string email)
        {
            POM.SignUpPage sup = new POM.SignUpPage();
            sup.txt_Name.Clear();
            sup.txt_Org_name.Clear();
            sup.txt_Email.Clear();
            sup.txt_Name.SendKeys(name);
            sup.txt_Org_name.SendKeys(orgName);
            sup.txt_Email.SendKeys(email);
            sup.chk_IAgree.Click();
            sup.btn_GetStarted.Click();
        }

        public static void CreateEmailAccount(string email)
        {
            POM.EmailPage emp = new POM.EmailPage();
            ((IJavaScriptExecutor)DriverClass.driver).ExecuteScript("window.open();"); //For opening new tab in browser.
            DriverClass.driver.SwitchTo().Window(DriverClass.driver.WindowHandles.Last());
            DriverClass.driver.Navigate().GoToUrl("https://www.guerrillamail.com/inbox");
            emp.uname.Click();
            emp.setmailtxtbox.Clear();
            System.Threading.Thread.Sleep(5000);
            emp.setmailtxtbox.SendKeys(email);
            emp.setemailbtn.Click();
            DriverClass.driver.SwitchTo().Window(DriverClass.driver.WindowHandles.First());
        }

        public static void EmailTab(string email)
        {
            POM.EmailPage ePage = new POM.EmailPage();
            DriverClass.driver.SwitchTo().Window(DriverClass.driver.WindowHandles.Last());
            DriverClass.driver.Navigate().Refresh();
        }

        public static IList<IWebElement> GetEmails()
        {
            IList<IWebElement> AllEmails = DriverClass.driver.FindElements(By.Id("email_list"));
            return AllEmails;
        }
    }
}
