namespace CalculatorTest.Services
{
    using OpenQA.Selenium.Winium;
    using System.IO;

    public static class ApplicationService
    {
        private static string applicationPath = @"C:\Windows\System32\calc.exe";

        public static string GetProjectPath()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        }

        public static DesktopOptions GetDesktopOptions()
        {
            return new DesktopOptions
            {
                ApplicationPath = applicationPath
            };
        }
    }
}
