using System;
using ConsoleApp1.Pages;
using ConsoleApp1.Utilities;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ConsoleApp1.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into the Mars portal successfully")]
        public void GivenILoggedIntoTheMarsPortalSuccessfully()
        {
            //Open Chrome browser 
            driver = new ChromeDriver();

            //Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

        }

        [When(@"I navigate to the user profile")]
        public void WhenINavigateToTheUserProfile()
        {
            //Home Page object initialization and definition 
            HomePage homePageObj = new HomePage();
            homePageObj.GoToLanguagePage(driver);
        }

        [When(@"I navigate to the languages tab")]
        public void WhenINavigateToTheLanguagesTab()
        {

            //Language Page object initialization and definition 
            LanguagePage languagePageObj = new LanguagePage();
            languagePageObj.AddNewLangauge(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            //Assertion
        }
    }
}
