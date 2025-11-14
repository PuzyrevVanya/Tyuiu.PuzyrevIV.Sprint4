using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint4.Task4.V11.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_SampleArray_Returns81()
        {
            var ds = new DataService();
            int[,] mas = new int[5, 5] {
                { 5, 7, 7, 8, 5 },
                { 6, 5, 6, 8, 6 },
                { 7, 6, 8, 8, 5 },
                { 7, 6, 7, 8, 6 },
                { 7, 6, 7, 7, 5 }
            };

            int expected = 81;

            int actual = ds.Calculate(mas);

            Assert.AreEqual(expected, actual);
        }
    }
}

