using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;


namespace MarsFramework.Pages
{
    class SignIn
    {
        [System.Obsolete]
        public SignIn()
        {
            
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Sign In']")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Login']")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.NavigateUrl();
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            try
            {


                //Click on Signin
                SignIntab.Click();

                //Enter Email
                Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

                //Enter Password
                Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

                //Click on Login button
                LoginBtn.Click();
            }
          catch(Exception ex)
            {

                Assert.Fail("Test Failed at login Page");
            }
            
            
        }
    }
}