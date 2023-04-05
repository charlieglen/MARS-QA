Feature: EducationFeature

As a seller, I would like to sign up to MarsQA portal and create my profile
So people seeking for some skills can look into my details.

Scenario: 01) Add education record on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new education record
	Then The new education record should be added successfully

Scenario:  02) Edit education record on my profile
	Given I launch and log into MarsQA portal successfully
	When I edit an existing education record
	Then The new education record should be updated successfully

Scenario:  03) Delete education record on my profile
	Given I launch and log into MarsQA portal successfully
	When I delete an existing education record
	Then The new education record should be deleted successfully
	
#Scenario: 04) Add language on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I add a new language
#	Then The new language should be added successfully
#
#Scenario: 05) Add skills on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I add a new skill
#	Then The new skill should be added successfully

#Scenario: 06) Add certification details on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I add a new certification details
#	Then The new certification details should be added successfully
#
#Scenario: 07) Add description on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I add a new description
#	Then The new dedscription should be added successfully

#Scenario: 08) Add Availability type on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I select the availability type 
#	Then The availability type should be displayed successfully
#
#Scenario: 09) Add Working hours range on my profile
#	Given I launch and log into MarsQA portal successfully
#	When  I select the number of working hours
#	Then The estimated working hours should be displayed successfully
#
#Scenario: 10) Add Earn target on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I select the earning target range
#	Then The estimated earning target should be displaye successfully



