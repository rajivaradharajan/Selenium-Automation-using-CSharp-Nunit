using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using static MarsFramework.Global.GlobalDefinitions;
using static NUnit.Core.NUnitFramework;
using System;
using AutoItX3Lib;


namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #region  Initialize Web Elements 
        //Click on ShareSkill Button
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Share Skill']")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown //select[@name='subcategoryId']
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[@class='tooltip-target ui grid']/div[@class='twelve wide column']/div[1]/div[1]/div[1]/div[1]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type// //div[5]//div[2]//div[1]//div[1]//div[1]//input[1]
        [FindsBy(How = How.XPath, Using = "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type //form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']
        [FindsBy(How = How.XPath, Using = "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Start date']")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='End date']")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        //[FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        //private IWebElement Days { get; set; }

        //Click on Available date
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]")]
        private IWebElement Row1 { get; set; }

        //Click on available days 
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='0']")]
        private IWebElement Sun { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='1']")]
        private IWebElement Mon { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='2']")]
        private IWebElement Tue { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='3']")]
        private IWebElement Wed { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='4']")]
        private IWebElement Thr { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='5']")]
        private IWebElement Fri { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @index='6']")]
        private IWebElement Sat { get; set; }

        //Click on Start time
        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='0']")]
        private IWebElement SunStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='1']")]
        private IWebElement MonStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='2']")]
        private IWebElement TueStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='3']")]
        private IWebElement WedStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='4']")]
        private IWebElement ThrStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='5']")]
        private IWebElement FriStartTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='StartTime' and @index='6']")]
        private IWebElement SatStartTime { get; set; }

        // Fill the value in End Time
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='0']")]
        private IWebElement SunEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='1']")]
        private IWebElement MonEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='2']")]
        private IWebElement TueEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='3']")]
        private IWebElement WedEndTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='4']")]
        private IWebElement ThrEndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='5']")]
        private IWebElement FriEndTime { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='EndTime' and @index='6']")]
        private IWebElement SatEndTime { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Upload worksamples
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement Worksamples { get; set; }

        //Click on Active option1 -active
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption1 { get; set; }
        //Click on Active option2 - hidden
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='false']")]
        private IWebElement ActiveOption2 { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
       
        // Click on Cancel
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel' and @type='button']")]
        private IWebElement Cancel { get; set; }
       
        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[8]/div/button[2]")]
        private IWebElement Edit { get; set; }

        // Click on Delete button
        [FindsBy(How = How.XPath, Using = "//table/tbody/tr[1]/td[8]/div/button[3]")]
        private IWebElement Delete { get; set; }
        // Click on Popup Yes button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement ClickOnYes { get; set; }
        // Click on Manage Listings
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Manage Listings']")]
        private IWebElement ManageListingBtn { get; set; }
        // Verify Added Share Skills
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[3]")]
        private IWebElement VerifyShareSkill { get; set; }

        #endregion

        //Fill the details in shareskill form
        internal void EnterShareSkill()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");


            Wait.WaitForElementToBePresent(driver, "XPath", "//a[normalize-space()='Share Skill']",5);
            //Click on Shareskillbutton
            ShareSkillButton.Click();

            //Click on Title
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='Write a title to describe the service you provide.']",3);
            Title.Click();

            //Enter Title details
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Title"));

            //Click Description
            Wait.WaitForElementToBePresent(driver, "XPath", "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']",3);
           Description.Click();

            //Enter Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Description"));

            //Click on category dropdown
            Wait.WaitForElementToBePresent(driver, "XPath", "//select[@name='categoryId']",3);
            CategoryDropDown.Click();

            Wait.WaitForElementToBePresent(driver, "XPath", "//select[@name='categoryId']",3);
            //Read data from excel
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Category"));
            CategoryDropDown.Click();

            Wait.WaitForElementToBePresent(driver, "XPath", "//select[@name='subcategoryId']",3);
            //Click on subcategory
            SubCategoryDropDown.Click();

            Wait.WaitForElementToBePresent(driver, "XPath", "//select[@name='subcategoryId']",3);
            //Read data from excel (option1)
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "SubCategory"));
            SubCategoryDropDown.Click();
            //option 2 to select from dropdown
            //SelectElement select2 = new SelectElement(SubCategoryDropDown);
            //select2.SelectByIndex(3);
            //or
            //SubCategory.SendKeys("Select Subcategory" + Keys.Down + Keys.Enter);

            Wait.WaitForElementToBePresent(driver, "XPath", "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[@class='tooltip-target ui grid']/div[@class='twelve wide column']/div[1]/div[1]/div[1]/div[1]/input[1]",3);
            //Click on tag
            Tags.Click();

            Wait.WaitForElementToBePresent(driver, "XPath", "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[@class='tooltip-target ui grid']/div[@class='twelve wide column']/div[1]/div[1]/div[1]/div[1]/input[1]",3);
            //Enter data from excel
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Tags"));
            Tags.SendKeys(Keys.Enter);

            Wait.WaitForElementToBePresent(driver, "XPath", "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]", 3);
            //Select servicetype options
            ServiceTypeOptions.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]",3);
            ServiceTypeOptions.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "ServiceType"));

            Wait.WaitForElementToBePresent(driver, "XPath", "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]",3);
            //select locationtype
            LocationTypeOption.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]",3);
            LocationTypeOption.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "LocationType"));

            //On available days option click on startdate dropdown
            StartDateDropDown.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='Start date']", 3);
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Startdate"));

            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='End date']", 3);
            //On available days option click on enddate dropdown
            EndDateDropDown.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='End date']", 3);
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Enddate"));

            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@type='checkbox' and @index='1']", 3);
            // Click on available days

            //Sun.Click();
            //SunStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //SunEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            Mon.Click();
            MonStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Starttime"));
            MonEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Endtime"));

            Tue.Click();
            TueStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Starttime"));
            TueEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Endtime"));

            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@type='checkbox' and @index='3']", 3);
            Wed.Click();
            WedStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Starttime"));
            WedEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(4, "Endtime"));

            //Thr.Click();
            //ThrStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //ThrEndTime.SendKeys("0422");

            //Fri.Click();
            //FriStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //FriEndTime.SendKeys("0522");

            //Sat.Click();
            //SatStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //SatEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));


            Wait.WaitForElementToBePresent(driver, "XPath", "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']", 3);
            //select skilltrade option
            SkillTradeOption.Click();



            Wait.WaitForElementToBePresent(driver, "XPath", "//div[@class='form-wrapper']//input[@placeholder='Add new tag']", 3);
            //Select SkillExcahange
            SkillExchange.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//div[@class='form-wrapper']//input[@placeholder='Add new tag']", 3);
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Skill-Exchange"));
            SkillExchange.SendKeys(Keys.Enter);

            //Thread.Sleep(3000);
            ////Select credit
            //CreditAmount.Click();
            //Thread.Sleep(3000);
            //CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));


            //click on worksamples and upload doc
            Wait.WaitForElementToBePresent(driver, "XPath", "//i[@class='huge plus circle icon padding-25']", 3);
            Worksamples.Click();
            //AutoIT            
            AutoItX3 AutoIt = new AutoItX3();
            AutoIt.WinActivate("Open");
            Thread.Sleep(1000);
            AutoIt.Send(@"C:\Users\User\MVP\Sprint2\Task2\marsframework-master\marsframework-master\uploadfile.docx");
            Thread.Sleep(1000);
            AutoIt.Send("{ENTER}");
            Wait.WaitForElementToBePresent(driver, "XPath", "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']", 3);
            // Click on active
            ActiveOption1.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@value='Save']", 3);
            // Click on save button
            Save.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@value='Save']", 3);
            SaveScreenShotClass.SaveScreenshot(driver, "SkillsAdded");
            Thread.Sleep(5000);
            // Click on cancel
            //Cancel.Click();

            // Validate Shareskill- option 1

            String expectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            string actualValue = VerifyShareSkill.Text;
            // Check if expected value is equal to actual value
            Assert.Equals(expectedValue, actualValue);
            Console.WriteLine(actualValue, "Test Passed");

            // option 2
            //try
            //{
            //    String expectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
            //    string actualValue = VerfyShareSkill.Text;
            //    //Check if expected value is equal to actual value
            //    if (expectedValue == actualValue)
            //    {
            //        Assert.IsTrue(true);

            //    }

            //    else
            //    {
            //        Console.WriteLine("Test Failed");
            //    }
            //}


            //catch (Exception e)
            //{
            //    Console.WriteLine(e);

            //}
            Thread.Sleep(2000);
        }
        

        internal void EditShareSkill()
        {
            Wait.WaitForElementToBePresent(driver, "XPath", "//a[normalize-space()='Manage Listings']", 3);
            // After Click on Save button Page navigate to Manage Listing
            ManageListingBtn.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//table/tbody/tr[1]/td[8]/div/button[2]", 5);
            // Click On Edit button of Saved Share skill
            //Edit.WaitForElementClickable(driver, 60);
            Edit.Click();
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "UpdatedServiceListing");
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='Write a title to describe the service you provide.']", 3);
            // Write Title to describe the service
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Updated_Title"));
            // Add description
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Updated_Description"));
            // Choose category
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(CategoryDropDown);
            select.SelectByIndex(4);
            //Category.SendKeys("Select Category" + Keys.Down + Keys.Enter);
            // Choose Sub Category
            Thread.Sleep(1000);
            SelectElement select2 = new SelectElement(SubCategoryDropDown);
            select2.SelectByIndex(3);

            //SubCategory.SendKeys("Select Subcategory" + Keys.Down + Keys.Enter);
            // enter Tags
            Tags.Click();
            Tags.Clear();
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Updated_Tags"));
            Tags.SendKeys(Keys.Return);

            Wait.WaitForElementToBePresent(driver, "XPath", "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]", 3);
            //Select servicetype options
            ServiceTypeOptions.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]", 3);
            ServiceTypeOptions.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Updated_ServiceType"));

            Wait.WaitForElementToBePresent(driver, "XPath", "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]", 3);
            //select locationtype
            LocationTypeOption.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]", 2);
            LocationTypeOption.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Updated_LocationType"));

            //On available days option click on startdate dropdown
            StartDateDropDown.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='Start date']", 3);
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));

            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='End date']", 3);
            //On available days option click on enddate dropdown
            EndDateDropDown.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='End date']", 3);
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
            Thread.Sleep(3000);

            // Click on availble days

            //Sun.Click();
            //SunStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //SunEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            ////to perform doubleclick on button
            //Thread.Sleep(2000);
            //Actions act = new Actions(driver);
            //act.DoubleClick(Mon).Perform();
            //Thread.Sleep(1000);
            //MonStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //MonEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            //act.DoubleClick(Tue).Perform();
            //TueStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Starttime"));
            //TueEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Endtime"));

            //Wed.Click();


            Thr.Click();
            ThrStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            ThrEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            Fri.Click();
            FriStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            FriEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            Sat.Click();
            SatStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            SatEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            //Select Skill Trade

            //SkillTradeOption2.Click();
            //CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "CreditAmount"));

            SkillTradeOption.Click();

            ////Add Skill Exchange
            //SkillExchange.Click();
            //SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchange"));
            //SkillExchange.SendKeys(Keys.Enter);
           
            //Click on Work sample
            Worksamples.Click();
            //AutoIT            
            AutoItX3 AutoIt = new AutoItX3();
            AutoIt.WinActivate("Open");
            Thread.Sleep(1000);
            AutoIt.Send(@"C:\Users\User\MVP\Sprint2\Task2\marsframework-master\marsframework-master\uploadfile.docx");
            Thread.Sleep(1000);
            AutoIt.Send("{ENTER}");
            // clickon Active
            ActiveOption1.Click();
            //ActiveOption2.Click();
            Thread.Sleep(1000);
            // Click on Save
            Save.Click();
            SaveScreenShotClass.SaveScreenshot(driver, "SkillsUpdated");
            // Click on cancel
            //Cancel.Click();
        }

        internal void EditManageLisiting()
        {
            Wait.WaitForElementToBePresent(driver, "XPath", "//a[normalize-space()='Manage Listings']", 3);
            // After Click on Save button Page navigate to Manage Listing
            ManageListingBtn.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//table/tbody/tr[1]/td[8]/div/button[2]", 3);
            // Click On Edit button of Saved Share skill
            Edit.Click();
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "UpdatedServiceListing");
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='Write a title to describe the service you provide.']", 3);
            // Write Title to describe the service
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Updated_Title"));
            // Add description
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Updated_Description"));
            // Choose category
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(CategoryDropDown);
            select.SelectByIndex(4);
            //Category.SendKeys("Select Category" + Keys.Down + Keys.Enter);
            // Choose Sub Category
            Thread.Sleep(1000);
            SelectElement select2 = new SelectElement(SubCategoryDropDown);
            select2.SelectByIndex(3);

            //SubCategory.SendKeys("Select Subcategory" + Keys.Down + Keys.Enter);
            // enter Tags
            Tags.Click();
            Tags.Clear();
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Updated_Tags"));
            Tags.SendKeys(Keys.Return);

            Wait.WaitForElementToBePresent(driver, "XPath", "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]", 3);
            //Select servicetype options
            ServiceTypeOptions.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]", 3);
            ServiceTypeOptions.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Updated_ServiceType"));

            Wait.WaitForElementToBePresent(driver, "XPath", "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]", 3);
            //select locationtype
            LocationTypeOption.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]", 3);
            LocationTypeOption.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Updated_LocationType"));

            //On available days option click on startdate dropdown
            StartDateDropDown.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='Start date']", 3);
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));

            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='End date']", 3);
            //On available days option click on enddate dropdown
            EndDateDropDown.Click();
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@placeholder='End date']", 3);
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
            Thread.Sleep(3000);


            // Click on availble days
            Wait.WaitForElementToBePresent(driver, "XPath", "//input[@type='checkbox' and @index='0']", 3);
            Sun.Click();
            SunStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            SunEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            //////to perform doubleclick on button
            ////Thread.Sleep(2000);
            ////Actions act = new Actions(driver);
            ////act.DoubleClick(Mon).Perform();
            ////Thread.Sleep(1000);
            ////MonStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            ////MonEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            ////act.DoubleClick(Tue).Perform();
            ////TueStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Starttime"));
            ////TueEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Endtime"));

            ////Wed.Click();


            //Thr.Click();
            //ThrStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //ThrEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            //Fri.Click();
            //FriStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //FriEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            //Sat.Click();
            //SatStartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));
            //SatEndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));

            //Select Skill Trade

            //SkillTradeOption2.Click();
            //CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "CreditAmount"));

            SkillTradeOption.Click();

            ////Add Skill Exchange
            //SkillExchange.Click();
            //SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchange"));
            //SkillExchange.SendKeys(Keys.Enter);

            //Click on Work sample
            Worksamples.Click();
            //AutoIT            
            AutoItX3 AutoIt = new AutoItX3();
            AutoIt.WinActivate("Open");
            Thread.Sleep(1000);
            AutoIt.Send(@"C:\Users\User\MVP\Sprint2\Task2\marsframework-master\marsframework-master\uploadfile.docx");
            Thread.Sleep(1000);
            AutoIt.Send("{ENTER}");
            // clickon Active
            ActiveOption1.Click();
            //ActiveOption2.Click();
            Thread.Sleep(1000);
            // Click on Save
            Save.Click();
            SaveScreenShotClass.SaveScreenshot(driver, "SkillsUpdatedManageListing");
            // Click on cancel
            //Cancel.Click();
        }
    }


}
    

