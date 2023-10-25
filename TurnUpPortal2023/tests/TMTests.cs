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

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //HomePage page object initialitaion and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);

        }

        [Test]
        public void TestCreatTimerecord()
        {
            //TMPage page object initialitaion and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);
        }

        [Test]
        public void TestEditTimerecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver);
        }

        [Test]
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
