using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint4.Task1.V29.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateMethod()
        {
            DataService ds = new DataService();
            int[] numsArray = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };
            int wait = 31;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
