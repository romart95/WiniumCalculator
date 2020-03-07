using System;
using System.Collections.Generic;

namespace CalculatorTest.Services
{
    public static class NumberService
    {
        private static Random random;

        private static Random GetRandom()
        {
            random = random ?? new Random((int)DateTime.Now.Ticks);
            return random;
        }

        public static int GetRandomInt(int max)
        {
            return GetRandom().Next(max);
        }

        public static int[] GetDigits(int value)
        {
            var result = new List<int>();
            while (value != 0)
            {
                result.Add(value % 10);
                value /= 10;
            }
            result.Reverse();
            return result.ToArray();
        }
    }
}
