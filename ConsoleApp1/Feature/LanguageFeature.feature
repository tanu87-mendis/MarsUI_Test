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
	
Scenario Outline: edit existing language and lanuage level
	Given I logged into the Mars portal successfully 
	When I navigate to the user profile
	#When I navigate to the languages tab
	When I update the '<Languagae>','<Level>' of  existing language under user profile
	Then the the record should be updated '<Languagae>', '<Level>' successfully

	Examples: 
	| Languagae |  Level            |
	| Russian   |  Basic            |
	| Mandarin  |  Fluent           |
	| Arabic    |  Native/Bilingual |

Scenario: Delete language and language level from profile
	Given I logged into the Mars portal successfully
	When I navigate to the user profile
	When I navigate to the languages tab
	When I click on the delete tab
	Then the record should be deleted successfully

