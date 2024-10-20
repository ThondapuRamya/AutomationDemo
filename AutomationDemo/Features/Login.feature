Feature: Login

Login functionality validation

@Login @1 @UI
Scenario: Application successful launch
	Given I have entered application URL	
	Then  Application login page will open
	When I have entered user name 
	And I have entered password	
	When  Click on login button
	Then  Validate result

Scenario Outline: Valid and invalid scenario
		  Given I have entered application URL	
		   Then Application login page will open
		   When I have entered username as <UserName> 
			And I have entered password as <Password>
			Then Validate output <ValidOrInvali>
			
			
Examples: 
| UserName | Password | ValidOrInvali |
| naresh   | ramya    | Valid         |
| nikki    | nirvi    | Invalid       |





