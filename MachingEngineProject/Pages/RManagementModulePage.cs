using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace MachingEngineProject.PageObjects
{
    public class RManagementModulePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        // Constructor to initialize the driver
        public RManagementModulePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        // Locators
        private By modulesLink = By.XPath("//a[normalize-space()='Modules']");
        private By repertoireManagementModuleLink = By.XPath("//a[normalize-space()='Repertoire Management Module']");
        private By additionalFeaturesSection = By.XPath("//h2[normalize-space()='Additional Features']");
        private By productsSupportedTab = By.XPath("//li[@class='vc_tta-tab']//span[@class='vc_tta-title-text'][normalize-space()='Products Supported']");
        private By productsList = By.XPath("(//div[@class='wpb_text_column wpb_content_element wpb_animate_when_almost_visible wpb_fadeIn fadeIn wpb_start_animation animated'])[2]//ul/li//span");

        // Page actions
        public void ClickModules()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(modulesLink)).Click();
        }

        public void ClickRepertoireManagementModule()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(repertoireManagementModuleLink)).Click();
        }

        public void ScrollToAdditionalFeatures()
        {
            IWebElement additionalFeatureElement = driver.FindElement(additionalFeaturesSection);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", additionalFeatureElement);
        }

        public void ClickProductsSupportedTab()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(productsSupportedTab)).Click();
        }

        public IList<IWebElement> GetProductsList()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(productsList));
            return driver.FindElements(productsList);
        }
    }
}
