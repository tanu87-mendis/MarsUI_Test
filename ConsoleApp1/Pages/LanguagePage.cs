using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ConsoleApp1.Pages
{
    public class LanguagePage
    {
        public void AddNewLangauge(IWebDriver driver)
        {
            //Identify AddNew button and click on Addnew Button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            //Navigate AddLanguage textbox send values
            IWebElement addLang = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLang.SendKeys("English");

            //choose language level
            IWebElement chooseLangLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLangLevel.SendKeys("Basic");

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
        }

        public void EditLangauge(IWebDriver driver, string language, string level)
        {
            //Identify Edit tab and click on Edit button 
            IWebElement editButton = driver.FindElement(By.XPath("//*/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editButton.Click();

            Thread.Sleep(5000);

            //Navigate to language text box and edit value 
            IWebElement editLanguage = driver.FindElement(By.XPath("//*/div/table/tbody[last()]/tr/td/div/div[1]/input"));

            //(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editLanguage.Clear();
            editLanguage.SendKeys(language);

            Thread.Sleep(3000);

            //Navigate to language level drop down and edit value
            IWebElement editLanguLevel = driver.FindElement(By.XPath("//*/tbody[last()]/tr/td/div/div[2]/select"));

            //("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            // editLanguLevel.Clear();
            editLanguLevel.SendKeys(level);

            Thread.Sleep(3000);

            try
            {


            }
            catch (Exception)
            {
                Assert.Fail("Go to last page button hasn't been found.");
            }

            //Navigate Update Button and click on Update button
            IWebElement updateButton = driver.FindElement(By.XPath("//*/tbody[last()]/tr/td/div/span/input[1]"));

            //("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updateButton.Click();

            Thread.Sleep(5000);
        }

        public string GetEditedLanguage(IWebDriver driver)
        {
            IWebElement editedlanguage = driver.FindElement(By.XPath("//*/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            return editedlanguage.Text;

        }

        public string GetEditedLevel(IWebDriver driver)
        {
            IWebElement editedLevel = driver.FindElement(By.XPath("//*/tbody[last()]/tr/td/div/div[2]/select"));
            return editedLevel.Text;

        }
        public void DeleteLangauge(IWebDriver driver)
        {
            //IWebElement addedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));

            ////if (addedLanguage.Text == "English")
            //{
            //Navigate Delete Button and click on delete button
            Thread.Sleep(3000);
            
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
            deleteButton.Click();

            //}
            //else 
            //    {
            //        Assert.Fail("Record to be deleted has not been found");  
            //    }
            //}
            //public string DeletedLanguage(IWebDriver driver)
            //{
            //    IWebElement deletedLanguage  = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            //    return deletedLanguage.Text;
            //}
        }
    }
}
