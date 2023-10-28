using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowProject.pages
{
    public class HomePage
    {
        public void GoToTMpage(IWebDriver driver)
        {

            try
            {
                //Navigate to time and material module
                IWebElement administraionDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administraionDropdown.Click();
            }

            catch (Exception exception)
            {
                Assert.Fail("Turnup Portal Home page not displayed", exception.Message);
            }

            IWebElement TMOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMOption.Click();
        }
    }
}
