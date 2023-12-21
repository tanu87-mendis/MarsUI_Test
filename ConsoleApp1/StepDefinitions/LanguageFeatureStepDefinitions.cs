using System;
using ConsoleApp1.Pages;
using ConsoleApp1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ConsoleApp1.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        LanguagePage languagePageObj = new LanguagePage();

        [Given(@"I logged into the Mars portal successfully")]
        public void GivenILoggedIntoTheMarsPortalSuccessfully()
        {
            //Open Chrome browser 
            driver = new ChromeDriver();

            //Login Page object initialization and definition
            loginPageObj.LoginActions(driver);

        }

        [When(@"I navigate to the user profile")]
        public void WhenINavigateToTheUserProfile()
        {
            //Home Page object initialization and definition
            homePageObj.GoToLanguagePage(driver);
        }

        [When(@"I navigate to the languages tab")]
        public void WhenINavigateToTheLanguagesTab()
        {

            //Language Page object initialization and definition 
            languagePageObj.AddNewLangauge(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            //Assertion
        }

        [When(@"I update the '([^']*)','([^']*)' of  existing language under user profile")]
        public void WhenIUpdateTheOfExistingLanguageUnderUserProfile(string language, string level)
        {
            languagePageObj.EditLangauge(driver, language,level);
        }

        [Then(@"the the record should be updated '([^']*)', '([^']*)' successfully")]
        public void ThenTheTheRecordShouldBeUpdatedSuccessfully(string language, string level)
        {
            string editedlanguage = languagePageObj.GetEditedLanguage(driver);  
            string editedLevel = languagePageObj.GetEditedLevel(driver);

            Assert.That(editedlanguage, Is.EqualTo(language),"Actual Language and updated language donot match");
            Assert.That(editedLevel, Is.EqualTo(level), "Actual Language level and updated level donot match");
                
        }

        [When(@"I click on the delete tab")]
        public void WhenIClickOnTheDeleteTab()
        {
            languagePageObj.DeleteLangauge(driver);
        }

        [Then(@"the record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
            //string deletedLanguage = languagePageObj.DeletedLanguage(driver);

            //Assert.That(deletedLanguage, Is.EqualTo("English"), "Record has not been deleted");


        }


    }
}
