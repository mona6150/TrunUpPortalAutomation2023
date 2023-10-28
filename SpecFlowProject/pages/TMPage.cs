using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject.Utilities;

namespace SpecFlowProject.pages
{
    public class TMPage
    {
        //test case - create a new time record
        public void CreatTimeRecord(IWebDriver driver) 
        {
            //WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"container\"]/p/a")));
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"container\"]/p/a", 5);

            //click on the create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //select time from dropdown button
            IWebElement typecodemainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecodemainDropdown.Click();

            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typecodeDropdown.Click();

            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            Wait.WaitToBeClickable(driver, "Id", "Code", 7);
            codeTextBox.SendKeys("TurnUpPortal2023");
              
            //Enter Description 
            Wait.WaitToBeVisible(driver, "Id", "Description", 7);
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Description for TurnUpPortal2023");

            //Enter Price
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBox.SendKeys("100.50");


            //click on the save button 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);

            // check if a new time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            

            Assert.That(newCode.Text == "TurnUpPortal2023", "Time Record has not been created");
        }

        public void AssertCreateTMRecord(IWebDriver driver)
        {
            // check if a new time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


            Assert.That(newCode.Text == "TurnUpPortal2023", "Time Record has not been created");
        }
        

        //Test case - Edit Time record
        public void EditTimeRecord(IWebDriver driver)
        {
            //Nabvigating to last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            //Click edit button of last record
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //Change the code
            IWebElement editCodeTextBox = driver.FindElement(By.Id("Code"));
            editCodeTextBox.Clear();
            editCodeTextBox.SendKeys("67890");

            //Click on the save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();

            Thread.Sleep(5000);
           

        }

        public void AssertEditTMRecord(IWebDriver driver)
        {
            //Check if the Time record has been updated successfully
            IWebElement editGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editGoToLastPageButton.Click();

        }



        //Test case - Delete the updated Time record
        public void DeleteTimeRecord(IWebDriver driver)
        {
            //Navigating to last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            
        }
        public void AssertDeleteTMRecord(IWebDriver driver)
        {

            //Click delete button of last record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[2]"));
            deleteButton.Click();

        }
    }
}
