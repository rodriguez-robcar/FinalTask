# FinalTask
 Automated Testing in .Net Final Task

## Task Description
The task is to automate the following scenarios:

Open the browser and navigate to the URL: https://www.saucedemo.com/

UC-1 Test Login form with empty credentials:
1. Type any credentials into "Username" and "Password" fields.
2. Clear the inputs.
3. Hit the "Login" button.
4. Check the error messages: "Username is required".

UC-2 Test Login form with credentials by passing Username:
1. Type any credentials in username.
2. Enter password.
3. Clear the "Password" input.
4. Hit the "Login" button.
5. Check the error messages: "Password is required".

UC-3 Test Login form with credentials by passing Username & Password:
1. Type credentials in username which are under Accepted username are sections.
2. Enter password as secret sauce.
3. Click on Login and validate the title “Swag Labs” in the dashboard.

## Features
- Scenarios fully automated.
- Parallel execution.
- Logging.
- Data provider to parametrize the test cases.
- Page Object Model.
- XPath locators.
- Fluent assertions.

## Technologies Used
- **Selenium WebDriver**: Used to interact with browsers.
- **Edge and Chrome**: Browsers used for testing.
- **MSTest Framework**: Unit test framework.
- **NLog**: Used for logging.
- **C#**: For creating the automated scenarios.

## Installation

1. Clone the repository:
   git clone https://github.com/rodriguez-robcar/FinalTask.git