using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ConsoleApp1.Pages
{
    public class HomePage
    {
        public void GoToLanguagePage(IWebDriver driver)

           
        {
            // Navigate to Languages tab
            IWebElement languagesTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagesTab.Click();

            Thread.Sleep(3000);

        }
    }
}
