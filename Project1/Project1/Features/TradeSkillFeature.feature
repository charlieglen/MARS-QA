Feature: TradeSkillFeature

As a seller, I would like to sign up and create my profile
So that the customer can view my skills and details



Scenario: Create profile details with valid credentials
	Given I logged into the Trade your skill website
	When I add a new Language
	Then New language should be added on my profile successfully
	When I add a Description
	Then New Description should be added on my profile successfully
	When I add a skill
	Then New Skills shold be added on my profile successfully
	When I add Education details
	Then New Education details should be added on my profile successfully
	When I add Certifications details
	Then New Certification details should be added on my profile successfully
	