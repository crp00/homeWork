Feature: BDD_Test_iPhone7
This test will search two phones (iPhone7, iPhone7Plus)
It will save their specs
It will compare specs that match and write them to console

@mytag
Scenario: Check iPhone 7 specs
	Given I am on rozetka main page
	When I enter search value Apple iPhone 7 and open first details page
	And I open details tab
	Then the details are corresponding to Apple iPhone 7
