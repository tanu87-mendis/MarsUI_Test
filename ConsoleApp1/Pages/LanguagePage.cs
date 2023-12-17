using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void EditLangauge(IWebDriver driver) 
        {
            //Identify Edit tab and click on Edit button 
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")); 
            editButton.Click();

            //Navigate to language text box and edit value 
            IWebElement editLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editLanguage.Clear();
            editLanguage.SendKeys("Maori");

            Thread.Sleep(3000);

            //Navigate to language level drop down and edit value
            IWebElement editLanguLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            editLanguLevel.Clear();
            editLanguLevel.SendKeys("Fluent");

            //Navigate Update Button and click on Update button
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updateButton.Click();
        }

        public void DeleteLangauge(IWebDriver driver)
        {
            //Navigate Delete Button and click on delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteButton.Click();
        }
    }
}
