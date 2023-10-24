using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal2023.pages;


// Open chrome browser


internal class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        //LoginPage page object initialitaion and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //HomePage page object initialitaion and definition
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMpage(driver);

        //TMPage page object initialitaion and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);
        tmPageObj.EditTimeRecord(driver);
        tmPageObj.DeleteTimeRecord(driver);

        
    }
}

//Edit time and material module







