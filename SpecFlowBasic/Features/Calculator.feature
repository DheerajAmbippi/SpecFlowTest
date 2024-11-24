Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowBasic/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag 
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	And the message should be "thankyou"

	Scenario: Calculate multiple number
	Given : the input following numbers to calculater
	| Numbers |
	| 25     |
	| 50     |
	And the operation need to flow
	| Operations |
	| plus       |
	| substract  |
	Then the result should for Addition
	| Result | Operation |
	| 75     | plus      |
