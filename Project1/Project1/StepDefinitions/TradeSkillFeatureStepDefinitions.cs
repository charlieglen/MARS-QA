using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Project1.Drivers;
using Project1.Pages;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Project1.StepDefinitions
{
    [Binding]
    public class TradeSkillFeatureStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I launch and log into Trade skill portal")]
        public void GivenILaunchAndLogIntoTradeSkillPortal()
        {
            loginPageObj.LogInActions(driver);
        }

        [Given(@"I add a new language")]
        public void GivenIAddANewLanguage()
        {
            profilePageObj.Languages(driver);
        }

        [Then(@"The new language should be added successfully")]
        public void ThenTheNewLanguageShouldBeAddedSuccessfully()
        {
            string newLanguage = profilePageObj.alertWindow(driver);
            Assert.That(newLanguage == "Filipino has been added to your languages", "Failed to add Language");
        }

        [Given(@"I add a new skill")]
        public void GivenIAddANewSkill()
        {
            profilePageObj.Skills(driver);
        }

        [Then(@"The new skill should be added successfully")]
        public void ThenTheNewSkillShouldBeAddedSuccessfully()
        {
            string newSkill = profilePageObj.alertWindow(driver);
            Assert.That(newSkill == "Specflow has been added to your skills", "Failed to add skills");
        }

        [Given(@"I add a new education details")]
        public void GivenIAddANewEducationDetails()
        {
            profilePageObj.Education(driver);
        }

        [Then(@"The new education details should be added successfully")]
        public void ThenTheNewEducationDetailsShouldBeAddedSuccessfully()
        {
            string newEducation = profilePageObj.alertWindow(driver);
            Assert.That(newEducation == "Education has been added", "Failed to add education details");
        }

        [Given(@"I add a new certification details")]
        public void GivenIAddANewCertificationDetails()
        {
            profilePageObj.Certifications(driver);
        }

        [Then(@"The new certification details should be added successfully")]
        public void ThenTheNewCertificationDetailsShouldBeAddedSuccessfully()
        {
            string newCertification = profilePageObj.alertWindow(driver);
            Assert.That(newCertification == "CCNA has been added to your certification", "Failed to add certification details");
        }

        [Given(@"I add a new description")]
        public void GivenIAddANewDescription()
        {
            profilePageObj.Description(driver);
        }

        [Then(@"The new dedscription should be added successfully")]
        public void ThenTheNewDedscriptionShouldBeAddedSuccessfully()
        {
            string newDescription = profilePageObj.alertWindow(driver);
            Assert.That(newDescription == "Description has been saved successfully", "Failed to save description");
        }

    }
}
