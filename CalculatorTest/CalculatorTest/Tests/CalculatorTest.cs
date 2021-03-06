﻿namespace CalculatorTest
{
    using global::CalculatorTest.Driver;
    using global::CalculatorTest.Services;
    using global::CalculatorTest.Windows;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class CalculatorTest
    {
        private readonly CalculatorWindow window = new CalculatorWindow();

        [TestMethod]
        public void SqrtAndMultiplyTest()
        {
            const int maxRandomValue = 100;
            int initialNumber = NumberService.GetRandomInt(maxRandomValue);
            var numberDigits = NumberService.GetDigits(initialNumber);

            window.ClickClearButton();
            window.EnterNumber(numberDigits);
            window.ClickSqrtRootButton();
            double actualSqrt = window.GetResult();
            double expectedSqrt = Math.Sqrt(initialNumber);
            var delta = 0.000001;
            Assert.AreEqual(expectedSqrt, actualSqrt, delta, "Incorrect sqrt root");

            string expectedExpression = window.GetCalculatorExpression();
            string actualExpression = $"√({initialNumber})";
            Assert.AreEqual(expectedExpression, actualExpression, "Incorrect calculator expression");

            window.ClickMultiplyByButton();
            window.ClickEqualsButton();
            double actualResult = window.GetResult();
            double expectedResult = initialNumber;
            Assert.AreEqual(expectedResult, actualResult, "Result should be equal initial number, but it wasn't");
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            WinDriver.CloseWindows();
        }
    }
}
