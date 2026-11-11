using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint4.Task0.V30.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            int res = ds.Calculate(array);
            int wait = 30;

            Assert.AreEqual(wait, res);
        }
    }
}