Feature: Trello
	In order to prove out coding skill
	As a developer
	I want to use Trello as an automation example platform

@mytag
Scenario: Create a new board in Chrome
	Given I open Google Chrome
	And I navigate to "https://trello.com"
	And I log in as "survias@live.com"
	When I create a new board with the following values
	| Field    | Value      |
	| Title    | Blue Board |
	| Security | Private    |
	| Color    | Blue       |
	And I open Boards
	Then the board should appear

Scenario : Permanently delete a board in Chrome
	Given I open Google Chrome
	And I navigate to "https://trello.com"
	And I log in as "survias@live.com"
	And I open Boards
	And I open the "Blue Board" board
	And I open the board menu
	And I click on "More" in the board menu
	When I click on "Close Board..." in the board menu
	And I click "Close" in the confirmation box
	And I click "Permanently Delete Board..."
	And I click "Delete" in the confirmation box
	And I open Boards
	Then the board should not appear