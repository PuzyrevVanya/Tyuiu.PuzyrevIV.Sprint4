using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint4.Task2.V17.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateMethod()
        {
            DataService ds = new DataService();

            int[] numsArray = { 3, 4, 5, 6, 7, 8, 9, 3, 5 };

            int wait = 14175;

            int res = ds.Calculate(numsArray);

            Assert.AreEqual(wait, res);
        }
    }
}
