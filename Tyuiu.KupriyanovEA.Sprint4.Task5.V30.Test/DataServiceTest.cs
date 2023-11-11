using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint4.Task5.V30.Lib;

namespace Tyuiu.KupriyanovEA.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { -2, -1, 0, 1, 2 },
                                           { 3, 4, -2, -1, 0 },
                                           { 1, 2, 3, 4, -2 },
                                           { -1, 0, 1, 2, 3 },
                                           { 4, -2, -1, 0, 1 } };
            int res = ds.Calculate(array);
            int wait = 31;
            Assert.AreEqual(wait, res);
        }
    }
}
