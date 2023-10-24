using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TurnUpPortal2023.pages
{
    public class HomePage
    {
        public void GoToTMpage(IWebDriver driver)
        {
            // Check if the user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("user has logged in successfully");
            }
            else
            {
                Console.WriteLine("user has not logged in");
            }

            //Navigate to time and material module
            IWebElement administraionDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administraionDropdown.Click();

            IWebElement TMOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMOption.Click();
        }
    }
}
