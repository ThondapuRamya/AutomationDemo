Feature: HomePage

Home Page Display

@HomePage @1 @UI
Scenario: Application successful launch
	Given I have entered application URL	
	Then  Application login page will open
	When I have clicked on Open New Window button
	Then Switch to new window
	Then Validate New window opened or not
