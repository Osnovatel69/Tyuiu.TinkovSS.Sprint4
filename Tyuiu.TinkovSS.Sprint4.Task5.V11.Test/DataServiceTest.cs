using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint4.Task5.V11.Lib;

namespace Tyuiu.TinkovSS.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] {
                { -7,  2, -3,  1, -5 },
                { -1, -4,  2, -6,  0 },
                { -2,  1, -3,  2, -7 },
                {  1, -5, -4,  0, -1 },
                { -6,  2, -2, -3,  1 }
            };

            int[,] res = ds.Calculate(mas);

            int[,] wait = new int[5, 5] {
                { -7,  1, -3,  1, -5 },
                { -1, -4,  1, -6,  0 },
                { -2,  1, -3,  1, -7 },
                {  1, -5, -4,  0, -1 },
                { -6,  1, -2, -3,  1 }
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}