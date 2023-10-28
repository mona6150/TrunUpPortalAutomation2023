using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal2023.pages;
using TurnUpPortal2023.Utilities;

namespace TurnUpPortal2023.tests
{
    [TestFixture]
    public class TMTests : CommonDriver

    {
       
        [SetUp]
        public void SetUpTM()
        {
            //Open Chrome driver
            driver = new ChromeDriver();

            //LoginPage page object initialitaion and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);
  

            //HomePage page object initialitaion and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

        }

        [Test, Order(1), Description("This test creates a new time record with valid data")]
        public void TestCreatTimerecord()
        {
            //TMPage page object initialitaion and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreatTimeRecord(driver);
        }

        [Test, Order(2), Description("This test updates an existing time record with valid data")]
        public void TestEditTimerecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver);
        }

        [Test, Order(3), Description("This test Deletes time record.")] 
        public void TestDeleteTimerecord()
        {
            TMPage tmPageObj = new TMPage(); 
            tmPageObj.DeleteTimeRecord(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
