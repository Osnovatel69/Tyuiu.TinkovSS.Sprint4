using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint4.Task1.V11.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
            int res = ds.Calculate(numsArray);

            // Чётные числа: 2 + 6 + 6 + 6 + 6 + 6 = 26
            int wait = 26;

            Assert.AreEqual(wait, res);
        }
    }
}