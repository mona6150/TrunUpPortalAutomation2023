using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TurnUpPortal2023.pages
{
    public class TMPage
    {
        //test case - create a new time record
        public void CreateTimeRecord(IWebDriver driver) 
        {
            //click on the create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //select time from dropdown button
            IWebElement typecodemainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecodemainDropdown.Click();

            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typecodeDropdown.Click();

            //Enter code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("September 2023");

            //Enter Description 
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Description for September 2023");

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

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[1]"));
            if (newCode.Text == "September 2023")
            {
                Console.WriteLine("New time record has been created successfully");
            }
            else
            {
                Console.WriteLine("Time record has not been created");
            }
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
            //Check if the Time record has been updated successfully
            IWebElement editGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editGoToLastPageButton.Click();

        }

        //Test case - Delete the updated Time record
        public void DeleteTimeRecord(IWebDriver driver)
        {
            //Nabvigaeting to last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            //Click delete button of last record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[2]"));
            deleteButton.Click();

        }
    }
}
