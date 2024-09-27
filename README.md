
# MachingEngineProject Automation

This repository contains an automation project for testing the Matching Engine website using Selenium and NUnit, with C# as the programming language.

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

##########################################################################################################################################

**Troubleshooting**
Common Issues

ChromeDriver version mismatch: Ensure that the ChromeDriver version matches the version of Chrome installed on your machine. You can update it via NuGet or download the correct version from ChromeDriver downloads.

Failed to load NUnit Test Adapter: Ensure that you have the NUnit3TestAdapter and Microsoft.NET.Test.Sdk packages installed.

Unable to generate test reports: Verify that the ExtentReports package is correctly installed and that the file path to the report is properly set.

___________________________________________________________________________________________________________________________________________________________________
**Author**
This project was created by Sangeeta Kumari. Feel free to contribute or report issues!
### Key Points:

- The `README.md` provides clear instructions for setting up and running tests via both the command line and Visual Studio.
- It outlines prerequisites, dependencies, and steps for restoring, building, and testing.
- It covers both test execution and report generation and explains how to troubleshoot common issues.

Let me know if you need more details or adjustments!


