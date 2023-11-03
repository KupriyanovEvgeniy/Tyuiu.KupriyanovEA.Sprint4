using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint4.Task3.V26.Lib;

namespace Tyuiu.KupriyanovEA.Sprint4.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { 4, 3, 2, 6, 2 },
                                           { 5, 2, 2, 5, 6 },
                                           { 2, 5, 4, 5, 6 },
                                           { 4, 5, 2, 4, 6 },
                                           { 6, 5, 4, 3, 6 } };
            int res = ds.Calculate(array);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
