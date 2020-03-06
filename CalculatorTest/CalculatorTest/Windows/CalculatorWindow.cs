namespace CalculatorTest.Windows
{
    using System;
    using global::CalculatorTest.Driver;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;
    using Winium.Elements.Desktop;

    public class CalculatorWindow
    {
        private string numButtonId = "num{0}Button";

        private void ClickDigit(int digit)
        {
            var id = string.Format(numButtonId, digit);
            WinDriver.GetDriver().FindElementById(id).Click();
        }

        public void EnterNumber(params int[] digits)
        {
            foreach (var dig in digits)
            {
                ClickDigit(dig);
            }
        }
        public void ClickSqrtRootButton()
        {
            WinDriver.GetDriver().FindElementByName("Square root").Click();
        }

        public void ClickMultiplyByButton()
        {
            WinDriver.GetDriver().FindElementByName("Multiply by").Click();
        }

        public void ClickEqualsButton()
        {
            WinDriver.GetDriver().FindElementByName("Equals").Click();
        }

        public void ClickClearButton()
        {
            WinDriver.GetDriver().FindElementByName("Clear").Click();
        }

        public string GetCalculatorExpression()
        {
            return WinDriver.GetDriver().FindElementById("CalculatorExpression").GetAttribute("Name").Replace("Expression is ", string.Empty);
        }

        public double GetResult()
        {
            return double.Parse(WinDriver.GetDriver().FindElementById("CalculatorResults").GetAttribute("Name").Replace("Display is ", string.Empty));
        }
    }
}
