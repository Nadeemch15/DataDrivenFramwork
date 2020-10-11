Feature: Successfull login user
	

@dataDriverTest
Scenario Outline: Login different users
	Given I click on login link of website
	And  I entered the login details <UserName>,<Password>
	When I click the login button
	Then I should be successfuly logged in
Examples:
| UserName | Password |
| test101  | 123@qwE  |
| test102  | 123@qwE  |
| test103  | 123@qwE  |
