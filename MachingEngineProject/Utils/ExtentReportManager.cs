using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace MachingEngineProject
{
    public static class ExtentReportManager
    {
        private static ExtentReports extent;
        private static ExtentTest test;
        private static string reportPath;

        // Initialize ExtentReports and SparkReporter only once
        public static void InitializeReport()
        {
            if (extent == null)
            {
                
                string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                string reportDir = Path.Combine(projectRoot, "Reports");
                Directory.CreateDirectory(reportDir);
                

                reportPath = Path.Combine(reportDir, "TestReport.html");

                // Initialize ExtentSparkReporter
                var sparkReporter = new ExtentSparkReporter(reportPath);
                sparkReporter.Config.DocumentTitle = "Test Execution Report";
                sparkReporter.Config.ReportName = "MatchingEngine Project Report";

                // Initialize ExtentReports and attach the Spark reporter
                extent = new ExtentReports();
                extent.AttachReporter(sparkReporter);

                // Optional: Add system information (e.g., browser type, OS, etc.)
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("User", "TestUser");
            }
        }

        // Start logging a new test
        public static void StartTest(string testName)
        {
            test = extent.CreateTest(testName);
        }

        // End the test and flush the report
        public static void EndTest()
        {
            extent.Flush(); // Save the report to disk
        }

        // Logging information, pass, fail, etc.
        public static void Log(string message)
        {
            test.Log(AventStack.ExtentReports.Status.Info, message);
        }

        public static void LogPass(string message)
        {
            test.Log(AventStack.ExtentReports.Status.Pass, message);
        }

        public static void LogFail(string message)
        {
            test.Log(AventStack.ExtentReports.Status.Fail, message);
        }

        public static void LogError(string message)
        {
            test.Log(AventStack.ExtentReports.Status.Error, message);
        }
    }
}
