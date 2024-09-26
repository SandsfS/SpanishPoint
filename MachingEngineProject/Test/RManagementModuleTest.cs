using NUnit.Framework;
using OpenQA.Selenium;
using MachingEngineProject.PageObjects;
using System.Collections.Generic;
using System.IO;

namespace MachingEngineProject
{
    public class RManagementModuleTest : BaseTest
    {
        public RManagementModulePage homePage;
        private string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData.csv");

        [SetUp]
        public void SetupTest()
        {
            homePage = new RManagementModulePage(driver);  // Initialize page object
            List<string> expectedProducts = new List<string> { "Cue Sheet / AV Work", "Recording", "Bundle", "Advertisement" };
            Helper.WriteListToCSV(csvFilePath, expectedProducts);
        }

        [Test]
        public void TestProductList()
        {
            ExtentReportManager.Log("Navigating to homepage.");
            driver.Navigate().GoToUrl(baseUrl);

            ExtentReportManager.Log("Clicking on Modules.");
            homePage.ClickModules();

            ExtentReportManager.Log("Clicking on Repertoire Management Module.");
            homePage.ClickRepertoireManagementModule();

            ExtentReportManager.Log("Scrolling to Additional Features.");
            homePage.ScrollToAdditionalFeatures();

            ExtentReportManager.Log("Clicking on Products Supported Tab.");
            homePage.ClickProductsSupportedTab();

            // Get the list of products and verify them
            IList<IWebElement> productsElements = homePage.GetProductsList();
            List<string> expectedProducts = Helper.ReadListFromCSV(csvFilePath);

            for (int i = 0; i < expectedProducts.Count; i++)
            {
                string actualProduct = productsElements[i].Text.Trim();
                ExtentReportManager.Log($"Expected: {expectedProducts[i]}, Found: {actualProduct}");
                Console.WriteLine($"Expected: {expectedProducts[i]}, Found: {actualProduct}");
                Assert.That(expectedProducts[i], Is.EqualTo(actualProduct), $"Expected {expectedProducts[i]}, but found {actualProduct}");
            }

            // Log success in the report
            ExtentReportManager.LogPass("Product list test passed successfully!");
        }
    }
}
