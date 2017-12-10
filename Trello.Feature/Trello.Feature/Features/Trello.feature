Feature: Trello
	In order to prove out coding skill
	As a developer
	I want to use Trello as an automation example platform

@INPROGRESS
Scenario: Create a new board
	Given I log in to the test Trello instance
	And I click Create New Board... from Top Menu => Boards
	When I create a new board with the following values
	| Field    | Value      |
	| Title    | Blue Board |
	| Security | Private    |
	| Color    | Blue       |
	Then the board should exist in the Boards menu

Scenario: Permanently delete a board
	Given I log in to the test Trello instance
	And I open the Boards menu from top menu navigation
	And I open the "Blue Board" board from the Boards menu
	And I open the board side menu
	And I click on "More" in the board side menu
	When I click on "Close Board..." in the board side menu
	And I click "Close" in the confirmation box
	And I click "Permanently Delete Board..." in the main panel
	And I click "Delete" in the confirmation box
	Then the board should not exist in the Boards menu