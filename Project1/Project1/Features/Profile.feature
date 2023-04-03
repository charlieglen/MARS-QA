﻿Feature: ProfileFeature

As a seller, I would like to sign up to MarsQA portal and create my profile
So that the customer can view my skills and details

Scenario: 01) Add language on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new language
	Then The new language should be added successfully

Scenario: 02) Add skills on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new skill
	Then The new skill should be added successfully

Scenario: 03) Add education details on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new education details
	Then The new education details should be added successfully

Scenario: 04) Add certification details on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new certification details
	Then The new certification details should be added successfully

Scenario: 05) Add description on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new description
	Then The new dedscription should be added successfully

#Scenario: 06) Add Availability type on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I select the availability type 
#	Then The availability type should be displayed successfully
#
#Scenario: 07) Add Working hours range on my profile
#	Given I launch and log into MarsQA portal successfully
#	When  I select the number of working hours
#	Then The estimated working hours should be displayed successfully
#
#Scenario: 08) Add Earn target on my profile
#	Given I launch and log into MarsQA portal successfully
#	When I select the earning target range
#	Then The estimated earning target should be displaye successfully



