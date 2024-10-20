Feature: ValidtateMenuItems

A short summary of the feature

@tag1 @UI @11
Scenario: Validating Menu Items
	Given I have entered application URL	
	Then  Application login page will open
	When I have entered user name 
	And I have entered password	
	When  Click on login button
	Then  Validate result
	When click on MenuItems Icon
	Then validate the Menu Items All Items,About,Logout,Reset App State
