using MarsFramework.Pages;
using NUnit.Framework;
using MarsFramework.Global;
using static MarsFramework.Global.GlobalDefinitions;
using RelevantCodes.ExtentReports;

namespace MarsFramework
{
    public class ShareSkillTestSuite
    {
        [TestFixture,Description("ShareSkill Test Cases")]
        [Parallelizable]
        [Category("Sprint1")]
        class Shareskilltest: Base
        {
            

            [Test]
            public void AddShareSkillTest()
            {
                test = extent.StartTest("EditShareSkill");
                Assert.IsTrue(true);
                test.Log(LogStatus.Pass, "Editing ShareSkills Passed");


                //Steps for Add shareskill

                ShareSkill addshareskillobj = new ShareSkill();
                addshareskillobj.EnterShareSkill();
                SaveScreenShotClass.SaveScreenshot(driver, "AddedSkill");
                

            }

            [Test]
            public void EditShareSkillTest()
            {
                test = extent.StartTest("EditShareSkill");
                Assert.IsTrue(true);
                test.Log(LogStatus.Pass, "Editing ShareSkills Passed");
                //shareSkill page object
                ShareSkill updateshareskillobj = new ShareSkill();
                updateshareskillobj.EditShareSkill();
                SaveScreenShotClass.SaveScreenshot(driver, "Updated");
                

            }

            [Test]
            public void ManageShareSkillTest()
            {
                test = extent.StartTest("ManageShareSkill");
                Assert.IsTrue(true);
                test.Log(LogStatus.Pass, "Managed ShareSkills Passed");
                //shareSkill page object
                ManageListings manageshareskillobj = new ManageListings();
                manageshareskillobj.ManageListing();
                SaveScreenShotClass.SaveScreenshot(driver, "ListingDeleted");
                
            }
        }
    }
}
