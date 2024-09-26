using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MachingEngineProject
{
    public class BaseTest
    {
        public IWebDriver driver;
        public string baseUrl;

        // Runs once before any tests are executed
        [OneTimeSetUp]
        public void GlobalSetup()
        {
            // Initialize the Extent Report at the start of the test session
            ExtentReportManager.InitializeReport();
        }

        [SetUp]
        public void Setup()
        {
            // Initialize the WebDriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            baseUrl = "https://www.matchingengine.com/";

            // Start a new test in the report
            ExtentReportManager.StartTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }

            // Log test result
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                ExtentReportManager.LogPass("Test passed successfully.");
            }
            else if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                ExtentReportManager.LogFail($"Test failed: {TestContext.CurrentContext.Result.Message}");
            }

            // Flush the report for each test
            ExtentReportManager.EndTest();
        }

        // Runs once after all tests are completed
        [OneTimeTearDown]
        public void GlobalTeardown()
        {
            // Optionally, you can call the final flush here if required for final cleanup
        }
    }
}
