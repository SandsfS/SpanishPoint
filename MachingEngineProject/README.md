
# MachingEngineProject Automation

This repository contains the automation project for testing the **Matching Engine** website using Selenium and NUnit.

## Project Structure

- `PageObjects/`: Contains Page Object Model (POM) classes that encapsulate web elements and actions.
- `Tests/`: Contains test classes that execute the automated test cases.
- `Reports/`: Generated test reports will be stored in this folder.
- `Helpers/`: Contains utility functions like reading/writing to CSV.

## Prerequisites

Ensure you have the following installed:
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Google Chrome](https://www.google.com/chrome/) (if using ChromeDriver)
- [Visual Studio](https://visualstudio.microsoft.com/) (if using Visual Studio for running tests)

### Dependencies

Ensure the following NuGet packages are included in your project:
- `NUnit`
- `NUnit3TestAdapter`
- `Selenium.WebDriver`
- `Selenium.WebDriver.ChromeDriver`
- `ExtentReports` (for reporting)
- `Microsoft.NET.Test.Sdk`

You can install them using the command line:

```bash
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package AventStack.ExtentReports
dotnet add package Microsoft.NET.Test.Sdk

##############################################################################
Running Test
-------------
Option 1: Through Command Line (CMD)
Step 1: cd C:\path\to\your\project\MachingEngineProject
Step 2: dotnet restore
Step 3: dotnet build
Step 4: dotnet test
Step 5: Generated report can be seen under this path- "C:\path\to\your\project\MachingEngineProject\Reports\TestReport.html"

Option 2: Running Tests Using Visual Studio (GUI)
1. Open the Project in Visual Studio
Open Visual Studio.
Load the solution (.sln file) from the project directory.
2. Build the Project
Click on Build > Build Solution or press Ctrl + Shift + B.
Ensure that the build is successful.
3. Run the Tests
Open the Test Explorer from Test > Windows > Test Explorer.
Click Run All to execute all tests or right-click on a specific test method and choose Run Selected Tests.
4. View Results
The test results will be shown directly in the Test Explorer window.
To view detailed logs, you can open the TestReport.html file generated in the Reports folder.








