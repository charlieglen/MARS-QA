using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Project1.Drivers;
using Project1.Pages;
using System;
using TechTalk.SpecFlow;

namespace Project1.StepDefinitions
{
    [Binding]
    public class TradeSkillFeatureStepDefinitions : CommonDriver
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I logged into the Trade your skill website")]
        public void GivenILoggedIntoTheTradeYourSkillWebsite()
        {
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LogInActions(driver);
        }

        [When(@"I add a new Language")]
        public void WhenIAddANewLanguage()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.Languages(driver);
        } 

        [Then(@"New language should be added on my profile successfully")]
        public void ThenNewLanguageShouldBeAddedOnMyProfileSuccessfully()
        {
            
        }

        [When(@"I add a Description")]
        public void WhenIAddADescription()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.Description(driver);
        }

        [Then(@"New Description should be added on my profile successfully")]
        public void ThenNewDescriptionShouldBeAddedOnMyProfileSuccessfully()
        {
          
        }
        [When(@"I add a skill")]
        public void WhenIAddASkill()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.Skills(driver);
        }

        [Then(@"New Skills shold be added on my profile successfully")]
        public void ThenNewSkillsSholdBeAddedOnMyProfileSuccessfully()
        {
           
        }
        [When(@"I add Education details")]
        public void WhenIAddEducationDetails()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.Education(driver);
        }

        [Then(@"New Education details should be added on my profile successfully")]
        public void ThenNewEducationDetailsShouldBeAddedOnMyProfileSuccessfully()
        {
            
        }
        [When(@"I add Certifications details")]
        public void WhenIAddCertificationsDetails()
        {
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.Certifications(driver);
        }

        [Then(@"New Certification details should be added on my profile successfully")]
        public void ThenNewCertificationDetailsShouldBeAddedOnMyProfileSuccessfully()
        {
            
        }

    }
}
