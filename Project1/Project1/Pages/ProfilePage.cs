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
        public void Description(IWebDriver driver)
        {
            
            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 5);

            IWebElement addDescriptionButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            addDescriptionButton.Click();

            IWebElement descriptionTextArea = driver.FindElement(By.Name("value"));
            descriptionTextArea.Clear();
            descriptionTextArea.SendKeys("I am a Test Analyst.");

            IWebElement saveDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveDescription.Click();
        }
        public void Languages(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 5);

            IWebElement addNewLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguageButton.Click();

            IWebElement addLanguageTextbox = driver.FindElement(By.Name("name"));
            addLanguageTextbox.SendKeys("Filipino");

            IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            languageLevelDropdown.Click();

            IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            languageLevel.Click();

            IWebElement addLanguangeButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguangeButton.Click();

        }
       
        public void Skills(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);

            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();

            IWebElement addNewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkill.Click();

            IWebElement addSkillTextbox = driver.FindElement(By.Name("name"));
            addSkillTextbox.SendKeys("Specflow");

            IWebElement skillLevelDropdown = driver.FindElement(By.Name("level"));
            skillLevelDropdown.Click();

            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            skillLevel.Click();

            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkillButton.Click();

        }
        public void Education(IWebDriver driver)
        {
            
            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();

            IWebElement addNewEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewEducation.Click();

            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.SendKeys("USM");

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();

            IWebElement instituteCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[113]"));
            instituteCountry.Click();

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();

            IWebElement title = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]"));
            title.Click();

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.SendKeys("Computer Engineering");

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();

            IWebElement yearGraduated = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[15]"));
            yearGraduated.Click();

            IWebElement addEducationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addEducationButton.Click();

        }
        public void Certifications(IWebDriver driver)
        {
            
            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);

            IWebElement CertificationsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertificationsTab.Click();

            IWebElement addNewCert = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewCert.Click();

            IWebElement certAwardTextbox = driver.FindElement(By.Name("certificationName"));
            certAwardTextbox.SendKeys("CCNA");

            IWebElement certifiedFromTextbox = driver.FindElement(By.Name("certificationFrom"));
            certifiedFromTextbox.SendKeys("Cisco");

            IWebElement certYearDropdown = driver.FindElement(By.Name("certificationYear"));
            certYearDropdown.Click();

            IWebElement certYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[7]"));
            certYear.Click();

            IWebElement addCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addCertification.Click();
        }
        public string alertWindow(IWebDriver driver)
        {

            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);

            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }
        
    }
}
