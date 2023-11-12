using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint4.Task7.V27.Lib;

namespace Tyuiu.KupriyanovEA.Sprint4.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            int[,] matrix = new int[n, m];
            string value = "583197256891";
            int res = ds.Calculate(n, m, value);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
