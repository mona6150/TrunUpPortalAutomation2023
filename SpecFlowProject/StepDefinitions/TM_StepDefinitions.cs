using System;
using SpecFlowProject.Utilities;
using TechTalk.SpecFlow;
using SpecFlowProject.pages;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class TM_StepDefinitions : CommonDriver
    {
        [Order(1)]
        [Given(@"user logs into TurnUp portal")]
        public void GivenUserLogsIntoTurnUpPortal()
        {
            //Open Chrome driver
            driver = new ChromeDriver();

            //LoginPage page object initialitaion and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            
        }

        [Given(@"user navigates to a Time and Material Page")]
        public void GivenUserNavigatesToATimeAndMaterialPage()
        {
            //HomePage page object initialitaion and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMpage(driver);
        }

        [When(@"user create a new Time and material Record")]
        public void WhenUserCreateANewTimeAndMaterialRecord()
        {
            //TMPage page object initialitaion and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreatTimeRecord(driver);
        }

        [Then(@"TurnUp portal should save the new time and material record")]
        public void ThenTurnUpPortalShouldSaveTheNewTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.AssertCreateTMRecord(driver);
        }
        [Order(2)]
        [When(@"user Edits existing Time and material Record")]
        public void WhenUserEditsExistingTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver);
        }

        [Then(@"TurnUp portal should save existing time and material record")]
        public void ThenTurnUpPortalShouldSaveExistingTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.AssertEditTMRecord(driver);
        }
        [Order(3)]
        [When(@"user Deletes existing Time and material Record")]
        public void WhenUserDeletesExistingTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTimeRecord(driver);
        }

        [Then(@"TurnUp portal should Delete existing time and material record")]
        public void ThenTurnUpPortalShouldDeleteExistingTimeAndMaterialRecord()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.AssertDeleteTMRecord(driver);
        }


    }
}


