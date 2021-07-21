using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings: GlobalDefinitions
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        // Click on Manage Listings
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Manage Listings']")]
        private IWebElement ManageListingBtn { get; set; }

        // Click on ServiceListing 'isActive' checkbox for activate or deactive the service
        [FindsBy(How = How.XPath, Using = "//tbody//tr[1]/td[7]//input[@name='isActive']")]
        private IWebElement ActiveService { get; set; }

        // View listing

        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        // Edit Service list
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement Edit { get; set; }

        // Delete Service list
        [FindsBy(How = How.XPath, Using = "(//i[@class='remove icon'])[1]")]
        private IWebElement Delete { get; set; }
        // Click on Popup Yes button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement ClickOnYes { get; set; }

        #endregion
        ////Click on Yes or No
        //[FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        //private IWebElement clickActionsButton { get; set; }

        internal void ManageListing()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListing");
            // Navigate to page Manage Listing
            Wait.WaitForElementToBePresent(driver, "XPath", "//a[normalize-space()='Manage Listings']", 3);
            ManageListingBtn.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//tbody//tr[1]/td[7]//input[@name='isActive']", 3);
            ActiveService.Click();
            Thread.Sleep(3000);
            // Update existing data       
            ShareSkill edit = new ShareSkill();
            edit.EditManageLisiting();
            Thread.Sleep(3000);

            Wait.WaitForElementToBePresent(driver, "XPath", "(//i[@class='eye icon'])[1]", 3);
            // View Service Listing
            view.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//a[normalize-space()='Manage Listings']", 3);
            ManageListingBtn.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "(//i[@class='remove icon'])[1]", 2);
            // click on delete button
            Delete.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "/html/body/div[2]/div/div[3]/button[2]", 2);
            // Switch to Popup button
            ClickOnYes.Click();
            Thread.Sleep(1000);
            


        }

        


    }
}
