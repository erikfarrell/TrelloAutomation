Feature: Trello
	In order to prove out coding skill
	As a developer
	I want to use Trello as an automation example platform

@mytag
Scenario: Create a new board
	Given I navigate to "https://trello.com"
	And I log in as "survias@live.com"
	And I open the Boards menu from top menu navigation
	And I click "Create new board..." in the Boards menu
	When I create a new board with the following values
	| Field    | Value      |
	| Title    | Blue Board |
	| Security | Private    |
	| Color    | Blue       |
	And I open the Boards menu from top menu navigation
	Then the board should appear

Scenario: Permanently delete a board
	Given I navigate to "https://trello.com"
	And I log in as "survias@live.com"
	And I open the Boards menu from top menu navigation
	And I open the "Blue Board" board from the Boards menu
	And I open the board side menu
	And I click on "More" in the board side menu
	When I click on "Close Board..." in the board side menu
	And I click "Close" in the confirmation box
	And I click "Permanently Delete Board..." in the main panel
	And I click "Delete" in the confirmation box
	And I open the Boards menu from top menu navigation
	Then the board should not appear