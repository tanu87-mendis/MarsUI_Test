//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ConsoleApp1.Pages;
//using NUnit.Framework;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using ConsoleApp1.Utilities;

//namespace ConsoleApp1.Tests
//{
//    [TestFixture]
//    public class Language_Test : CommonDriver
//    {

//        //Login Page object initialization and definition
//        LoginPage loginPageObj = new LoginPage();
//        //Home Page object initialization and definition 
//        HomePage homePageObj = new HomePage();

//        //Language Page object initialization and definition 
//        LanguagePage languagePageObj = new LanguagePage();


//        [SetUp]
//        public void CreateLanguage_Test()
//        {
//            //Open Chrome browser 
//             driver = new ChromeDriver();
//            loginPageObj.LoginActions(driver);
//            homePageObj.GoToLanguagePage(driver);

//        }
//        [Test]
//        public void AddLanguage_Test()
//        {

//            languagePageObj.AddNewLangauge(driver);
//        }
//        [Test]
//        public void EditLanguage_Test()
//        {
//            //Edit Language 
//            languagePageObj.EditLangauge(driver, "Spanish","Native");
//        }
//        [Test]
//        public void DeleteLanguage_Test() 
//        {
//            //Delete Language 
//          //  LanguagePage languagePageObj = new LanguagePage();
//            languagePageObj.DeleteLangauge(driver);


//        }
//        [TearDown]
//        public void CloseTestRun()
//        {
//            driver.Quit();
//        }

//    }
//}
