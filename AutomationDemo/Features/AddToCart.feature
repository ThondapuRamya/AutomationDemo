Feature: AddToCart

A short summary of the feature


@UI @21 @Regression @Smoke
Scenario: Validating Menu Items
	Given I have entered application URL	
	Then  Application login page will open
	When I have entered user name 
	And I have entered password	
	When Click on login button
	Then Validate result
	When click on Cart Icon
	Then validate cart page is displayed
	When Remove all items from existing cart
	And Click on continue shoping button
	And Add first item to the cart
	And click on Cart Icon
	Then Validate cart count as 1
	When Click on checkout button
	Then Validate item quantity as 1
	And Provide firstname as Naresh
	And Provide lastname as Potru
	And provide zip code as 1234456
	And click on Finish
	Then Validate order placed message
