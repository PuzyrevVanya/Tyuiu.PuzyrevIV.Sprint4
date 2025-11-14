using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PuzyrevIV.Sprint4.Task6.V24.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var week = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            string[] res = ds.Calculate(week);
            int wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
