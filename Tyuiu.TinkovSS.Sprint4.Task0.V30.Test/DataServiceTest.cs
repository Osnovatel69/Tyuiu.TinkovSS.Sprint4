using Tyuiu.TinkovSS.Sprint4.Task0.V30.Lib;

using Miusing Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint4.Task0.V30.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetSumEvenArrEl(numsArray);

            // Четные элементы: 8 + 4 + 6 + 4 + 6 + 2 = 30
            int wait = 30;

            Assert.AreEqual(wait, res);
        }
    }
}