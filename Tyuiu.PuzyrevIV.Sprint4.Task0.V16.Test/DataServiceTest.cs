using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint4.Task0.V16.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int wait = 3072;
            int res = ds.GetMultEvenArrEl(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}
