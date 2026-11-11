using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint4.Task7.V1.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            string value = "135792468";

            // Четные цифры в строке: 2, 4, 6, 8 (всего 4 шт.)
            int res = ds.Calculate(n, m, value);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}