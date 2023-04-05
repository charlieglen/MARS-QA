using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Project1.Pages;
using Project1.Utilities;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace Project1.StepDefinitions
{
    [Binding]
    public class EducationFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();

        [Given(@"I launch and log into MarsQA portal successfully")]
        public void GivenILaunchAndLogIntoTradeSkillPortal()
        {
            driver = new  ChromeDriver();
            loginPageObj.LogInActions(driver);
        }

        [When(@"I add a new education record")]
        public void GivenIAddANewEducationDetails()
        {
            profilePageObj.addEducation(driver);
        }

        [Then(@"The new education record should be added successfully")]
        public void ThenTheNewEducationDetailsShouldBeAddedSuccessfully()
        {
            string newEducation = profilePageObj.alertWindow(driver);
            Assert.That(newEducation == "Education has been added", "Failed to add education record");
        }

        [When(@"I edit an existing education record")]
        public void WhenIEditAnExistingEducationRecord()
        {
            profilePageObj.editEducation(driver);
        }

        [Then(@"The new education record should be updated successfully")]
        public void ThenTheNewEducationRecordShouldBeUpdatedSuccessfully()
        {
            string updatedEducation = profilePageObj.alertWindow(driver);
            Assert.That(updatedEducation == "Education as been updated", "Failed to update education record");
        }
        [When(@"I delete an existing education record")]
        public void WhenIDeleteAnExistingEducationRecord()
        {
            profilePageObj.deleteEducation(driver);
        }

        [Then(@"The new education record should be deleted successfully")]
        public void ThenTheNewEducationRecordShouldBeDeletedSuccessfully()
        {
            string deleteEducation = profilePageObj.alertWindow(driver);
            Assert.That(deleteEducation == "Education entry successfully removed", "Failed to delete education record");

        }
        [AfterScenario]
        public void tearDown()
        {
            driver.Quit();
        }

    }
}
