namespace CalculatorTest.Driver
{
    using global::CalculatorTest.Services;
    using OpenQA.Selenium.Winium;
    using System.Diagnostics;

    public class WinDriver
    {
        private static WiniumDriver driver;

        public static WiniumDriver GetDriver()
        {
            if (driver == null)
            {
                string driverPath = $@"{ApplicationService.GetProjectPath()}\CalculatorTest\Driver";
                driver = new WiniumDriver(driverPath, ApplicationService.GetDesktopOptions());
            }

            return driver;
        }

        // Close all calculators
        public static void CloseWindows()
        {
            var processes = Process.GetProcessesByName("Calculator.exe");
            foreach (var proc in processes)
            {
                proc.CloseMainWindow();
            }

            driver = null;
        }
    }

   
}
