Feature: Test Amazon using Specflow Excel
	   Go to Amazon Url
	   Login to website
	   Search an item and
	   Add to cart

Background: Pre Condition
	   Given User is at Amazon homepage with url "https://www.amazon.in/"
	   And Signin link should be visible

@excelsheet
Scenario Outline: Add item into cart using Excel
	 When User clicks on "<Signin>" link
	 Then User should be at Login Page
	 When User provides "<username>","<password>" and click on login button
	 Then User should be able to login successfully.
	 When User provides "<searchitem>","<selectitem>" in search tab
	 Then User should be taken to "<displaypage>" Display page.
	 When User selects "<exactitem>" and adds to cart
	 Then the specific item is added to cart
	 When User clicks on "<Cart>" link after adding to cart
	 Then user is taken to cartpage
	 When "<exactitem>" is present in cart
	 Then write to file "<exactitem>"
	 When User clicks to delete item "<exactitem>" from cart
	 Then item is deleted from cart

@source:specflowdata.xlsx
Examples: 
| username             | password   | searchitem | selectitem | displaypage  | exactitem  |
