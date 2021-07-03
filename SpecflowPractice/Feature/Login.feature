#Feature: Payment
#	In order to do my payments
#	As a user I have to login to the application
#	I want to checkout and do payments


Feature: Login
	In order to access my appliation
	As a user I launch the application
	I want to provide login details and then I login to the applicaiton

Background: 
Given as a user i should launch the web application
	When user click on SignIn button
	


@Sanity
Scenario: login to the application
	When user enter prashanthi.tirunagaris@gmail.com and Training@123
	And user click on Submit button
	Then user should login successfully
	And I should see AddToCart 
	But shouldn't login to the applicaiton

	
@Sanity
Scenario: login to the application with invalid user
	When user enter jajshd@gmail.com and tesst123
	And user click on Submit button
	Then user should not login successfully


