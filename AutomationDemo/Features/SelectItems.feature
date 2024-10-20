Feature: SelectItems

A short summary of the feature

@tag1@tag1 @UI @21
Scenario: Sorting and validating the Sorted Item
	Given I have entered application URL	
	Then Application login page will open
	When I have entered user name 
	And I have entered password	
	When Click on login button
	Then Validate result
	When click on Filter Icon
	When Select sorted list as Price (low to high)
	Then Validate the Items sorted items result
