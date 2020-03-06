namespace CalculatorTest.Windows
{
    using global::CalculatorTest.Driver;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Winium;
    using Winium.Elements.Desktop;

    public class CalculatorWindow
    {
        private void ClickDigit(int digit)
        {
            switch (digit)
            {
                case 0:
                    ClickZeroButon();
                    break;
                case 1:
                    ClickOneButon();
                    break;
                case 2:
                    ClickTwoButon();
                    break;
                case 3:
                    ClickThreeButon();
                    break;
                case 4:
                    ClickFourButon();
                    break;
                case 5:
                    ClickFiveButon();
                    break;
                case 6:
                    ClickSixButon();
                    break;
                case 7:
                    ClickSevenButon();
                    break;
                case 8:
                    ClickEightButon();
                    break;
                case 9:
                    ClickNineButon();
                    break;
            }
        }

        public void EnterNumber(params int[] digits)
        {
            foreach (var dig in digits)
            {
                ClickDigit(dig);
            }
        }

        public void ClickZeroButon()
        {
            WinDriver.GetDriver().FindElementByName("0").Click();
        }

        public void ClickOneButon()
        {
            WinDriver.GetDriver().FindElementByName("One").Click();
        }

        public void ClickTwoButon()
        {
            WinDriver.GetDriver().FindElementByName("Two").Click();
        }

        public void ClickThreeButon()
        {
            WinDriver.GetDriver().FindElementByName("Three").Click();
        }

        public void ClickFourButon()
        {
            WinDriver.GetDriver().FindElementByName("Four").Click();
        }

        public void ClickFiveButon()
        {
            WinDriver.GetDriver().FindElementByName("Five").Click();
        }

        public void ClickSixButon()
        {
            WinDriver.GetDriver().FindElementByName("Six").Click();
        }

        public void ClickSevenButon()
        {
            WinDriver.GetDriver().FindElementByName("Seven").Click();
        }

        public void ClickEightButon()
        {
            WinDriver.GetDriver().FindElementByName("Eight").Click();
        }

        public void ClickNineButon()
        {
            WinDriver.GetDriver().FindElementByName("Nine").Click();
        }

        public void ClickSqrtRootButon()
        {
            WinDriver.GetDriver().FindElementByName("Square root").Click();
        }

        public void ClickMultiplyByButon()
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
            return WinDriver.GetDriver().FindElementById("CalculatorResults").GetAttribute("Name").Replace("Display is ", string.Empty);
        }
    }
}
