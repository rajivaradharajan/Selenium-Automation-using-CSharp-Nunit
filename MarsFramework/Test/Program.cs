using MarsFramework.Pages;
using NUnit.Framework;
using MarsFramework.Global;
using static MarsFramework.Global.GlobalDefinitions;
using AventStack.ExtentReports;

namespace MarsFramework
{
     public class ShareSkillTestSuite
    {
        [TestFixture,Description("ShareSkill Test Cases")]
        [Parallelizable]
        [Category("Sprint1")]
        class Shareskilltest :Base
        {
            

            [Test]
            public void AddShareSkillTest()
            {
                test = extent.CreateTest("AddShareSkill");
                //Assert.IsTrue(true);
                test.Log(Status.Info, "Adding ShareSkills Passed");

                // taking Screenshots of adding skills
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");
                //Steps for Add shareskill

                ShareSkill addshareskillobj = new ShareSkill();
                addshareskillobj.EnterShareSkill();
                SaveScreenShotClass.SaveScreenshot(driver, "ShareSkill");
                

            }

            [Test]
            public void EditShareSkillTest()
            {
                test = extent.CreateTest("EditShareSkill");
                //Assert.IsTrue(true);
                test.Log(Status.Info, "Editing ShareSkills Passed");
                SaveScreenShotClass.SaveScreenshot(driver, "Updated");
                //shareSkill page object
                ShareSkill updateshareskillobj = new ShareSkill();
                updateshareskillobj.EditShareSkill();
                SaveScreenShotClass.SaveScreenshot(driver, "Updated");
                

            }

            [Test]
            public void ManageShareSkillTest()
            {
                test = extent.CreateTest("ManageShareSkill");
                //Assert.IsTrue(true);
                test.Log(Status.Info, "Managed ShareSkills Passed");
                //shareSkill page object
                ManageListings manageshareskillobj = new ManageListings();
                manageshareskillobj.ManageListing();
                SaveScreenShotClass.SaveScreenshot(driver, "ListingDeleted");
                
            }
        }
    }
}
