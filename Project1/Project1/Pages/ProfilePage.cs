using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V109.Database;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Project1.Utilities;

namespace Project1.Pages
{
    public class ProfilePage : Wait

    {
        public void addEducation(IWebDriver driver)
        {
            
            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();

            IWebElement addNewEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewEducation.Click();

            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.SendKeys("USM");

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();
            SelectElement instituteCountry = new SelectElement(instituteCountryDropdown);
            instituteCountry.SelectByValue("Philippines");

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue("B.Sc");

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.SendKeys("Computer Engineering");

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();
            SelectElement yearGraduated = new SelectElement(yearGraduatedDropdown);
            yearGraduated.SelectByValue("2010");

            IWebElement addEducationButton = driver.FindElement(By.XPath("//*[@value='Add']"));
            addEducationButton.Click();

        }
        public void editEducation(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();

            IWebElement editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[6]/span[1]/i"));
            editIcon.Click();
                        
            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.Clear();
            instituteTextbox.SendKeys("Avengers Academy");

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();
            SelectElement instituteCountry = new SelectElement(instituteCountryDropdown);
            instituteCountry.SelectByValue("Bulgaria");

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue("BFA");

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.Clear();
            degreeTextbox.SendKeys("Intergalactic Space Ambassasdor");

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();
            SelectElement yearGraduated = new SelectElement(yearGraduatedDropdown);
            yearGraduated.SelectByValue("2023");

            IWebElement updateEducationButton = driver.FindElement(By.XPath("//*[@value='Update']"));
            updateEducationButton.Click();

        }
        public void deleteEducation(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();

            IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr[last()]/td[6]/span[2]/i"));
            deleteIcon.Click();

        }
        public string alertWindow(IWebDriver driver)
        {

            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }

    }
}
