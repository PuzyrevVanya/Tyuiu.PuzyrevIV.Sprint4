using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint4.Task5.V26.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_SampleArray_Returns81()
        {
            var ds = new DataService();
            int[,] input = new int[5, 5] {
                { 0,  1, -2,  4, -4 },
                { -1, 2,  3,  0, -3 },
                { 4, -4, 1, -2,  2 },
                { -3, 0, -1,  3,  4 },
                { 2, -2, 0, -4,  1 }
            };

            int[,] expected = new int[5, 5] {
                { 0, 1, -2, 1, -4 },
                { -1, 1, 1, 0, -3 },
                { 1, -4, 1, -2, 1 },
                { -3, 0, -1, 1, 1 },
                { 1, -2, 0, -4, 1 }
            };

            int[,] actual = ds.Calculate(input);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j], $"Несовпадение в элементе [{i},{j}]");
                }
            }
        }
    }
}
