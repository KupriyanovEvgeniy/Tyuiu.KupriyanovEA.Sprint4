using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint4.Task2.V29.Lib;

namespace Tyuiu.KupriyanovEA.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3 };

            int res = ds.Calculate(array);
            int wait = 768;

            Assert.AreEqual(wait, res);
        }
    }
}
