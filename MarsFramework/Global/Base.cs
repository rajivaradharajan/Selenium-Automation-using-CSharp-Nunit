using MarsFramework.Config;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Global
{
    class Base
    {
        #region To access Path from resource file

        public static int Browser = Int32.Parse(MarsResource.Browser);
        public static string Url = MarsResource.Url;
        public static String ExcelPath = MarsResource.ExcelPath;
        public static string ScreenshotPath = MarsResource.ScreenShotPath;
        public static string ReportPath = MarsResource.ReportPath;
        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;


        #endregion

        #region setup and tear down
        [SetUp]
        [Obsolete]
        public void Inititalize()
        {

            switch (Browser)
            {

                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    break;
                case 2:
                    GlobalDefinitions.driver = new ChromeDriver();
                    GlobalDefinitions.driver.Manage().Window.Maximize();
                    
                    break;

            }


            #region Initialise Reports

            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(MarsResource.ReportXMLPath);
            extent.AddSystemInfo("OS", "Window 10 Home");
            extent.AddSystemInfo("Host Name", "Raji");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("UserName", "Raji");
            # endregion

            if (MarsResource.IsLogin == "true")
            {

                //Populate the excel data
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
            }
            else
            {
                SignUp obj = new SignUp();
                obj.register();
            }

            
        }



        //[TearDown]
        //public void TearDown()
        //{
        //    Screenshot
        //   String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
        //    test.Log(LogStatus.Info, "Image example: " + img);
        //    end test. (Reports)
        //   extent.EndTest(test);
        //    calling Flush writes everything to the log file(Reports)
        //    extent.Flush();
        //    Close the driver:)            
        //    GlobalDefinitions.driver.Close();
        //    GlobalDefinitions.driver.Quit();
        //}

        #endregion

    }
}