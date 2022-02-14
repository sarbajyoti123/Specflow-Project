Feature: PersonalDetails
	In order to maintain the personal details
	As a portal user
	I would like to add,edit,delete the Personal Details

	Background:
	Given I have browser with orangehrm page
	@low
Scenario: Add personal details
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	And I click on My Info
	And I click on personal details
	And I click on edit
	And I fill personal details
	
	| firstname | middlename | lastname | employeeid | otherid | licensenumber | licenseexpirydate | ssnnumber | sinnumber | gender | martialstatus | nationality | dob        | nickname | smoker | militaryservice |
	| John      | k          | Wick     | 1001       | 201     | 65789L        | 2030-10-31        | 44554     | 788778    | Male   | Single        | Dutch       | 1992-10-15 | jidi     | no     | No              |
	And I click on save Personal Details
	Then I should get fistname as 'John' and lastname as 'Wick'

	