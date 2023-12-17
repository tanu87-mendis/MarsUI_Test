Feature: LanguageFeature

As a Mars user I
I would like to create, edit and delete langugaes and language levels
So I can manage the user profile successfully 

@tag1
Scenario: create language and language level with valid details
	Given I logged into the Mars portal successfully
	When I navigate to the user profile
	When I navigate to the languages tab
	Then the record should be created successfully 

